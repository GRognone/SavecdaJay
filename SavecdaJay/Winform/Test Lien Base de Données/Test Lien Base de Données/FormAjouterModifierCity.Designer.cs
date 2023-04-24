namespace Test_Lien_Base_de_Données
{
    partial class FormAjouterModifierCity
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
            labelIdCity = new Label();
            textBoxIdCity = new TextBox();
            labelCityName = new Label();
            textBoxCityName = new TextBox();
            labelCityCodeCountry = new Label();
            comboBoxCountryCode = new ComboBox();
            buttonSaveAllCity = new Button();
            errorProviderSetCityName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderSetCityName).BeginInit();
            SuspendLayout();
            // 
            // labelIdCity
            // 
            labelIdCity.AutoSize = true;
            labelIdCity.Location = new Point(39, 64);
            labelIdCity.Name = "labelIdCity";
            labelIdCity.Size = new Size(41, 15);
            labelIdCity.TabIndex = 0;
            labelIdCity.Text = "Id City";
            // 
            // textBoxIdCity
            // 
            textBoxIdCity.Location = new Point(129, 56);
            textBoxIdCity.Name = "textBoxIdCity";
            textBoxIdCity.Size = new Size(100, 23);
            textBoxIdCity.TabIndex = 1;
            // 
            // labelCityName
            // 
            labelCityName.AutoSize = true;
            labelCityName.Location = new Point(39, 122);
            labelCityName.Name = "labelCityName";
            labelCityName.Size = new Size(59, 15);
            labelCityName.TabIndex = 2;
            labelCityName.Text = "Nom Ville";
            // 
            // textBoxCityName
            // 
            textBoxCityName.Location = new Point(129, 119);
            textBoxCityName.Name = "textBoxCityName";
            textBoxCityName.Size = new Size(100, 23);
            textBoxCityName.TabIndex = 3;
            textBoxCityName.TextChanged += textBoxCityName_TextChanged;
            // 
            // labelCityCodeCountry
            // 
            labelCityCodeCountry.AutoSize = true;
            labelCityCodeCountry.Location = new Point(39, 182);
            labelCityCodeCountry.Name = "labelCityCodeCountry";
            labelCityCodeCountry.Size = new Size(62, 15);
            labelCityCodeCountry.TabIndex = 4;
            labelCityCodeCountry.Text = "Code Pays";
            // 
            // comboBoxCountryCode
            // 
            comboBoxCountryCode.FormattingEnabled = true;
            comboBoxCountryCode.Location = new Point(129, 174);
            comboBoxCountryCode.Name = "comboBoxCountryCode";
            comboBoxCountryCode.Size = new Size(100, 23);
            comboBoxCountryCode.TabIndex = 5;
            // 
            // buttonSaveAllCity
            // 
            buttonSaveAllCity.Location = new Point(109, 247);
            buttonSaveAllCity.Name = "buttonSaveAllCity";
            buttonSaveAllCity.Size = new Size(88, 23);
            buttonSaveAllCity.TabIndex = 6;
            buttonSaveAllCity.Text = "Valider";
            buttonSaveAllCity.UseVisualStyleBackColor = true;
            buttonSaveAllCity.Click += buttonSaveAllCity_Click;
            // 
            // errorProviderSetCityName
            // 
            errorProviderSetCityName.ContainerControl = this;
            // 
            // FormAjouterModifierCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 296);
            Controls.Add(buttonSaveAllCity);
            Controls.Add(comboBoxCountryCode);
            Controls.Add(labelCityCodeCountry);
            Controls.Add(textBoxCityName);
            Controls.Add(labelCityName);
            Controls.Add(textBoxIdCity);
            Controls.Add(labelIdCity);
            Name = "FormAjouterModifierCity";
            Text = "FormAjouterModifier";
            ((System.ComponentModel.ISupportInitialize)errorProviderSetCityName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdCity;
        private TextBox textBoxIdCity;
        private Label labelCityName;
        private TextBox textBoxCityName;
        private Label labelCityCodeCountry;
        private ComboBox comboBoxCountryCode;
        private Button buttonSaveAllCity;
        private ErrorProvider errorProviderSetCityName;
    }
}