namespace LesControles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1_nom = new System.Windows.Forms.TextBox();
            this.textBox3_montant = new System.Windows.Forms.TextBox();
            this.textBox4_code_postal = new System.Windows.Forms.TextBox();
            this.label1_nom = new System.Windows.Forms.Label();
            this.label2_date = new System.Windows.Forms.Label();
            this.label3_montant = new System.Windows.Forms.Label();
            this.label4_code_postal = new System.Windows.Forms.Label();
            this.label5_j_m_a = new System.Windows.Forms.Label();
            this.button1_valider = new System.Windows.Forms.Button();
            this.button2_effacer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1_nom
            // 
            this.textBox1_nom.Location = new System.Drawing.Point(103, 52);
            this.textBox1_nom.Name = "textBox1_nom";
            this.textBox1_nom.Size = new System.Drawing.Size(199, 23);
            this.textBox1_nom.TabIndex = 0;
            // 
            // textBox3_montant
            // 
            this.textBox3_montant.Location = new System.Drawing.Point(103, 111);
            this.textBox3_montant.Name = "textBox3_montant";
            this.textBox3_montant.Size = new System.Drawing.Size(77, 23);
            this.textBox3_montant.TabIndex = 2;
            // 
            // textBox4_code_postal
            // 
            this.textBox4_code_postal.Location = new System.Drawing.Point(103, 140);
            this.textBox4_code_postal.Name = "textBox4_code_postal";
            this.textBox4_code_postal.Size = new System.Drawing.Size(77, 23);
            this.textBox4_code_postal.TabIndex = 3;
            // 
            // label1_nom
            // 
            this.label1_nom.AutoSize = true;
            this.label1_nom.Location = new System.Drawing.Point(19, 56);
            this.label1_nom.Name = "label1_nom";
            this.label1_nom.Size = new System.Drawing.Size(34, 15);
            this.label1_nom.TabIndex = 4;
            this.label1_nom.Text = "Nom";
            // 
            // label2_date
            // 
            this.label2_date.AutoSize = true;
            this.label2_date.Location = new System.Drawing.Point(19, 85);
            this.label2_date.Name = "label2_date";
            this.label2_date.Size = new System.Drawing.Size(31, 15);
            this.label2_date.TabIndex = 5;
            this.label2_date.Text = "Date";
            // 
            // label3_montant
            // 
            this.label3_montant.AutoSize = true;
            this.label3_montant.Location = new System.Drawing.Point(19, 114);
            this.label3_montant.Name = "label3_montant";
            this.label3_montant.Size = new System.Drawing.Size(53, 15);
            this.label3_montant.TabIndex = 6;
            this.label3_montant.Text = "Montant";
            // 
            // label4_code_postal
            // 
            this.label4_code_postal.AutoSize = true;
            this.label4_code_postal.Location = new System.Drawing.Point(19, 143);
            this.label4_code_postal.Name = "label4_code_postal";
            this.label4_code_postal.Size = new System.Drawing.Size(70, 15);
            this.label4_code_postal.TabIndex = 7;
            this.label4_code_postal.Text = "Code Postal";
            // 
            // label5_j_m_a
            // 
            this.label5_j_m_a.AutoSize = true;
            this.label5_j_m_a.Location = new System.Drawing.Point(207, 85);
            this.label5_j_m_a.Name = "label5_j_m_a";
            this.label5_j_m_a.Size = new System.Drawing.Size(79, 15);
            this.label5_j_m_a.TabIndex = 8;
            this.label5_j_m_a.Text = "(JJ/MM/AAA)";
            // 
            // button1_valider
            // 
            this.button1_valider.Location = new System.Drawing.Point(207, 138);
            this.button1_valider.Name = "button1_valider";
            this.button1_valider.Size = new System.Drawing.Size(52, 25);
            this.button1_valider.TabIndex = 9;
            this.button1_valider.Text = "Valider";
            this.button1_valider.UseVisualStyleBackColor = true;
            this.button1_valider.Click += new System.EventHandler(this.button1_valider_Click);
            // 
            // button2_effacer
            // 
            this.button2_effacer.Location = new System.Drawing.Point(207, 169);
            this.button2_effacer.Name = "button2_effacer";
            this.button2_effacer.Size = new System.Drawing.Size(52, 25);
            this.button2_effacer.TabIndex = 10;
            this.button2_effacer.Text = "Effacer";
            this.button2_effacer.UseVisualStyleBackColor = true;
            this.button2_effacer.Click += new System.EventHandler(this.button2_effacer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 310);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2_effacer);
            this.Controls.Add(this.button1_valider);
            this.Controls.Add(this.label5_j_m_a);
            this.Controls.Add(this.label4_code_postal);
            this.Controls.Add(this.label3_montant);
            this.Controls.Add(this.label2_date);
            this.Controls.Add(this.label1_nom);
            this.Controls.Add(this.textBox4_code_postal);
            this.Controls.Add(this.textBox3_montant);
            this.Controls.Add(this.textBox1_nom);
            this.Name = "Form1";
            this.Text = "Les contrôles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1_nom;
        private TextBox textBox3_montant;
        private TextBox textBox4_code_postal;
        private Label label1_nom;
        private Label label2_date;
        private Label label3_montant;
        private Label label4_code_postal;
        private Label label5_j_m_a;
        private Button button1_valider;
        private Button button2_effacer;
        private TextBox textBox1;
    }
}