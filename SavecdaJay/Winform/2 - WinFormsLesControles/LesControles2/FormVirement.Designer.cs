namespace LesControles2
{
    partial class FormVirement
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
            label_nom = new Label();
            label_date = new Label();
            label_montant = new Label();
            label_CodePostal = new Label();
            label_jj_mm_aaaa = new Label();
            button_valider = new Button();
            button_effacer = new Button();
            textBox_nom = new TextBox();
            textBox_date = new TextBox();
            textBox_montant = new TextBox();
            textBox_CP = new TextBox();
            errorProvider_date = new ErrorProvider(components);
            errorProvider_montant = new ErrorProvider(components);
            errorProvider_cp = new ErrorProvider(components);
            errorProvider_nom = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider_date).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_montant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_cp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nom).BeginInit();
            SuspendLayout();
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.Location = new Point(45, 49);
            label_nom.Margin = new Padding(2, 0, 2, 0);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(34, 15);
            label_nom.TabIndex = 0;
            label_nom.Text = "Nom";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Location = new Point(45, 80);
            label_date.Margin = new Padding(2, 0, 2, 0);
            label_date.Name = "label_date";
            label_date.Size = new Size(31, 15);
            label_date.TabIndex = 1;
            label_date.Text = "Date";
            // 
            // label_montant
            // 
            label_montant.AutoSize = true;
            label_montant.Location = new Point(45, 108);
            label_montant.Margin = new Padding(2, 0, 2, 0);
            label_montant.Name = "label_montant";
            label_montant.Size = new Size(53, 15);
            label_montant.TabIndex = 2;
            label_montant.Text = "Montant";
            // 
            // label_CodePostal
            // 
            label_CodePostal.AutoSize = true;
            label_CodePostal.Location = new Point(45, 139);
            label_CodePostal.Margin = new Padding(2, 0, 2, 0);
            label_CodePostal.Name = "label_CodePostal";
            label_CodePostal.Size = new Size(70, 15);
            label_CodePostal.TabIndex = 3;
            label_CodePostal.Text = "Code Postal";
            // 
            // label_jj_mm_aaaa
            // 
            label_jj_mm_aaaa.AutoSize = true;
            label_jj_mm_aaaa.Location = new Point(248, 80);
            label_jj_mm_aaaa.Margin = new Padding(2, 0, 2, 0);
            label_jj_mm_aaaa.Name = "label_jj_mm_aaaa";
            label_jj_mm_aaaa.Size = new Size(87, 15);
            label_jj_mm_aaaa.TabIndex = 4;
            label_jj_mm_aaaa.Text = "(JJ/MM/AAAA)";
            // 
            // button_valider
            // 
            button_valider.Location = new Point(281, 134);
            button_valider.Margin = new Padding(2);
            button_valider.Name = "button_valider";
            button_valider.Size = new Size(74, 20);
            button_valider.TabIndex = 5;
            button_valider.Text = "Valider";
            button_valider.UseVisualStyleBackColor = true;
            button_valider.Click += button_valider_Click;
            // 
            // button_effacer
            // 
            button_effacer.Location = new Point(281, 157);
            button_effacer.Margin = new Padding(2);
            button_effacer.Name = "button_effacer";
            button_effacer.Size = new Size(74, 22);
            button_effacer.TabIndex = 6;
            button_effacer.Text = "Effacer";
            button_effacer.UseVisualStyleBackColor = true;
            button_effacer.Click += button_effacer_Click;
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(123, 45);
            textBox_nom.Margin = new Padding(2);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(181, 23);
            textBox_nom.TabIndex = 7;
            textBox_nom.TextChanged += textBox_nom_TextChanged;
            // 
            // textBox_date
            // 
            textBox_date.Location = new Point(123, 76);
            textBox_date.Margin = new Padding(2);
            textBox_date.Name = "textBox_date";
            textBox_date.Size = new Size(106, 23);
            textBox_date.TabIndex = 8;
            textBox_date.TextChanged += textBox_date_TextChanged;
            // 
            // textBox_montant
            // 
            textBox_montant.Location = new Point(123, 104);
            textBox_montant.Margin = new Padding(2);
            textBox_montant.Name = "textBox_montant";
            textBox_montant.Size = new Size(106, 23);
            textBox_montant.TabIndex = 9;
            textBox_montant.TextChanged += textBox_montant_TextChanged;
            // 
            // textBox_CP
            // 
            textBox_CP.Location = new Point(123, 135);
            textBox_CP.Margin = new Padding(2);
            textBox_CP.Name = "textBox_CP";
            textBox_CP.Size = new Size(80, 23);
            textBox_CP.TabIndex = 10;
            textBox_CP.TextChanged += textBox_CP_TextChanged;
            // 
            // errorProvider_date
            // 
            errorProvider_date.ContainerControl = this;
            // 
            // errorProvider_montant
            // 
            errorProvider_montant.ContainerControl = this;
            // 
            // errorProvider_cp
            // 
            errorProvider_cp.ContainerControl = this;
            // 
            // errorProvider_nom
            // 
            errorProvider_nom.ContainerControl = this;
            // 
            // FormVirement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 229);
            Controls.Add(textBox_CP);
            Controls.Add(textBox_montant);
            Controls.Add(textBox_date);
            Controls.Add(textBox_nom);
            Controls.Add(button_effacer);
            Controls.Add(button_valider);
            Controls.Add(label_jj_mm_aaaa);
            Controls.Add(label_CodePostal);
            Controls.Add(label_montant);
            Controls.Add(label_date);
            Controls.Add(label_nom);
            Margin = new Padding(2);
            MaximumSize = new Size(427, 268);
            MinimumSize = new Size(427, 268);
            Name = "FormVirement";
            Text = "FormulaireVirement";
            FormClosing += FormVirement_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider_date).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_montant).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_cp).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nom;
        private Label label_date;
        private Label label_montant;
        private Label label_CodePostal;
        private Label label_jj_mm_aaaa;
        private Button button_valider;
        private Button button_effacer;
        private TextBox textBox_nom;
        private TextBox textBox_date;
        private TextBox textBox_montant;
        private TextBox textBox_CP;
        private ErrorProvider errorProvider_date;
        private ErrorProvider errorProvider_montant;
        private ErrorProvider errorProvider_cp;
        private ErrorProvider errorProvider_nom;
    }
}