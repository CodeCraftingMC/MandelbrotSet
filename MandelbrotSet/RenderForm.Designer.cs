namespace MandelbrotSet
{
    partial class RenderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NUDFps = new NumericUpDown();
            NUDDuration = new NumericUpDown();
            NUDStartZoom = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NUDEndX = new NumericUpDown();
            NUDEndY = new NumericUpDown();
            NUDEndZoom = new NumericUpDown();
            label9 = new Label();
            NUDIterations = new NumericUpDown();
            BtnRender = new Button();
            BtnCancel = new Button();
            PBRender = new ProgressBar();
            BWRenderer = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)NUDFps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDStartZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDEndX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDEndY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDEndZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDIterations).BeginInit();
            SuspendLayout();
            // 
            // NUDFps
            // 
            NUDFps.Location = new Point(12, 27);
            NUDFps.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            NUDFps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDFps.Name = "NUDFps";
            NUDFps.Size = new Size(120, 23);
            NUDFps.TabIndex = 0;
            NUDFps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NUDDuration
            // 
            NUDDuration.Location = new Point(12, 71);
            NUDDuration.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            NUDDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDDuration.Name = "NUDDuration";
            NUDDuration.Size = new Size(120, 23);
            NUDDuration.TabIndex = 1;
            NUDDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NUDStartZoom
            // 
            NUDStartZoom.DecimalPlaces = 99;
            NUDStartZoom.Location = new Point(12, 159);
            NUDStartZoom.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            NUDStartZoom.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            NUDStartZoom.Name = "NUDStartZoom";
            NUDStartZoom.Size = new Size(120, 23);
            NUDStartZoom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "FPS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Duration (Seconds):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 141);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 2;
            label5.Text = "Start Zoom:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 185);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 2;
            label6.Text = "End X:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 185);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 2;
            label7.Text = "End Y:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(264, 185);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 2;
            label8.Text = "End Zoom:";
            // 
            // NUDEndX
            // 
            NUDEndX.DecimalPlaces = 99;
            NUDEndX.Location = new Point(12, 203);
            NUDEndX.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            NUDEndX.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            NUDEndX.Name = "NUDEndX";
            NUDEndX.Size = new Size(120, 23);
            NUDEndX.TabIndex = 1;
            // 
            // NUDEndY
            // 
            NUDEndY.DecimalPlaces = 99;
            NUDEndY.Location = new Point(138, 203);
            NUDEndY.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            NUDEndY.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            NUDEndY.Name = "NUDEndY";
            NUDEndY.Size = new Size(120, 23);
            NUDEndY.TabIndex = 1;
            // 
            // NUDEndZoom
            // 
            NUDEndZoom.DecimalPlaces = 99;
            NUDEndZoom.Location = new Point(264, 203);
            NUDEndZoom.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            NUDEndZoom.Minimum = new decimal(new int[] { -1, -1, -1, int.MinValue });
            NUDEndZoom.Name = "NUDEndZoom";
            NUDEndZoom.Size = new Size(120, 23);
            NUDEndZoom.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 97);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 2;
            label9.Text = "Iterations:";
            // 
            // NUDIterations
            // 
            NUDIterations.Location = new Point(12, 115);
            NUDIterations.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            NUDIterations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDIterations.Name = "NUDIterations";
            NUDIterations.Size = new Size(120, 23);
            NUDIterations.TabIndex = 1;
            NUDIterations.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnRender
            // 
            BtnRender.Location = new Point(309, 279);
            BtnRender.Name = "BtnRender";
            BtnRender.Size = new Size(75, 23);
            BtnRender.TabIndex = 3;
            BtnRender.Text = "Render";
            BtnRender.UseVisualStyleBackColor = true;
            BtnRender.Click += BtnRender_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(12, 279);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PBRender
            // 
            PBRender.Location = new Point(12, 250);
            PBRender.Name = "PBRender";
            PBRender.Size = new Size(372, 23);
            PBRender.TabIndex = 4;
            // 
            // BWRenderer
            // 
            BWRenderer.WorkerReportsProgress = true;
            BWRenderer.DoWork += BWRenderer_DoWork;
            BWRenderer.ProgressChanged += BWRenderer_ProgressChanged;
            BWRenderer.RunWorkerCompleted += BWRenderer_RunWorkerCompleted;
            // 
            // RenderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(396, 314);
            Controls.Add(PBRender);
            Controls.Add(BtnCancel);
            Controls.Add(BtnRender);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NUDEndZoom);
            Controls.Add(NUDStartZoom);
            Controls.Add(NUDEndY);
            Controls.Add(NUDEndX);
            Controls.Add(NUDIterations);
            Controls.Add(NUDDuration);
            Controls.Add(NUDFps);
            Name = "RenderForm";
            Text = "Renderer";
            ((System.ComponentModel.ISupportInitialize)NUDFps).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDStartZoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDEndX).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDEndY).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDEndZoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDIterations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NUDFps;
        private NumericUpDown NUDDuration;
        private NumericUpDown NUDStartZoom;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown NUDEndX;
        private NumericUpDown NUDEndY;
        private NumericUpDown NUDEndZoom;
        private Label label9;
        private NumericUpDown NUDIterations;
        private Button BtnRender;
        private Button BtnCancel;
        private ProgressBar PBRender;
        private System.ComponentModel.BackgroundWorker BWRenderer;
    }
}