namespace Test_Lien_Base_de_Données
{
    partial class FormAjouterModifierCountry
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
            labelCountryCode = new Label();
            textBoxCountryCode = new TextBox();
            textBoxCountryName = new TextBox();
            label1CountryName = new Label();
            buttonValider = new Button();
            errorProviderCountryCode = new ErrorProvider(components);
            errorProviderCountryName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderCountryCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCountryName).BeginInit();
            SuspendLayout();
            // 
            // labelCountryCode
            // 
            labelCountryCode.AutoSize = true;
            labelCountryCode.Location = new Point(28, 53);
            labelCountryCode.Name = "labelCountryCode";
            labelCountryCode.Size = new Size(81, 15);
            labelCountryCode.TabIndex = 0;
            labelCountryCode.Text = "Code Country";
            // 
            // textBoxCountryCode
            // 
            textBoxCountryCode.Location = new Point(146, 45);
            textBoxCountryCode.Name = "textBoxCountryCode";
            textBoxCountryCode.Size = new Size(100, 23);
            textBoxCountryCode.TabIndex = 1;
            textBoxCountryCode.TextChanged += textBoxCountryCode_TextChanged;
            // 
            // textBoxCountryName
            // 
            textBoxCountryName.Location = new Point(146, 114);
            textBoxCountryName.Name = "textBoxCountryName";
            textBoxCountryName.Size = new Size(100, 23);
            textBoxCountryName.TabIndex = 2;
            textBoxCountryName.TextChanged += textBoxCountryName_TextChanged;
            // 
            // label1CountryName
            // 
            label1CountryName.AutoSize = true;
            label1CountryName.Location = new Point(24, 122);
            label1CountryName.Name = "label1CountryName";
            label1CountryName.Size = new Size(85, 15);
            label1CountryName.TabIndex = 3;
            label1CountryName.Text = "Country Name";
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(104, 169);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(75, 23);
            buttonValider.TabIndex = 4;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // errorProviderCountryCode
            // 
            errorProviderCountryCode.ContainerControl = this;
            // 
            // errorProviderCountryName
            // 
            errorProviderCountryName.ContainerControl = this;
            // 
            // FormAjouterModifierCountry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 204);
            Controls.Add(buttonValider);
            Controls.Add(label1CountryName);
            Controls.Add(textBoxCountryName);
            Controls.Add(textBoxCountryCode);
            Controls.Add(labelCountryCode);
            Name = "FormAjouterModifierCountry";
            Text = "FormAjouterModifierCountry";
            ((System.ComponentModel.ISupportInitialize)errorProviderCountryCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCountryName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCountryCode;
        private TextBox textBoxCountryCode;
        private TextBox textBoxCountryName;
        private Label label1CountryName;
        private Button buttonValider;
        private ErrorProvider errorProviderCountryCode;
        private ErrorProvider errorProviderCountryName;
    }
}