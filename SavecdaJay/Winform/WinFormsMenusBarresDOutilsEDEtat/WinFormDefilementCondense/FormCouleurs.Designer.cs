namespace WinFormDefilementCondense
{
    partial class FormCouleurs
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
            this.label_Red = new System.Windows.Forms.Label();
            this.label_Green = new System.Windows.Forms.Label();
            this.label_Blue = new System.Windows.Forms.Label();
            this.panel_ColorResult = new System.Windows.Forms.Panel();
            this.panel_Red = new System.Windows.Forms.Panel();
            this.panel_Green = new System.Windows.Forms.Panel();
            this.panel_Blue = new System.Windows.Forms.Panel();
            this.hScrollBar_Red = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Green = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Blue = new System.Windows.Forms.HScrollBar();
            this.numericUpDown_Red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Blue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Red
            // 
            this.label_Red.AutoSize = true;
            this.label_Red.Location = new System.Drawing.Point(23, 63);
            this.label_Red.Name = "label_Red";
            this.label_Red.Size = new System.Drawing.Size(27, 15);
            this.label_Red.TabIndex = 0;
            this.label_Red.Text = "Red";
            // 
            // label_Green
            // 
            this.label_Green.AutoSize = true;
            this.label_Green.Location = new System.Drawing.Point(23, 103);
            this.label_Green.Name = "label_Green";
            this.label_Green.Size = new System.Drawing.Size(38, 15);
            this.label_Green.TabIndex = 1;
            this.label_Green.Text = "Green";
            // 
            // label_Blue
            // 
            this.label_Blue.AutoSize = true;
            this.label_Blue.Location = new System.Drawing.Point(23, 148);
            this.label_Blue.Name = "label_Blue";
            this.label_Blue.Size = new System.Drawing.Size(30, 15);
            this.label_Blue.TabIndex = 2;
            this.label_Blue.Text = "Blue";
            // 
            // panel_ColorResult
            // 
            this.panel_ColorResult.Location = new System.Drawing.Point(23, 189);
            this.panel_ColorResult.Name = "panel_ColorResult";
            this.panel_ColorResult.Size = new System.Drawing.Size(410, 100);
            this.panel_ColorResult.TabIndex = 3;
            // 
            // panel_Red
            // 
            this.panel_Red.Location = new System.Drawing.Point(361, 55);
            this.panel_Red.Name = "panel_Red";
            this.panel_Red.Size = new System.Drawing.Size(72, 23);
            this.panel_Red.TabIndex = 4;
            // 
            // panel_Green
            // 
            this.panel_Green.Location = new System.Drawing.Point(361, 95);
            this.panel_Green.Name = "panel_Green";
            this.panel_Green.Size = new System.Drawing.Size(72, 23);
            this.panel_Green.TabIndex = 5;
            // 
            // panel_Blue
            // 
            this.panel_Blue.Location = new System.Drawing.Point(361, 140);
            this.panel_Blue.Name = "panel_Blue";
            this.panel_Blue.Size = new System.Drawing.Size(72, 23);
            this.panel_Blue.TabIndex = 6;
            // 
            // hScrollBar_Red
            // 
            this.hScrollBar_Red.Location = new System.Drawing.Point(92, 61);
            this.hScrollBar_Red.Maximum = 264;
            this.hScrollBar_Red.Name = "hScrollBar_Red";
            this.hScrollBar_Red.Size = new System.Drawing.Size(163, 17);
            this.hScrollBar_Red.TabIndex = 7;
            this.hScrollBar_Red.ValueChanged += new System.EventHandler(this.hScrollBar_Red_ValueChanged);
            // 
            // hScrollBar_Green
            // 
            this.hScrollBar_Green.Location = new System.Drawing.Point(92, 101);
            this.hScrollBar_Green.Maximum = 264;
            this.hScrollBar_Green.Name = "hScrollBar_Green";
            this.hScrollBar_Green.Size = new System.Drawing.Size(163, 17);
            this.hScrollBar_Green.TabIndex = 8;
            this.hScrollBar_Green.ValueChanged += new System.EventHandler(this.hScrollBar_Green_ValueChanged);
            // 
            // hScrollBar_Blue
            // 
            this.hScrollBar_Blue.Location = new System.Drawing.Point(92, 146);
            this.hScrollBar_Blue.Maximum = 264;
            this.hScrollBar_Blue.Name = "hScrollBar_Blue";
            this.hScrollBar_Blue.Size = new System.Drawing.Size(163, 17);
            this.hScrollBar_Blue.TabIndex = 9;
            this.hScrollBar_Blue.ValueChanged += new System.EventHandler(this.hScrollBar_Blue_ValueChanged);
            // 
            // numericUpDown_Red
            // 
            this.numericUpDown_Red.Location = new System.Drawing.Point(284, 55);
            this.numericUpDown_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Red.Name = "numericUpDown_Red";
            this.numericUpDown_Red.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown_Red.TabIndex = 10;
            this.numericUpDown_Red.ValueChanged += new System.EventHandler(this.numericUpDown_Red_ValueChanged);
            // 
            // numericUpDown_Green
            // 
            this.numericUpDown_Green.Location = new System.Drawing.Point(284, 95);
            this.numericUpDown_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Green.Name = "numericUpDown_Green";
            this.numericUpDown_Green.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown_Green.TabIndex = 11;
            this.numericUpDown_Green.ValueChanged += new System.EventHandler(this.numericUpDown_Green_ValueChanged);
            // 
            // numericUpDown_Blue
            // 
            this.numericUpDown_Blue.Location = new System.Drawing.Point(284, 140);
            this.numericUpDown_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Blue.Name = "numericUpDown_Blue";
            this.numericUpDown_Blue.Size = new System.Drawing.Size(53, 23);
            this.numericUpDown_Blue.TabIndex = 12;
            this.numericUpDown_Blue.ValueChanged += new System.EventHandler(this.numericUpDown_Blue_ValueChanged);
            // 
            // FormCouleurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 339);
            this.Controls.Add(this.numericUpDown_Blue);
            this.Controls.Add(this.numericUpDown_Green);
            this.Controls.Add(this.numericUpDown_Red);
            this.Controls.Add(this.hScrollBar_Blue);
            this.Controls.Add(this.hScrollBar_Green);
            this.Controls.Add(this.hScrollBar_Red);
            this.Controls.Add(this.panel_Blue);
            this.Controls.Add(this.panel_Green);
            this.Controls.Add(this.panel_Red);
            this.Controls.Add(this.panel_ColorResult);
            this.Controls.Add(this.label_Blue);
            this.Controls.Add(this.label_Green);
            this.Controls.Add(this.label_Red);
            this.Name = "FormCouleurs";
            this.Text = "FormCouleurs";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Red;
        private Label label_Green;
        private Label label_Blue;
        private Panel panel_ColorResult;
        private Panel panel_Red;
        private Panel panel_Green;
        private Panel panel_Blue;
        private HScrollBar hScrollBar_Red;
        private HScrollBar hScrollBar_Green;
        private HScrollBar hScrollBar_Blue;
        private NumericUpDown numericUpDown_Red;
        private NumericUpDown numericUpDown_Green;
        private NumericUpDown numericUpDown_Blue;
    }
}