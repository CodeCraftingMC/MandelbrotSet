using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelbrotSet
{
    public partial class RenderForm : Form
    {
        public RenderForm()
        {
            InitializeComponent();
        }

        public RenderForm(Vector2d offset, double zoom) : this()
        {
            NUDEndX.Value = (decimal)offset.X;
            NUDEndY.Value = (decimal)offset.Y;
            NUDEndZoom.Value = (decimal)zoom;
        }

        private void BWRenderer_DoWork(object sender, DoWorkEventArgs e)
        {
            double startX = (double)NUDEndX.Value;
            double startY = (double)NUDEndY.Value;
            double startZoom = (double)NUDStartZoom.Value;
            double endX = (double)NUDEndX.Value;
            double endY = (double)NUDEndY.Value;
            double endZoom = (double)NUDEndZoom.Value;
            decimal fps = NUDFps.Value;
            decimal duration = NUDDuration.Value;
            decimal iterations = NUDIterations.Value;

            decimal frameCount = fps * duration;
            int progress = 0;

            Directory.CreateDirectory("render");

            Parallel.For(0, (int)frameCount, i =>
            {
                double interpolationFactor = (double)i / (double)(frameCount - 1);

                double currentX = startX + interpolationFactor * (endX - startX);
                double currentY = startY + interpolationFactor * (endY - startY);
                double currentZoom = startZoom + interpolationFactor * (endZoom - startZoom);

                Bitmap bmp = ViewerForm.CachedGenerate(500, 500, new Vector2d(currentX, currentY), currentZoom, iterations);

                bmp.Save($"render\\frame_{i.ToString().PadLeft(frameCount.ToString().Length, '0')}.png");
                bmp.Dispose();

                Interlocked.Increment(ref progress);
                BWRenderer.ReportProgress((int)(progress / frameCount * 100));
            });
        }

        private void BWRenderer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PBRender.Minimum = 0;
            PBRender.Maximum = 100;
            PBRender.Value = e.ProgressPercentage;
        }

        private void BWRenderer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Rendering completed.", "Renderer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRender_Click(object sender, EventArgs e)
        {
            PBRender.Value = 0;
            BWRenderer.RunWorkerAsync();
        }
    }
}
