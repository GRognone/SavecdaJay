namespace LesControles
{
    partial class FormulaireDeSaisie
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
            this.button1_valider = new System.Windows.Forms.Button();
            this.button2_effacer = new System.Windows.Forms.Button();
            this.textBox1_nom = new System.Windows.Forms.TextBox();
            this.textBox2_date = new System.Windows.Forms.TextBox();
            this.textBox3_montant = new System.Windows.Forms.TextBox();
            this.textBox4_code_postal = new System.Windows.Forms.TextBox();
            this.label1_nom = new System.Windows.Forms.Label();
            this.label2_date = new System.Windows.Forms.Label();
            this.label3_montant = new System.Windows.Forms.Label();
            this.label4_code_postal = new System.Windows.Forms.Label();
            this.label5_date_txt = new System.Windows.Forms.Label();
            this.errorProvider1_nom = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1_nom)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_valider
            // 
            this.button1_valider.Location = new System.Drawing.Point(265, 208);
            this.button1_valider.Name = "button1_valider";
            this.button1_valider.Size = new System.Drawing.Size(75, 23);
            this.button1_valider.TabIndex = 0;
            this.button1_valider.Text = "Valider";
            this.button1_valider.UseVisualStyleBackColor = true;
            this.button1_valider.Click += new System.EventHandler(this.button1_valider_Click);
            // 
            // button2_effacer
            // 
            this.button2_effacer.Location = new System.Drawing.Point(265, 250);
            this.button2_effacer.Name = "button2_effacer";
            this.button2_effacer.Size = new System.Drawing.Size(75, 23);
            this.button2_effacer.TabIndex = 1;
            this.button2_effacer.Text = "Effacer";
            this.button2_effacer.UseVisualStyleBackColor = true;
            this.button2_effacer.Click += new System.EventHandler(this.button2_effacer_Click);
            // 
            // textBox1_nom
            // 
            this.textBox1_nom.Location = new System.Drawing.Point(111, 62);
            this.textBox1_nom.Name = "textBox1_nom";
            this.textBox1_nom.Size = new System.Drawing.Size(152, 23);
            this.textBox1_nom.TabIndex = 2;
            this.textBox1_nom.TextChanged += new System.EventHandler(this.textBox1_nom_TextChanged);
            this.textBox1_nom.Leave += new System.EventHandler(this.textBox1_nom_Leave);
            // 
            // textBox2_date
            // 
            this.textBox2_date.Location = new System.Drawing.Point(111, 110);
            this.textBox2_date.Name = "textBox2_date";
            this.textBox2_date.Size = new System.Drawing.Size(100, 23);
            this.textBox2_date.TabIndex = 3;
            // 
            // textBox3_montant
            // 
            this.textBox3_montant.Location = new System.Drawing.Point(111, 155);
            this.textBox3_montant.Name = "textBox3_montant";
            this.textBox3_montant.Size = new System.Drawing.Size(100, 23);
            this.textBox3_montant.TabIndex = 4;
            // 
            // textBox4_code_postal
            // 
            this.textBox4_code_postal.Location = new System.Drawing.Point(111, 200);
            this.textBox4_code_postal.Name = "textBox4_code_postal";
            this.textBox4_code_postal.Size = new System.Drawing.Size(100, 23);
            this.textBox4_code_postal.TabIndex = 5;
            // 
            // label1_nom
            // 
            this.label1_nom.AutoSize = true;
            this.label1_nom.Location = new System.Drawing.Point(9, 70);
            this.label1_nom.Name = "label1_nom";
            this.label1_nom.Size = new System.Drawing.Size(34, 15);
            this.label1_nom.TabIndex = 6;
            this.label1_nom.Text = "Nom";
            // 
            // label2_date
            // 
            this.label2_date.AutoSize = true;
            this.label2_date.Location = new System.Drawing.Point(12, 118);
            this.label2_date.Name = "label2_date";
            this.label2_date.Size = new System.Drawing.Size(31, 15);
            this.label2_date.TabIndex = 7;
            this.label2_date.Text = "Date";
            // 
            // label3_montant
            // 
            this.label3_montant.AutoSize = true;
            this.label3_montant.Location = new System.Drawing.Point(12, 163);
            this.label3_montant.Name = "label3_montant";
            this.label3_montant.Size = new System.Drawing.Size(53, 15);
            this.label3_montant.TabIndex = 8;
            this.label3_montant.Text = "Montant";
            // 
            // label4_code_postal
            // 
            this.label4_code_postal.AutoSize = true;
            this.label4_code_postal.Location = new System.Drawing.Point(12, 208);
            this.label4_code_postal.Name = "label4_code_postal";
            this.label4_code_postal.Size = new System.Drawing.Size(70, 15);
            this.label4_code_postal.TabIndex = 9;
            this.label4_code_postal.Text = "Code Postal";
            // 
            // label5_date_txt
            // 
            this.label5_date_txt.AutoSize = true;
            this.label5_date_txt.Location = new System.Drawing.Point(225, 118);
            this.label5_date_txt.Name = "label5_date_txt";
            this.label5_date_txt.Size = new System.Drawing.Size(79, 15);
            this.label5_date_txt.TabIndex = 10;
            this.label5_date_txt.Text = "(JJ/MM/AAA)";
            // 
            // errorProvider1_nom
            // 
            this.errorProvider1_nom.ContainerControl = this;
            // 
            // FormulaireDeSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 297);
            this.Controls.Add(this.label5_date_txt);
            this.Controls.Add(this.label4_code_postal);
            this.Controls.Add(this.label3_montant);
            this.Controls.Add(this.label2_date);
            this.Controls.Add(this.label1_nom);
            this.Controls.Add(this.textBox4_code_postal);
            this.Controls.Add(this.textBox3_montant);
            this.Controls.Add(this.textBox2_date);
            this.Controls.Add(this.textBox1_nom);
            this.Controls.Add(this.button2_effacer);
            this.Controls.Add(this.button1_valider);
            this.MaximumSize = new System.Drawing.Size(392, 336);
            this.MinimumSize = new System.Drawing.Size(392, 336);
            this.Name = "FormulaireDeSaisie";
            this.Text = "FormulaireDeSaisie";
       
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1_nom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1_valider;
        private Button button2_effacer;
        private TextBox textBox1_nom;
        private TextBox textBox2_date;
        private TextBox textBox3_montant;
        private TextBox textBox4_code_postal;
        private Label label1_nom;
        private Label label2_date;
        private Label label3_montant;
        private Label label4_code_postal;
        private Label label5_date_txt;
        private ErrorProvider errorProvider1_nom;
    }
}