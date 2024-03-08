namespace MandelbrotSet
{
    partial class ViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PBViewer = new PictureBox();
            BtnZoomIn = new Button();
            BtnZoomOut = new Button();
            label1 = new Label();
            BtnYPosUp = new Button();
            BtnYPosDown = new Button();
            BtnXPosDown = new Button();
            BtnXPosUp = new Button();
            BtnPosReset = new Button();
            NUDIterations = new NumericUpDown();
            label2 = new Label();
            BtnGenerate = new Button();
            BtnRender = new Button();
            ((System.ComponentModel.ISupportInitialize)PBViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDIterations).BeginInit();
            SuspendLayout();
            // 
            // PBViewer
            // 
            PBViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PBViewer.Location = new Point(12, 12);
            PBViewer.Name = "PBViewer";
            PBViewer.Size = new Size(597, 426);
            PBViewer.SizeMode = PictureBoxSizeMode.Zoom;
            PBViewer.TabIndex = 0;
            PBViewer.TabStop = false;
            // 
            // BtnZoomIn
            // 
            BtnZoomIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnZoomIn.Location = new Point(713, 30);
            BtnZoomIn.Name = "BtnZoomIn";
            BtnZoomIn.Size = new Size(75, 23);
            BtnZoomIn.TabIndex = 1;
            BtnZoomIn.Text = "+";
            BtnZoomIn.UseVisualStyleBackColor = true;
            BtnZoomIn.Click += BtnZoomIn_Click;
            // 
            // BtnZoomOut
            // 
            BtnZoomOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnZoomOut.Location = new Point(632, 30);
            BtnZoomOut.Name = "BtnZoomOut";
            BtnZoomOut.Size = new Size(75, 23);
            BtnZoomOut.TabIndex = 1;
            BtnZoomOut.Text = "-";
            BtnZoomOut.UseVisualStyleBackColor = true;
            BtnZoomOut.Click += BtnZoomOut_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(632, 12);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Zoom: ";
            // 
            // BtnYPosUp
            // 
            BtnYPosUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnYPosUp.Location = new Point(722, 59);
            BtnYPosUp.Name = "BtnYPosUp";
            BtnYPosUp.Size = new Size(30, 30);
            BtnYPosUp.TabIndex = 1;
            BtnYPosUp.Text = "/\\";
            BtnYPosUp.UseVisualStyleBackColor = true;
            BtnYPosUp.Click += BtnYPosUp_Click;
            // 
            // BtnYPosDown
            // 
            BtnYPosDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnYPosDown.Location = new Point(722, 131);
            BtnYPosDown.Name = "BtnYPosDown";
            BtnYPosDown.Size = new Size(30, 30);
            BtnYPosDown.TabIndex = 1;
            BtnYPosDown.Text = "\\/";
            BtnYPosDown.UseVisualStyleBackColor = true;
            BtnYPosDown.Click += BtnYPosDown_Click;
            // 
            // BtnXPosDown
            // 
            BtnXPosDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnXPosDown.Location = new Point(686, 95);
            BtnXPosDown.Name = "BtnXPosDown";
            BtnXPosDown.Size = new Size(30, 30);
            BtnXPosDown.TabIndex = 1;
            BtnXPosDown.Text = "<";
            BtnXPosDown.UseVisualStyleBackColor = true;
            BtnXPosDown.Click += BtnXPosDown_Click;
            // 
            // BtnXPosUp
            // 
            BtnXPosUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnXPosUp.Location = new Point(758, 95);
            BtnXPosUp.Name = "BtnXPosUp";
            BtnXPosUp.Size = new Size(30, 30);
            BtnXPosUp.TabIndex = 1;
            BtnXPosUp.Text = ">";
            BtnXPosUp.UseVisualStyleBackColor = true;
            BtnXPosUp.Click += BtnXPosUp_Click;
            // 
            // BtnPosReset
            // 
            BtnPosReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPosReset.Location = new Point(722, 95);
            BtnPosReset.Name = "BtnPosReset";
            BtnPosReset.Size = new Size(30, 30);
            BtnPosReset.TabIndex = 1;
            BtnPosReset.Text = "#";
            BtnPosReset.UseVisualStyleBackColor = true;
            BtnPosReset.Click += BtnPosReset_Click;
            // 
            // NUDIterations
            // 
            NUDIterations.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NUDIterations.Location = new Point(632, 220);
            NUDIterations.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            NUDIterations.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDIterations.Name = "NUDIterations";
            NUDIterations.Size = new Size(156, 23);
            NUDIterations.TabIndex = 3;
            NUDIterations.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(632, 202);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Iterations:";
            // 
            // BtnGenerate
            // 
            BtnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnGenerate.Location = new Point(713, 415);
            BtnGenerate.Name = "BtnGenerate";
            BtnGenerate.Size = new Size(75, 23);
            BtnGenerate.TabIndex = 1;
            BtnGenerate.Text = "Generate";
            BtnGenerate.UseVisualStyleBackColor = true;
            BtnGenerate.Click += BtnGenerate_Click;
            // 
            // BtnRender
            // 
            BtnRender.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRender.Location = new Point(632, 415);
            BtnRender.Name = "BtnRender";
            BtnRender.Size = new Size(75, 23);
            BtnRender.TabIndex = 1;
            BtnRender.Text = "Render";
            BtnRender.UseVisualStyleBackColor = true;
            BtnRender.Click += BtnRender_Click;
            // 
            // ViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NUDIterations);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnXPosUp);
            Controls.Add(BtnXPosDown);
            Controls.Add(BtnYPosDown);
            Controls.Add(BtnPosReset);
            Controls.Add(BtnYPosUp);
            Controls.Add(BtnZoomOut);
            Controls.Add(BtnRender);
            Controls.Add(BtnGenerate);
            Controls.Add(BtnZoomIn);
            Controls.Add(PBViewer);
            Name = "ViewerForm";
            Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)PBViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDIterations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBViewer;
        private Button BtnZoomIn;
        private Button BtnZoomOut;
        private Label label1;
        private Button BtnYPosUp;
        private Button BtnYPosDown;
        private Button BtnXPosDown;
        private Button BtnXPosUp;
        private Button BtnPosReset;
        private NumericUpDown NUDIterations;
        private Label label2;
        private Button BtnGenerate;
        private Button BtnRender;
    }
}
