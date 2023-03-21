namespace WinFormsDefilementAvecTrackBar
{
    partial class FormDefilementTrackBar
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
            this.label_red = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            this.trackBar_Red = new System.Windows.Forms.TrackBar();
            this.trackBar_Green = new System.Windows.Forms.TrackBar();
            this.trackBar_Blue = new System.Windows.Forms.TrackBar();
            this.panel_Red = new System.Windows.Forms.Panel();
            this.panel_Green = new System.Windows.Forms.Panel();
            this.panel_Blue = new System.Windows.Forms.Panel();
            this.panel_Result = new System.Windows.Forms.Panel();
            this.numericUpDown_Red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Blue = new System.Windows.Forms.NumericUpDown();
            this.hScrollBar_Red = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Green = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Blue = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Location = new System.Drawing.Point(40, 34);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(27, 15);
            this.label_red.TabIndex = 0;
            this.label_red.Text = "Red";
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Location = new System.Drawing.Point(40, 92);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(38, 15);
            this.label_green.TabIndex = 1;
            this.label_green.Text = "Green";
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.Location = new System.Drawing.Point(40, 147);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(30, 15);
            this.label_blue.TabIndex = 2;
            this.label_blue.Text = "Blue";
            // 
            // trackBar_Red
            // 
            this.trackBar_Red.LargeChange = 20;
            this.trackBar_Red.Location = new System.Drawing.Point(101, 23);
            this.trackBar_Red.Maximum = 255;
            this.trackBar_Red.Name = "trackBar_Red";
            this.trackBar_Red.Size = new System.Drawing.Size(187, 45);
            this.trackBar_Red.TabIndex = 3;
            this.trackBar_Red.Scroll += new System.EventHandler(this.trackBar_Red_Scroll);
            // 
            // trackBar_Green
            // 
            this.trackBar_Green.LargeChange = 20;
            this.trackBar_Green.Location = new System.Drawing.Point(101, 84);
            this.trackBar_Green.Maximum = 255;
            this.trackBar_Green.Name = "trackBar_Green";
            this.trackBar_Green.Size = new System.Drawing.Size(187, 45);
            this.trackBar_Green.TabIndex = 4;
            this.trackBar_Green.Scroll += new System.EventHandler(this.trackBar_Green_Scroll);
            // 
            // trackBar_Blue
            // 
            this.trackBar_Blue.LargeChange = 20;
            this.trackBar_Blue.Location = new System.Drawing.Point(101, 135);
            this.trackBar_Blue.Maximum = 255;
            this.trackBar_Blue.Name = "trackBar_Blue";
            this.trackBar_Blue.Size = new System.Drawing.Size(187, 45);
            this.trackBar_Blue.TabIndex = 5;
            this.trackBar_Blue.Scroll += new System.EventHandler(this.trackBar_Blue_Scroll);
            // 
            // panel_Red
            // 
            this.panel_Red.Location = new System.Drawing.Point(590, 29);
            this.panel_Red.Name = "panel_Red";
            this.panel_Red.Size = new System.Drawing.Size(73, 20);
            this.panel_Red.TabIndex = 6;
            // 
            // panel_Green
            // 
            this.panel_Green.Location = new System.Drawing.Point(590, 84);
            this.panel_Green.Name = "panel_Green";
            this.panel_Green.Size = new System.Drawing.Size(73, 23);
            this.panel_Green.TabIndex = 7;
            // 
            // panel_Blue
            // 
            this.panel_Blue.Location = new System.Drawing.Point(590, 147);
            this.panel_Blue.Name = "panel_Blue";
            this.panel_Blue.Size = new System.Drawing.Size(73, 25);
            this.panel_Blue.TabIndex = 8;
            // 
            // panel_Result
            // 
            this.panel_Result.Location = new System.Drawing.Point(40, 195);
            this.panel_Result.Name = "panel_Result";
            this.panel_Result.Size = new System.Drawing.Size(623, 100);
            this.panel_Result.TabIndex = 9;
            // 
            // numericUpDown_Red
            // 
            this.numericUpDown_Red.Location = new System.Drawing.Point(498, 26);
            this.numericUpDown_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Red.Name = "numericUpDown_Red";
            this.numericUpDown_Red.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_Red.TabIndex = 10;
            this.numericUpDown_Red.ValueChanged += new System.EventHandler(this.numericUpDown_Red_ValueChanged);
            // 
            // numericUpDown_Green
            // 
            this.numericUpDown_Green.Location = new System.Drawing.Point(498, 84);
            this.numericUpDown_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Green.Name = "numericUpDown_Green";
            this.numericUpDown_Green.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_Green.TabIndex = 11;
            this.numericUpDown_Green.ValueChanged += new System.EventHandler(this.numericUpDown_Green_ValueChanged);
            // 
            // numericUpDown_Blue
            // 
            this.numericUpDown_Blue.Location = new System.Drawing.Point(498, 149);
            this.numericUpDown_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Blue.Name = "numericUpDown_Blue";
            this.numericUpDown_Blue.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown_Blue.TabIndex = 12;
            this.numericUpDown_Blue.ValueChanged += new System.EventHandler(this.numericUpDown_Blue_ValueChanged);
            // 
            // hScrollBar_Red
            // 
            this.hScrollBar_Red.Location = new System.Drawing.Point(323, 26);
            this.hScrollBar_Red.Maximum = 264;
            this.hScrollBar_Red.Name = "hScrollBar_Red";
            this.hScrollBar_Red.Size = new System.Drawing.Size(153, 17);
            this.hScrollBar_Red.TabIndex = 13;
            this.hScrollBar_Red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Red_Scroll);
            // 
            // hScrollBar_Green
            // 
            this.hScrollBar_Green.Location = new System.Drawing.Point(323, 84);
            this.hScrollBar_Green.Maximum = 264;
            this.hScrollBar_Green.Name = "hScrollBar_Green";
            this.hScrollBar_Green.Size = new System.Drawing.Size(153, 17);
            this.hScrollBar_Green.TabIndex = 14;
            this.hScrollBar_Green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Green_Scroll);
            // 
            // hScrollBar_Blue
            // 
            this.hScrollBar_Blue.Location = new System.Drawing.Point(323, 149);
            this.hScrollBar_Blue.Maximum = 264;
            this.hScrollBar_Blue.Name = "hScrollBar_Blue";
            this.hScrollBar_Blue.Size = new System.Drawing.Size(153, 17);
            this.hScrollBar_Blue.TabIndex = 15;
            this.hScrollBar_Blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Blue_Scroll);
            // 
            // FormDefilementTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 336);
            this.Controls.Add(this.hScrollBar_Blue);
            this.Controls.Add(this.hScrollBar_Green);
            this.Controls.Add(this.hScrollBar_Red);
            this.Controls.Add(this.numericUpDown_Blue);
            this.Controls.Add(this.numericUpDown_Green);
            this.Controls.Add(this.numericUpDown_Red);
            this.Controls.Add(this.panel_Result);
            this.Controls.Add(this.panel_Blue);
            this.Controls.Add(this.panel_Green);
            this.Controls.Add(this.panel_Red);
            this.Controls.Add(this.trackBar_Blue);
            this.Controls.Add(this.trackBar_Green);
            this.Controls.Add(this.trackBar_Red);
            this.Controls.Add(this.label_blue);
            this.Controls.Add(this.label_green);
            this.Controls.Add(this.label_red);
            this.Name = "FormDefilementTrackBar";
            this.Text = "FormDefilementTrackBar";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_red;
        private Label label_green;
        private Label label_blue;
        private TrackBar trackBar_Red;
        private TrackBar trackBar_Green;
        private TrackBar trackBar_Blue;
        private Panel panel_Red;
        private Panel panel_Green;
        private Panel panel_Blue;
        private Panel panel_Result;
        private NumericUpDown numericUpDown_Red;
        private NumericUpDown numericUpDown_Green;
        private NumericUpDown numericUpDown_Blue;
        private HScrollBar hScrollBar_Red;
        private HScrollBar hScrollBar_Green;
        private HScrollBar hScrollBar_Blue;
    }
}