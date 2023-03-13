namespace LesControles2
{
    partial class ValidationsEffectuees
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
            this.label_nom_valide = new System.Windows.Forms.Label();
            this.label_date_valide = new System.Windows.Forms.Label();
            this.label_montant_valide = new System.Windows.Forms.Label();
            this.label_Cp_valide = new System.Windows.Forms.Label();
            this.button_ok_valide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nom_valide
            // 
            this.label_nom_valide.AutoSize = true;
            this.label_nom_valide.Location = new System.Drawing.Point(13, 20);
            this.label_nom_valide.Name = "label_nom_valide";
            this.label_nom_valide.Size = new System.Drawing.Size(34, 15);
            this.label_nom_valide.TabIndex = 0;
            this.label_nom_valide.Text = "Nom";
            // 
            // label_date_valide
            // 
            this.label_date_valide.AutoSize = true;
            this.label_date_valide.Location = new System.Drawing.Point(13, 49);
            this.label_date_valide.Name = "label_date_valide";
            this.label_date_valide.Size = new System.Drawing.Size(31, 15);
            this.label_date_valide.TabIndex = 1;
            this.label_date_valide.Text = "Date";
            // 
            // label_montant_valide
            // 
            this.label_montant_valide.AutoSize = true;
            this.label_montant_valide.Location = new System.Drawing.Point(13, 78);
            this.label_montant_valide.Name = "label_montant_valide";
            this.label_montant_valide.Size = new System.Drawing.Size(53, 15);
            this.label_montant_valide.TabIndex = 2;
            this.label_montant_valide.Text = "Montant";
            // 
            // label_Cp_valide
            // 
            this.label_Cp_valide.AutoSize = true;
            this.label_Cp_valide.Location = new System.Drawing.Point(13, 107);
            this.label_Cp_valide.Name = "label_Cp_valide";
            this.label_Cp_valide.Size = new System.Drawing.Size(70, 15);
            this.label_Cp_valide.TabIndex = 3;
            this.label_Cp_valide.Text = "Code Postal";
            // 
            // button_ok_valide
            // 
            this.button_ok_valide.Location = new System.Drawing.Point(186, 154);
            this.button_ok_valide.Name = "button_ok_valide";
            this.button_ok_valide.Size = new System.Drawing.Size(75, 23);
            this.button_ok_valide.TabIndex = 9;
            this.button_ok_valide.Text = "Ok";
            this.button_ok_valide.UseVisualStyleBackColor = true;
            this.button_ok_valide.Click += new System.EventHandler(this.button_ok_valide_Click);
            // 
            // ValidationsEffectuees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 189);
            this.Controls.Add(this.button_ok_valide);
            this.Controls.Add(this.label_Cp_valide);
            this.Controls.Add(this.label_montant_valide);
            this.Controls.Add(this.label_date_valide);
            this.Controls.Add(this.label_nom_valide);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(302, 228);
            this.MinimumSize = new System.Drawing.Size(302, 228);
            this.Name = "ValidationsEffectuees";
            this.Text = "ValidationsEffectuees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_nom_valide;
        private Label label_date_valide;
        private Label label_montant_valide;
        private Label label_Cp_valide;
        private Button button_ok_valide;
    }
}