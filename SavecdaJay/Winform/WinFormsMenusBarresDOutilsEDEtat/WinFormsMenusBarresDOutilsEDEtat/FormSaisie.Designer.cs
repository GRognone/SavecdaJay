namespace WinFormsMenusBarresDOutilsEDEtat
{
    partial class FormSaisieTextePhase3ChekBoxBtRadio
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
            textBoxSaisie = new TextBox();
            buttonValider = new Button();
            SuspendLayout();
            // 
            // textBoxSaisie
            // 
            textBoxSaisie.Location = new Point(19, 35);
            textBoxSaisie.Name = "textBoxSaisie";
            textBoxSaisie.Size = new Size(304, 23);
            textBoxSaisie.TabIndex = 0;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(355, 35);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 1;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // FormSaisieTextePhase3ChekBoxBtRadio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 68);
            Controls.Add(buttonValider);
            Controls.Add(textBoxSaisie);
            MaximumSize = new Size(476, 107);
            MinimumSize = new Size(476, 107);
            Name = "FormSaisieTextePhase3ChekBoxBtRadio";
            Text = "Saisie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSaisie;
        private Button buttonValider;
    }
}