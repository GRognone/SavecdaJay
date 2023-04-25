namespace Test_Lien_Base_de_Données
{
    partial class FormCountry
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
            dataGridViewCountry = new DataGridView();
            countryCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            citiesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryBindingSource = new BindingSource(components);
            buttonAddCountry = new Button();
            buttonDeleteCountry = new Button();
            buttonModifyCountry = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCountry
            // 
            dataGridViewCountry.AutoGenerateColumns = false;
            dataGridViewCountry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountry.Columns.AddRange(new DataGridViewColumn[] { countryCodeDataGridViewTextBoxColumn, countryNameDataGridViewTextBoxColumn, citiesDataGridViewTextBoxColumn });
            dataGridViewCountry.DataSource = countryBindingSource;
            dataGridViewCountry.Location = new Point(12, 12);
            dataGridViewCountry.Name = "dataGridViewCountry";
            dataGridViewCountry.ReadOnly = true;
            dataGridViewCountry.RowTemplate.Height = 25;
            dataGridViewCountry.Size = new Size(448, 233);
            dataGridViewCountry.TabIndex = 0;
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
            countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            countryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            countryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citiesDataGridViewTextBoxColumn
            // 
            citiesDataGridViewTextBoxColumn.DataPropertyName = "Cities";
            citiesDataGridViewTextBoxColumn.HeaderText = "Cities";
            citiesDataGridViewTextBoxColumn.Name = "citiesDataGridViewTextBoxColumn";
            citiesDataGridViewTextBoxColumn.ReadOnly = true;
            citiesDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryBindingSource
            // 
            countryBindingSource.DataSource = typeof(TestLienBasedeDonnées.Models.Country);
            // 
            // buttonAddCountry
            // 
            buttonAddCountry.Location = new Point(466, 12);
            buttonAddCountry.Name = "buttonAddCountry";
            buttonAddCountry.Size = new Size(111, 23);
            buttonAddCountry.TabIndex = 1;
            buttonAddCountry.Text = "Ajouter Un Pays";
            buttonAddCountry.UseVisualStyleBackColor = true;
            buttonAddCountry.Click += buttonAddCountry_Click;
            // 
            // buttonDeleteCountry
            // 
            buttonDeleteCountry.Location = new Point(466, 79);
            buttonDeleteCountry.Name = "buttonDeleteCountry";
            buttonDeleteCountry.Size = new Size(124, 23);
            buttonDeleteCountry.TabIndex = 2;
            buttonDeleteCountry.Text = "Supprimer Un Pays";
            buttonDeleteCountry.UseVisualStyleBackColor = true;
            buttonDeleteCountry.Click += buttonDeleteCountry_Click;
            // 
            // buttonModifyCountry
            // 
            buttonModifyCountry.Location = new Point(466, 143);
            buttonModifyCountry.Name = "buttonModifyCountry";
            buttonModifyCountry.Size = new Size(75, 23);
            buttonModifyCountry.TabIndex = 3;
            buttonModifyCountry.Text = "Modifier";
            buttonModifyCountry.UseVisualStyleBackColor = true;
            buttonModifyCountry.Click += buttonModifyCountry_Click;
            // 
            // FormCountry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 259);
            Controls.Add(buttonModifyCountry);
            Controls.Add(buttonDeleteCountry);
            Controls.Add(buttonAddCountry);
            Controls.Add(dataGridViewCountry);
            Name = "FormCountry";
            Text = "FormCountry";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCountry;
        private BindingSource countryBindingSource;
        private Button buttonAddCountry;
        private Button buttonDeleteCountry;
        private Button buttonModifyCountry;
        private DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn citiesDataGridViewTextBoxColumn;
    }
}