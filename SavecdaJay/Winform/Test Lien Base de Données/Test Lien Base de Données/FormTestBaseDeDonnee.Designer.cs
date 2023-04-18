namespace TestLienBasedeDonnées
{
    partial class FormTestBaseDeDonnee
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
            buttonAddCities = new Button();
            buttonDeleteCitiesMethod1 = new Button();
            dataGridViewCities = new DataGridView();
            textBoxReasonToDelete = new TextBox();
            buttonEditCity = new Button();
            labelName = new Label();
            textBoxNameNewEdit = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).BeginInit();
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
            // buttonDeleteCitiesMethod1
            // 
            buttonDeleteCitiesMethod1.Location = new Point(466, 113);
            buttonDeleteCitiesMethod1.Name = "buttonDeleteCitiesMethod1";
            buttonDeleteCitiesMethod1.Size = new Size(181, 23);
            buttonDeleteCitiesMethod1.TabIndex = 1;
            buttonDeleteCitiesMethod1.Text = "Supprimer une Ville Methode 1";
            buttonDeleteCitiesMethod1.UseVisualStyleBackColor = true;
            buttonDeleteCitiesMethod1.Click += buttonDeleteCitiesMethod1_Click;
            // 
            // dataGridViewCities
            // 
            dataGridViewCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCities.Location = new Point(12, 12);
            dataGridViewCities.Name = "dataGridViewCities";
            dataGridViewCities.RowTemplate.Height = 25;
            dataGridViewCities.Size = new Size(448, 233);
            dataGridViewCities.TabIndex = 3;
            // 
            // textBoxReasonToDelete
            // 
            textBoxReasonToDelete.Location = new Point(728, 113);
            textBoxReasonToDelete.Name = "textBoxReasonToDelete";
            textBoxReasonToDelete.Size = new Size(51, 23);
            textBoxReasonToDelete.TabIndex = 4;
            // 
            // buttonEditCity
            // 
            buttonEditCity.Location = new Point(466, 222);
            buttonEditCity.Name = "buttonEditCity";
            buttonEditCity.Size = new Size(75, 23);
            buttonEditCity.TabIndex = 5;
            buttonEditCity.Text = "Modifier une Ville";
            buttonEditCity.UseVisualStyleBackColor = true;
            buttonEditCity.Click += buttonEditCity_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(622, 226);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 6;
            labelName.Text = "Nom";
            // 
            // textBoxNameNewEdit
            // 
            textBoxNameNewEdit.Location = new Point(662, 222);
            textBoxNameNewEdit.Name = "textBoxNameNewEdit";
            textBoxNameNewEdit.Size = new Size(117, 23);
            textBoxNameNewEdit.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(670, 117);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 8;
            label1.Text = "Select ID";
            // 
            // FormTestBaseDeDonnee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 291);
            Controls.Add(label1);
            Controls.Add(textBoxNameNewEdit);
            Controls.Add(labelName);
            Controls.Add(buttonEditCity);
            Controls.Add(textBoxReasonToDelete);
            Controls.Add(dataGridViewCities);
            Controls.Add(buttonDeleteCitiesMethod1);
            Controls.Add(buttonAddCities);
            MaximumSize = new Size(816, 330);
            MinimumSize = new Size(816, 330);
            Name = "FormTestBaseDeDonnee";
            Text = "FormTestBaseDeDonnee";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddCities;
        private Button buttonDeleteCitiesMethod1;
        private DataGridView dataGridViewCities;
        private TextBox textBoxReasonToDelete;
        private Button buttonEditCity;
        private Label labelName;
        private TextBox textBoxNameNewEdit;
        private Label label1;
    }
}