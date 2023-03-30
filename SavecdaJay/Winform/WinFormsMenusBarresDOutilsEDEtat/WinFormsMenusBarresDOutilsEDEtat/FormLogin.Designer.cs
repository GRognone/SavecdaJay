namespace WinFormsMenusBarresDOutilsEDEtat
{
    partial class FormLogin
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
            components = new System.ComponentModel.Container();
            textBoxLogin = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonAnnuler = new Button();
            buttonOk = new Button();
            errorProviderSaisieIncorrecte = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderSaisieIncorrecte).BeginInit();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(107, 40);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(198, 23);
            textBoxLogin.TabIndex = 0;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(28, 48);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(30, 92);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(107, 84);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(198, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(334, 84);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(82, 23);
            buttonAnnuler.TabIndex = 4;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(334, 113);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(82, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // errorProviderSaisieIncorrecte
            // 
            errorProviderSaisieIncorrecte.ContainerControl = this;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 158);
            Controls.Add(buttonOk);
            Controls.Add(buttonAnnuler);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            MaximumSize = new Size(458, 197);
            MinimumSize = new Size(458, 197);
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)errorProviderSaisieIncorrecte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonAnnuler;
        private Button buttonOk;
        private ErrorProvider errorProviderSaisieIncorrecte;
    }
}