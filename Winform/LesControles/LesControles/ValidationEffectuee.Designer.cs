namespace LesControles
{
    partial class ValidationEffectuee
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
            this.button1_ok = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_ok
            // 
            this.button1_ok.Location = new System.Drawing.Point(62, 120);
            this.button1_ok.Name = "button1_ok";
            this.button1_ok.Size = new System.Drawing.Size(75, 23);
            this.button1_ok.TabIndex = 0;
            this.button1_ok.Text = "OK";
            this.button1_ok.UseVisualStyleBackColor = true;
            this.button1_ok.Click += new System.EventHandler(this.button1_ok_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(36, 18);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 15);
            this.lblData.TabIndex = 1;
            // 
            // ValidationEffectuee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 155);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.button1_ok);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(216, 194);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(216, 194);
            this.Name = "ValidationEffectuee";
            this.Text = "Validation Effectuée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_ok;
        private Label lblData;
    }
}