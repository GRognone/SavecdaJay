namespace TestLienBasedeDonnées
{
    partial class FormCity
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
            buttonAddCities = new Button();
            buttonDeleteCities = new Button();
            dataGridViewCities = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            cityBindingSource = new BindingSource(components);
            buttonEditCity = new Button();
            buttonsupp = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonAddCities
            // 
            buttonAddCities.Location = new Point(466, 12);
            buttonAddCities.Name = "buttonAddCities";
            buttonAddCities.Size = new Size(111, 23);
            buttonAddCities.TabIndex = 0;
            buttonAddCities.Text = "Ajouter Une Ville";
            buttonAddCities.UseVisualStyleBackColor = true;
            buttonAddCities.Click += buttonAddCities_Click;
            // 
            // buttonDeleteCities
            // 
            buttonDeleteCities.Location = new Point(466, 79);
            buttonDeleteCities.Name = "buttonDeleteCities";
            buttonDeleteCities.Size = new Size(124, 23);
            buttonDeleteCities.TabIndex = 1;
            buttonDeleteCities.Text = "Supprimer une Ville";
            buttonDeleteCities.UseVisualStyleBackColor = true;
            buttonDeleteCities.Click += buttonDeleteCitiesClick;
            // 
            // dataGridViewCities
            // 
            dataGridViewCities.AutoGenerateColumns = false;
            dataGridViewCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCities.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCities.DataSource = cityBindingSource;
            dataGridViewCities.Location = new Point(12, 12);
            dataGridViewCities.Name = "dataGridViewCities";
            dataGridViewCities.RowTemplate.Height = 25;
            dataGridViewCities.Size = new Size(448, 233);
            dataGridViewCities.TabIndex = 3;
            dataGridViewCities.SelectionChanged += dataGridViewCities_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CityId";
            dataGridViewTextBoxColumn1.HeaderText = "CityId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CityName";
            dataGridViewTextBoxColumn2.HeaderText = "CityName";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CountryCode";
            dataGridViewTextBoxColumn3.HeaderText = "CountryCode";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "CountryCodeNavigation";
            dataGridViewTextBoxColumn4.HeaderText = "CountryCodeNavigation";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // cityBindingSource
            // 
            cityBindingSource.DataSource = typeof(Models.City);
            // 
            // buttonEditCity
            // 
            buttonEditCity.Location = new Point(466, 168);
            buttonEditCity.Name = "buttonEditCity";
            buttonEditCity.Size = new Size(75, 23);
            buttonEditCity.TabIndex = 5;
            buttonEditCity.Text = "Modifier une Ville";
            buttonEditCity.UseVisualStyleBackColor = true;
            buttonEditCity.Click += buttonEditCity_Click;
            // 
            // buttonsupp
            // 
            buttonsupp.Location = new Point(466, 117);
            buttonsupp.Name = "buttonsupp";
            buttonsupp.Size = new Size(137, 23);
            buttonsupp.TabIndex = 6;
            buttonsupp.Text = "Supprimer (alternative)";
            buttonsupp.UseVisualStyleBackColor = true;
            buttonsupp.Click += buttonsupp_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(609, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // FormCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 291);
            Controls.Add(comboBox1);
            Controls.Add(buttonsupp);
            Controls.Add(buttonEditCity);
            Controls.Add(dataGridViewCities);
            Controls.Add(buttonDeleteCities);
            Controls.Add(buttonAddCities);
            MaximumSize = new Size(816, 330);
            MinimumSize = new Size(816, 330);
            Name = "FormCity";
            Text = "FormCity";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddCities;
        private Button buttonDeleteCities;
        private DataGridView dataGridViewCities;
        private Button buttonEditCity;
        private Label labelName;
        private TextBox textBoxNameCityModify;
        private DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeNavigationDataGridViewTextBoxColumn;
        private TextBox textBoxCityNameAdd;
        private BindingSource cityBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button buttonsupp;
        private ComboBox comboBox1;
    }
}