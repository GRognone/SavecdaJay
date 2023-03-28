namespace WinFormsDefilements
{
    partial class FormLesComposantDeDefilement
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
            this.label_Rouge = new System.Windows.Forms.Label();
            this.label_Vert = new System.Windows.Forms.Label();
            this.label_Bleu = new System.Windows.Forms.Label();
            this.hScrollBar_Red = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Green = new System.Windows.Forms.HScrollBar();
            this.hScrollBar_Blue = new System.Windows.Forms.HScrollBar();
            this.numericUpDown_Red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Blue = new System.Windows.Forms.NumericUpDown();
            this.panel_colorResult = new System.Windows.Forms.Panel();
            this.panel_blue = new System.Windows.Forms.Panel();
            this.panel_green = new System.Windows.Forms.Panel();
            this.panel_red = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Rouge
            // 
            this.label_Rouge.AutoSize = true;
            this.label_Rouge.Location = new System.Drawing.Point(19, 50);
            this.label_Rouge.Name = "label_Rouge";
            this.label_Rouge.Size = new System.Drawing.Size(41, 15);
            this.label_Rouge.TabIndex = 0;
            this.label_Rouge.Text = "Rouge";
            // 
            // label_Vert
            // 
            this.label_Vert.AutoSize = true;
            this.label_Vert.Location = new System.Drawing.Point(19, 90);
            this.label_Vert.Name = "label_Vert";
            this.label_Vert.Size = new System.Drawing.Size(27, 15);
            this.label_Vert.TabIndex = 1;
            this.label_Vert.Text = "Vert";
            // 
            // label_Bleu
            // 
            this.label_Bleu.AutoSize = true;
            this.label_Bleu.Location = new System.Drawing.Point(19, 130);
            this.label_Bleu.Name = "label_Bleu";
            this.label_Bleu.Size = new System.Drawing.Size(30, 15);
            this.label_Bleu.TabIndex = 2;
            this.label_Bleu.Text = "Bleu";
            // 
            // hScrollBar_Red
            // 
            this.hScrollBar_Red.Location = new System.Drawing.Point(96, 48);
            this.hScrollBar_Red.Maximum = 264;
            this.hScrollBar_Red.Name = "hScrollBar_Red";
            this.hScrollBar_Red.Size = new System.Drawing.Size(251, 17);
            this.hScrollBar_Red.TabIndex = 3;
            this.hScrollBar_Red.ValueChanged += new System.EventHandler(this.hScrollBar_Red_ValueChanged);
            // 
            // hScrollBar_Green
            // 
            this.hScrollBar_Green.Location = new System.Drawing.Point(96, 88);
            this.hScrollBar_Green.Maximum = 264;
            this.hScrollBar_Green.Name = "hScrollBar_Green";
            this.hScrollBar_Green.Size = new System.Drawing.Size(251, 17);
            this.hScrollBar_Green.TabIndex = 4;
            this.hScrollBar_Green.ValueChanged += new System.EventHandler(this.hScrollBar_Green_ValueChanged);
            // 
            // hScrollBar_Blue
            // 
            this.hScrollBar_Blue.Location = new System.Drawing.Point(96, 128);
            this.hScrollBar_Blue.Maximum = 264;
            this.hScrollBar_Blue.Name = "hScrollBar_Blue";
            this.hScrollBar_Blue.Size = new System.Drawing.Size(251, 17);
            this.hScrollBar_Blue.TabIndex = 5;
            this.hScrollBar_Blue.ValueChanged += new System.EventHandler(this.hScrollBar_Blue_ValueChanged);
            // 
            // numericUpDown_Red
            // 
            this.numericUpDown_Red.Location = new System.Drawing.Point(369, 42);
            this.numericUpDown_Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Red.Name = "numericUpDown_Red";
            this.numericUpDown_Red.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown_Red.TabIndex = 6;
            this.numericUpDown_Red.ValueChanged += new System.EventHandler(this.numericUpDown_Red_ValueChanged);
            // 
            // numericUpDown_Green
            // 
            this.numericUpDown_Green.Location = new System.Drawing.Point(369, 82);
            this.numericUpDown_Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Green.Name = "numericUpDown_Green";
            this.numericUpDown_Green.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown_Green.TabIndex = 7;
            this.numericUpDown_Green.ValueChanged += new System.EventHandler(this.numericUpDown_Green_ValueChanged);
            // 
            // numericUpDown_Blue
            // 
            this.numericUpDown_Blue.Location = new System.Drawing.Point(369, 122);
            this.numericUpDown_Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_Blue.Name = "numericUpDown_Blue";
            this.numericUpDown_Blue.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown_Blue.TabIndex = 8;
            this.numericUpDown_Blue.ValueChanged += new System.EventHandler(this.numericUpDown_Blue_ValueChanged);
            // 
            // panel_colorResult
            // 
            this.panel_colorResult.Location = new System.Drawing.Point(19, 162);
            this.panel_colorResult.Name = "panel_colorResult";
            this.panel_colorResult.Size = new System.Drawing.Size(479, 78);
            this.panel_colorResult.TabIndex = 12;
            // 
            // panel_blue
            // 
            this.panel_blue.Location = new System.Drawing.Point(441, 122);
            this.panel_blue.Name = "panel_blue";
            this.panel_blue.Size = new System.Drawing.Size(57, 23);
            this.panel_blue.TabIndex = 11;
            // 
            // panel_green
            // 
            this.panel_green.Location = new System.Drawing.Point(441, 82);
            this.panel_green.Name = "panel_green";
            this.panel_green.Size = new System.Drawing.Size(57, 23);
            this.panel_green.TabIndex = 10;
            // 
            // panel_red
            // 
            this.panel_red.Location = new System.Drawing.Point(441, 42);
            this.panel_red.Name = "panel_red";
            this.panel_red.Size = new System.Drawing.Size(57, 23);
            this.panel_red.TabIndex = 9;
            // 
            // FormLesComposantDeDefilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 255);
            this.Controls.Add(this.panel_colorResult);
            this.Controls.Add(this.panel_blue);
            this.Controls.Add(this.panel_green);
            this.Controls.Add(this.panel_red);
            this.Controls.Add(this.numericUpDown_Blue);
            this.Controls.Add(this.numericUpDown_Green);
            this.Controls.Add(this.numericUpDown_Red);
            this.Controls.Add(this.hScrollBar_Blue);
            this.Controls.Add(this.hScrollBar_Green);
            this.Controls.Add(this.hScrollBar_Red);
            this.Controls.Add(this.label_Bleu);
            this.Controls.Add(this.label_Vert);
            this.Controls.Add(this.label_Rouge);
            this.MaximumSize = new System.Drawing.Size(538, 294);
            this.MinimumSize = new System.Drawing.Size(538, 294);
            this.Name = "FormLesComposantDeDefilement";
            this.Text = "FormLesComposantDeDefilement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Rouge;
        private Label label_Vert;
        private Label label_Bleu;
        private HScrollBar hScrollBar_Red;
        private HScrollBar hScrollBar_Green;
        private HScrollBar hScrollBar_Blue;
        private NumericUpDown numericUpDown_Red;
        private NumericUpDown numericUpDown_Green;
        private NumericUpDown numericUpDown_Blue;
        private Panel panel_colorResult;
        private Panel panel_blue;
        private Panel panel_green;
        private Panel panel_red;
    }
}