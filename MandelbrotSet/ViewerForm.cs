using System.Drawing.Imaging;

namespace MandelbrotSet
{
    public partial class ViewerForm : Form
    {
        Vector2d Offset;
        double Zoom;

        static readonly Dictionary<(int width, int height, Vector2d offset, double zoomIndex, decimal iterations), Bitmap> GenerateCache = [];
        static readonly object DoIterationCacheLock = new();

        public ViewerForm()
        {
            InitializeComponent();
            Zoom = 1;
        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            Zoom -= 1;
            Generate();
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            Zoom += 1;
            Generate();
        }

        private void BtnYPosUp_Click(object sender, EventArgs e)
        {
            Offset.Y -= 1 / Math.Pow(2, Zoom) * 50;
            Generate();
        }

        private void BtnYPosDown_Click(object sender, EventArgs e)
        {
            Offset.Y += 1 / Math.Pow(2, Zoom) * 50;
            Generate();
        }

        private void BtnXPosDown_Click(object sender, EventArgs e)
        {
            Offset.X -= 1 / Math.Pow(2, Zoom) * 50;
            Generate();
        }

        private void BtnXPosUp_Click(object sender, EventArgs e)
        {
            Offset.X += 1 / Math.Pow(2, Zoom) * 50;
            Generate();
        }

        private void BtnPosReset_Click(object sender, EventArgs e)
        {
            Offset.X = 0;
            Offset.Y = 0;
            Generate();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        void Generate()
        {
            Enabled = false;
            PBViewer.SuspendLayout();
            PBViewer.Image = CachedGenerate(PBViewer.Width / 4, PBViewer.Height / 4, Offset, Zoom, NUDIterations.Value);
            PBViewer.ResumeLayout(true);
            Enabled = true;
        }

        public static Bitmap CachedGenerate(int width, int height, Vector2d offset, double zoomIndex, decimal iterations)
        {
            var args = (width, height, offset, zoomIndex, iterations);

            if(GenerateCache.TryGetValue(args, out Bitmap? value)) return value;
            else
            {
                Bitmap bmp = Generate(width, height, offset, zoomIndex, iterations);
                GenerateCache.Add(args, bmp);
                return bmp;
            }
        }

        public static Bitmap Generate(int width, int height, Vector2d offset, double zoomIndex, decimal iterations)
        {
            double zoom = 1 / Math.Pow(2, zoomIndex);
            double widthHalf = width / 2d;
            double heightHalf = height / 2d;
            Bitmap bmp = new(width, height, PixelFormat.Format32bppArgb);

            Vector2d f(Vector2d z, Vector2d c) => new Vector2d(Math.Pow(z.X, 2) - Math.Pow(z.Y, 2), 2 * z.X * z.Y) + c;
            double l(Vector2d z) => Math.Pow(z.X, 2) + Math.Pow(z.Y, 2);

            Vector2d doIteration(Vector2d z, Vector2d c, decimal currentIteration, decimal maxIterations)
            {
                if (currentIteration >= maxIterations) return z;
                return doIteration(f(z, c), c, currentIteration + 1, maxIterations);
            }

            Rectangle rect = new(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

            int bytesPerPixel = Image.GetPixelFormatSize(bmp.PixelFormat) / 8;

            unsafe
            {
                byte* ptr = (byte*)bmpData.Scan0;

                Parallel.For(0, height, y =>
                {
                    Parallel.For(0, width, x =>
                    {
                        Vector2d c = new((x - widthHalf - zoom / 2) * zoom + offset.X, (y - heightHalf - zoom / 2) * zoom + offset.Y);

                        double v = l(doIteration(new(0, 0), c, 0, iterations));

                        double hue = (double)(v % 256) / 256.0;
                        double saturation = 1.0;
                        double lightness = 0.5;

                        Color pixelColor = HSLToRGB(hue * 360, saturation, lightness);
                        int index = y * bmpData.Stride + x * bytesPerPixel;
                        ptr[index + 3] = pixelColor.A; // Alpha
                        ptr[index + 2] = pixelColor.R; // Red
                        ptr[index + 1] = pixelColor.G; // Green
                        ptr[index] = pixelColor.B;     // Blue
                    });
                });

            }

            bmp.UnlockBits(bmpData);

            return bmp;
        }

        private void BtnRender_Click(object sender, EventArgs e)
        {
            RenderForm form = new(Offset, Zoom);
            form.ShowDialog();
            form.Dispose();
        }

        private static Color HSLToRGB(double hue, double saturation, double lightness)
        {
            if (saturation == 0)
            {
                byte value = (byte)(lightness * 255);
                return Color.FromArgb(value, value, value);
            }

            double t1, t2;
            double th = hue / 6.0;

            if (lightness < 0.5)
            {
                t2 = lightness * (1.0 + saturation);
            }
            else
            {
                t2 = lightness + saturation - (lightness * saturation);
            }

            t1 = 2.0 * lightness - t2;

            static byte ToRGB(double value)
            {
                double v = (value < 0) ? 0 : ((value > 1) ? 1 : value);
                return (byte)(255 * (v));
            }

            return Color.FromArgb(
                ToRGB(HueToRGB(t1, t2, th + (1.0 / 3.0))),
                ToRGB(HueToRGB(t1, t2, th)),
                ToRGB(HueToRGB(t1, t2, th - (1.0 / 3.0)))
            );
        }

        private static double HueToRGB(double t1, double t2, double th)
        {
            if (th < 0) th += 1.0;
            if (th > 1) th -= 1.0;
            if (6.0 * th < 1.0) return t1 + (t2 - t1) * 6.0 * th;
            if (2.0 * th < 1.0) return t2;
            if (3.0 * th < 2.0) return t1 + (t2 - t1) * ((2.0 / 3.0) - th) * 6.0;
            return t1;
        }
    }
}
