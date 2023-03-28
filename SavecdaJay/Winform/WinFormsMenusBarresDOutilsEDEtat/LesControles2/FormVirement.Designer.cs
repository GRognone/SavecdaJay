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
            this.components = new System.ComponentModel.Container();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_montant = new System.Windows.Forms.Label();
            this.label_CodePostal = new System.Windows.Forms.Label();
            this.label_jj_mm_aaaa = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_effacer = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_montant = new System.Windows.Forms.TextBox();
            this.textBox_CP = new System.Windows.Forms.TextBox();
            this.errorProvider_date = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_montant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_cp = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_nom = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_montant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_cp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nom)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(45, 49);
            this.label_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(34, 15);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Nom";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(45, 80);
            this.label_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(31, 15);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date";
            // 
            // label_montant
            // 
            this.label_montant.AutoSize = true;
            this.label_montant.Location = new System.Drawing.Point(45, 108);
            this.label_montant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_montant.Name = "label_montant";
            this.label_montant.Size = new System.Drawing.Size(53, 15);
            this.label_montant.TabIndex = 2;
            this.label_montant.Text = "Montant";
            // 
            // label_CodePostal
            // 
            this.label_CodePostal.AutoSize = true;
            this.label_CodePostal.Location = new System.Drawing.Point(45, 139);
            this.label_CodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CodePostal.Name = "label_CodePostal";
            this.label_CodePostal.Size = new System.Drawing.Size(70, 15);
            this.label_CodePostal.TabIndex = 3;
            this.label_CodePostal.Text = "Code Postal";
            // 
            // label_jj_mm_aaaa
            // 
            this.label_jj_mm_aaaa.AutoSize = true;
            this.label_jj_mm_aaaa.Location = new System.Drawing.Point(248, 80);
            this.label_jj_mm_aaaa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_jj_mm_aaaa.Name = "label_jj_mm_aaaa";
            this.label_jj_mm_aaaa.Size = new System.Drawing.Size(87, 15);
            this.label_jj_mm_aaaa.TabIndex = 4;
            this.label_jj_mm_aaaa.Text = "(JJ/MM/AAAA)";
            // 
            // button_valider
            // 
            this.button_valider.Location = new System.Drawing.Point(281, 134);
            this.button_valider.Margin = new System.Windows.Forms.Padding(2);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(74, 20);
            this.button_valider.TabIndex = 5;
            this.button_valider.Text = "Valider";
            this.button_valider.UseVisualStyleBackColor = true;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_effacer
            // 
            this.button_effacer.Location = new System.Drawing.Point(281, 157);
            this.button_effacer.Margin = new System.Windows.Forms.Padding(2);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(74, 22);
            this.button_effacer.TabIndex = 6;
            this.button_effacer.Text = "Effacer";
            this.button_effacer.UseVisualStyleBackColor = true;
            this.button_effacer.Click += new System.EventHandler(this.button_effacer_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(123, 45);
            this.textBox_nom.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(181, 23);
            this.textBox_nom.TabIndex = 7;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(123, 76);
            this.textBox_date.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(106, 23);
            this.textBox_date.TabIndex = 8;
            this.textBox_date.TextChanged += new System.EventHandler(this.textBox_date_TextChanged);
            // 
            // textBox_montant
            // 
            this.textBox_montant.Location = new System.Drawing.Point(123, 104);
            this.textBox_montant.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_montant.Name = "textBox_montant";
            this.textBox_montant.Size = new System.Drawing.Size(106, 23);
            this.textBox_montant.TabIndex = 9;
            this.textBox_montant.TextChanged += new System.EventHandler(this.textBox_montant_TextChanged);
            // 
            // textBox_CP
            // 
            this.textBox_CP.Location = new System.Drawing.Point(123, 135);
            this.textBox_CP.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_CP.Name = "textBox_CP";
            this.textBox_CP.Size = new System.Drawing.Size(80, 23);
            this.textBox_CP.TabIndex = 10;
            this.textBox_CP.TextChanged += new System.EventHandler(this.textBox_CP_TextChanged);
            // 
            // errorProvider_date
            // 
            this.errorProvider_date.ContainerControl = this;
            // 
            // errorProvider_montant
            // 
            this.errorProvider_montant.ContainerControl = this;
            // 
            // errorProvider_cp
            // 
            this.errorProvider_cp.ContainerControl = this;
            // 
            // errorProvider_nom
            // 
            this.errorProvider_nom.ContainerControl = this;
            // 
            // FormVirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 229);
            this.Controls.Add(this.textBox_CP);
            this.Controls.Add(this.textBox_montant);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.button_effacer);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.label_jj_mm_aaaa);
            this.Controls.Add(this.label_CodePostal);
            this.Controls.Add(this.label_montant);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_nom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(427, 268);
            this.MinimumSize = new System.Drawing.Size(427, 268);
            this.Name = "FormVirement";
            this.Text = "FormulaireVirement";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_montant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_cp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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