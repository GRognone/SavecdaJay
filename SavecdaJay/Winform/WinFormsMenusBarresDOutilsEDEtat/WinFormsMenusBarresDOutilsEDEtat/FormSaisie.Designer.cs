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
            textBoxSaisie.Location = new Point(33, 70);
            textBoxSaisie.Margin = new Padding(5, 6, 5, 6);
            textBoxSaisie.Name = "textBoxSaisie";
            textBoxSaisie.Size = new Size(518, 35);
            textBoxSaisie.TabIndex = 0;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(609, 70);
            buttonValider.Margin = new Padding(5, 6, 5, 6);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(129, 46);
            buttonValider.TabIndex = 1;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // FormSaisieTextePhase3ChekBoxBtRadio
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 112);
            Controls.Add(buttonValider);
            Controls.Add(textBoxSaisie);
            Margin = new Padding(5, 6, 5, 6);
            MaximumSize = new Size(804, 176);
            MinimumSize = new Size(804, 176);
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