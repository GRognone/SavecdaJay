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
            components = new System.ComponentModel.Container();
            button1_valider = new Button();
            button2_effacer = new Button();
            textBox1_nom = new TextBox();
            textBox2_date = new TextBox();
            textBox3_montant = new TextBox();
            textBox4_code_postal = new TextBox();
            label1_nom = new Label();
            label2_date = new Label();
            label3_montant = new Label();
            label4_code_postal = new Label();
            label5_date_txt = new Label();
            errorProvider1_nom = new ErrorProvider(components);
            errorProvider_date = new ErrorProvider(components);
            errorProvider_montant = new ErrorProvider(components);
            errorProvider_code_postal = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1_nom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_date).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_montant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_code_postal).BeginInit();
            SuspendLayout();
            // 
            // button1_valider
            // 
            button1_valider.Location = new Point(379, 347);
            button1_valider.Margin = new Padding(4, 5, 4, 5);
            button1_valider.Name = "button1_valider";
            button1_valider.Size = new Size(107, 38);
            button1_valider.TabIndex = 0;
            button1_valider.Text = "Valider";
            button1_valider.UseVisualStyleBackColor = true;
            button1_valider.Click += button1_valider_Click;
            // 
            // button2_effacer
            // 
            button2_effacer.Location = new Point(379, 417);
            button2_effacer.Margin = new Padding(4, 5, 4, 5);
            button2_effacer.Name = "button2_effacer";
            button2_effacer.Size = new Size(107, 38);
            button2_effacer.TabIndex = 1;
            button2_effacer.Text = "Effacer";
            button2_effacer.UseVisualStyleBackColor = true;
            button2_effacer.Click += button2_effacer_Click;
            // 
            // textBox1_nom
            // 
            textBox1_nom.Location = new Point(159, 103);
            textBox1_nom.Margin = new Padding(4, 5, 4, 5);
            textBox1_nom.Name = "textBox1_nom";
            textBox1_nom.Size = new Size(215, 31);
            textBox1_nom.TabIndex = 2;
            textBox1_nom.TextChanged += textBox1_nom_TextChanged;
            // 
            // textBox2_date
            // 
            textBox2_date.Location = new Point(159, 183);
            textBox2_date.Margin = new Padding(4, 5, 4, 5);
            textBox2_date.Name = "textBox2_date";
            textBox2_date.Size = new Size(141, 31);
            textBox2_date.TabIndex = 3;
            textBox2_date.TextChanged += textBox2_date_TextChanged;
            // 
            // textBox3_montant
            // 
            textBox3_montant.Location = new Point(159, 258);
            textBox3_montant.Margin = new Padding(4, 5, 4, 5);
            textBox3_montant.Name = "textBox3_montant";
            textBox3_montant.Size = new Size(141, 31);
            textBox3_montant.TabIndex = 4;
            textBox3_montant.TextChanged += textBox3_montant_TextChanged;
            // 
            // textBox4_code_postal
            // 
            textBox4_code_postal.Location = new Point(159, 333);
            textBox4_code_postal.Margin = new Padding(4, 5, 4, 5);
            textBox4_code_postal.Name = "textBox4_code_postal";
            textBox4_code_postal.Size = new Size(141, 31);
            textBox4_code_postal.TabIndex = 5;
            textBox4_code_postal.TextChanged += textBox4_code_postal_TextChanged;
            // 
            // label1_nom
            // 
            label1_nom.AutoSize = true;
            label1_nom.Location = new Point(13, 117);
            label1_nom.Margin = new Padding(4, 0, 4, 0);
            label1_nom.Name = "label1_nom";
            label1_nom.Size = new Size(52, 25);
            label1_nom.TabIndex = 6;
            label1_nom.Text = "Nom";
            // 
            // label2_date
            // 
            label2_date.AutoSize = true;
            label2_date.Location = new Point(17, 197);
            label2_date.Margin = new Padding(4, 0, 4, 0);
            label2_date.Name = "label2_date";
            label2_date.Size = new Size(49, 25);
            label2_date.TabIndex = 7;
            label2_date.Text = "Date";
            // 
            // label3_montant
            // 
            label3_montant.AutoSize = true;
            label3_montant.Location = new Point(17, 272);
            label3_montant.Margin = new Padding(4, 0, 4, 0);
            label3_montant.Name = "label3_montant";
            label3_montant.Size = new Size(80, 25);
            label3_montant.TabIndex = 8;
            label3_montant.Text = "Montant";
            // 
            // label4_code_postal
            // 
            label4_code_postal.AutoSize = true;
            label4_code_postal.Location = new Point(17, 347);
            label4_code_postal.Margin = new Padding(4, 0, 4, 0);
            label4_code_postal.Name = "label4_code_postal";
            label4_code_postal.Size = new Size(106, 25);
            label4_code_postal.TabIndex = 9;
            label4_code_postal.Text = "Code Postal";
            // 
            // label5_date_txt
            // 
            label5_date_txt.AutoSize = true;
            label5_date_txt.Location = new Point(321, 197);
            label5_date_txt.Margin = new Padding(4, 0, 4, 0);
            label5_date_txt.Name = "label5_date_txt";
            label5_date_txt.Size = new Size(127, 25);
            label5_date_txt.TabIndex = 10;
            label5_date_txt.Text = "(JJ/MM/AAAA)";
            // 
            // errorProvider1_nom
            // 
            errorProvider1_nom.ContainerControl = this;
            // 
            // errorProvider_date
            // 
            errorProvider_date.ContainerControl = this;
            // 
            // errorProvider_montant
            // 
            errorProvider_montant.ContainerControl = this;
            // 
            // errorProvider_code_postal
            // 
            errorProvider_code_postal.ContainerControl = this;
            // 
            // FormulaireDeSaisie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 467);
            Controls.Add(label5_date_txt);
            Controls.Add(label4_code_postal);
            Controls.Add(label3_montant);
            Controls.Add(label2_date);
            Controls.Add(label1_nom);
            Controls.Add(textBox4_code_postal);
            Controls.Add(textBox3_montant);
            Controls.Add(textBox2_date);
            Controls.Add(textBox1_nom);
            Controls.Add(button2_effacer);
            Controls.Add(button1_valider);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(551, 523);
            MinimumSize = new Size(551, 523);
            Name = "FormulaireDeSaisie";
            Text = "FormulaireDeSaisie";
            FormClosed += FormulaireDeSaisie_FormClosed;
            ((System.ComponentModel.ISupportInitialize)errorProvider1_nom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_date).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_montant).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_code_postal).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ErrorProvider errorProvider_date;
        private ErrorProvider errorProvider_montant;
        private ErrorProvider errorProvider_code_postal;
    }
}