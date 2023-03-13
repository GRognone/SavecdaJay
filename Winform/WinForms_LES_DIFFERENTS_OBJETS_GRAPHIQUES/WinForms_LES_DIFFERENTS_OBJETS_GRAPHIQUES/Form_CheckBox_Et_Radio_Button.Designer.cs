namespace WinForms_LES_DIFFERENTS_OBJETS_GRAPHIQUES
{
    partial class Form_CheckBox_Et_Radio_Button
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
            this.label_Tapez_Texte = new System.Windows.Forms.Label();
            this.textBox_texte_saisi = new System.Windows.Forms.TextBox();
            this.checkBox_couleur_fond = new System.Windows.Forms.CheckBox();
            this.checkBox_couleur_caractere = new System.Windows.Forms.CheckBox();
            this.checkBox_casse = new System.Windows.Forms.CheckBox();
            this.groupBox_choix = new System.Windows.Forms.GroupBox();
            this.groupBox_fond = new System.Windows.Forms.GroupBox();
            this.radioButton_fond_bleu = new System.Windows.Forms.RadioButton();
            this.radioButton_fond_vert = new System.Windows.Forms.RadioButton();
            this.radioButton_fond_rouge = new System.Windows.Forms.RadioButton();
            this.groupBox_caractere = new System.Windows.Forms.GroupBox();
            this.radioButton_caractere_bleu = new System.Windows.Forms.RadioButton();
            this.radioButton_caractere_vert = new System.Windows.Forms.RadioButton();
            this.radioButton_caractere_rouge = new System.Windows.Forms.RadioButton();
            this.groupBox_casse = new System.Windows.Forms.GroupBox();
            this.radioButton_casse_majuscule = new System.Windows.Forms.RadioButton();
            this.radioButton_casse_minuscule = new System.Windows.Forms.RadioButton();
            this.label_rendu_test = new System.Windows.Forms.Label();
            this.groupBox_choix.SuspendLayout();
            this.groupBox_fond.SuspendLayout();
            this.groupBox_caractere.SuspendLayout();
            this.groupBox_casse.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Tapez_Texte
            // 
            this.label_Tapez_Texte.AutoSize = true;
            this.label_Tapez_Texte.Location = new System.Drawing.Point(19, 16);
            this.label_Tapez_Texte.Name = "label_Tapez_Texte";
            this.label_Tapez_Texte.Size = new System.Drawing.Size(95, 15);
            this.label_Tapez_Texte.TabIndex = 0;
            this.label_Tapez_Texte.Text = "Tapez votre texte";
            // 
            // textBox_texte_saisi
            // 
            this.textBox_texte_saisi.Location = new System.Drawing.Point(21, 41);
            this.textBox_texte_saisi.Name = "textBox_texte_saisi";
            this.textBox_texte_saisi.Size = new System.Drawing.Size(256, 23);
            this.textBox_texte_saisi.TabIndex = 1;
            this.textBox_texte_saisi.TextChanged += new System.EventHandler(this.textBox_texte_saisi_TextChanged);
            // 
            // checkBox_couleur_fond
            // 
            this.checkBox_couleur_fond.AutoSize = true;
            this.checkBox_couleur_fond.Location = new System.Drawing.Point(18, 22);
            this.checkBox_couleur_fond.Name = "checkBox_couleur_fond";
            this.checkBox_couleur_fond.Size = new System.Drawing.Size(113, 19);
            this.checkBox_couleur_fond.TabIndex = 2;
            this.checkBox_couleur_fond.Text = "Couleur du fond";
            this.checkBox_couleur_fond.UseVisualStyleBackColor = true;
            this.checkBox_couleur_fond.CheckedChanged += new System.EventHandler(this.checkBox_couleur_fond_CheckedChanged);
            // 
            // checkBox_couleur_caractere
            // 
            this.checkBox_couleur_caractere.AutoSize = true;
            this.checkBox_couleur_caractere.Location = new System.Drawing.Point(17, 47);
            this.checkBox_couleur_caractere.Name = "checkBox_couleur_caractere";
            this.checkBox_couleur_caractere.Size = new System.Drawing.Size(145, 19);
            this.checkBox_couleur_caractere.TabIndex = 3;
            this.checkBox_couleur_caractere.Text = "Couleur des caractères";
            this.checkBox_couleur_caractere.UseVisualStyleBackColor = true;
            this.checkBox_couleur_caractere.CheckedChanged += new System.EventHandler(this.checkBox_couleur_caractere_CheckedChanged);
            // 
            // checkBox_casse
            // 
            this.checkBox_casse.AutoSize = true;
            this.checkBox_casse.Location = new System.Drawing.Point(18, 72);
            this.checkBox_casse.Name = "checkBox_casse";
            this.checkBox_casse.Size = new System.Drawing.Size(56, 19);
            this.checkBox_casse.TabIndex = 4;
            this.checkBox_casse.Text = "Casse";
            this.checkBox_casse.UseVisualStyleBackColor = true;
            this.checkBox_casse.CheckedChanged += new System.EventHandler(this.checkBox_casse_CheckedChanged);
            // 
            // groupBox_choix
            // 
            this.groupBox_choix.Controls.Add(this.checkBox_couleur_fond);
            this.groupBox_choix.Controls.Add(this.checkBox_couleur_caractere);
            this.groupBox_choix.Controls.Add(this.checkBox_casse);
            this.groupBox_choix.Enabled = false;
            this.groupBox_choix.Location = new System.Drawing.Point(292, 16);
            this.groupBox_choix.Name = "groupBox_choix";
            this.groupBox_choix.Size = new System.Drawing.Size(166, 99);
            this.groupBox_choix.TabIndex = 6;
            this.groupBox_choix.TabStop = false;
            this.groupBox_choix.Text = "Choix";
            // 
            // groupBox_fond
            // 
            this.groupBox_fond.Controls.Add(this.radioButton_fond_bleu);
            this.groupBox_fond.Controls.Add(this.radioButton_fond_vert);
            this.groupBox_fond.Controls.Add(this.radioButton_fond_rouge);
            this.groupBox_fond.Location = new System.Drawing.Point(21, 114);
            this.groupBox_fond.Name = "groupBox_fond";
            this.groupBox_fond.Size = new System.Drawing.Size(87, 100);
            this.groupBox_fond.TabIndex = 7;
            this.groupBox_fond.TabStop = false;
            this.groupBox_fond.Text = "Fond";
            this.groupBox_fond.Visible = false;
            // 
            // radioButton_fond_bleu
            // 
            this.radioButton_fond_bleu.AutoSize = true;
            this.radioButton_fond_bleu.Location = new System.Drawing.Point(8, 72);
            this.radioButton_fond_bleu.Name = "radioButton_fond_bleu";
            this.radioButton_fond_bleu.Size = new System.Drawing.Size(48, 19);
            this.radioButton_fond_bleu.TabIndex = 2;
            this.radioButton_fond_bleu.TabStop = true;
            this.radioButton_fond_bleu.Text = "Bleu";
            this.radioButton_fond_bleu.UseVisualStyleBackColor = true;
            this.radioButton_fond_bleu.CheckedChanged += new System.EventHandler(this.radioButton_fond_bleu_CheckedChanged);
            // 
            // radioButton_fond_vert
            // 
            this.radioButton_fond_vert.AutoSize = true;
            this.radioButton_fond_vert.Location = new System.Drawing.Point(8, 47);
            this.radioButton_fond_vert.Name = "radioButton_fond_vert";
            this.radioButton_fond_vert.Size = new System.Drawing.Size(45, 19);
            this.radioButton_fond_vert.TabIndex = 1;
            this.radioButton_fond_vert.TabStop = true;
            this.radioButton_fond_vert.Text = "Vert";
            this.radioButton_fond_vert.UseVisualStyleBackColor = true;
            this.radioButton_fond_vert.CheckedChanged += new System.EventHandler(this.radioButton_fond_vert_CheckedChanged);
            // 
            // radioButton_fond_rouge
            // 
            this.radioButton_fond_rouge.AutoSize = true;
            this.radioButton_fond_rouge.Location = new System.Drawing.Point(8, 22);
            this.radioButton_fond_rouge.Name = "radioButton_fond_rouge";
            this.radioButton_fond_rouge.Size = new System.Drawing.Size(59, 19);
            this.radioButton_fond_rouge.TabIndex = 0;
            this.radioButton_fond_rouge.TabStop = true;
            this.radioButton_fond_rouge.Text = "Rouge";
            this.radioButton_fond_rouge.UseVisualStyleBackColor = true;
            this.radioButton_fond_rouge.CheckedChanged += new System.EventHandler(this.radioButton_fond_rouge_CheckedChanged);
            // 
            // groupBox_caractere
            // 
            this.groupBox_caractere.Controls.Add(this.radioButton_caractere_bleu);
            this.groupBox_caractere.Controls.Add(this.radioButton_caractere_vert);
            this.groupBox_caractere.Controls.Add(this.radioButton_caractere_rouge);
            this.groupBox_caractere.Location = new System.Drawing.Point(114, 114);
            this.groupBox_caractere.Name = "groupBox_caractere";
            this.groupBox_caractere.Size = new System.Drawing.Size(87, 100);
            this.groupBox_caractere.TabIndex = 8;
            this.groupBox_caractere.TabStop = false;
            this.groupBox_caractere.Text = "Caractères";
            this.groupBox_caractere.Visible = false;
            // 
            // radioButton_caractere_bleu
            // 
            this.radioButton_caractere_bleu.AutoSize = true;
            this.radioButton_caractere_bleu.Location = new System.Drawing.Point(6, 72);
            this.radioButton_caractere_bleu.Name = "radioButton_caractere_bleu";
            this.radioButton_caractere_bleu.Size = new System.Drawing.Size(48, 19);
            this.radioButton_caractere_bleu.TabIndex = 2;
            this.radioButton_caractere_bleu.TabStop = true;
            this.radioButton_caractere_bleu.Text = "Bleu";
            this.radioButton_caractere_bleu.UseVisualStyleBackColor = true;
            this.radioButton_caractere_bleu.CheckedChanged += new System.EventHandler(this.radioButton_caractere_bleu_CheckedChanged);
            // 
            // radioButton_caractere_vert
            // 
            this.radioButton_caractere_vert.AutoSize = true;
            this.radioButton_caractere_vert.Location = new System.Drawing.Point(6, 47);
            this.radioButton_caractere_vert.Name = "radioButton_caractere_vert";
            this.radioButton_caractere_vert.Size = new System.Drawing.Size(45, 19);
            this.radioButton_caractere_vert.TabIndex = 1;
            this.radioButton_caractere_vert.TabStop = true;
            this.radioButton_caractere_vert.Text = "Vert";
            this.radioButton_caractere_vert.UseVisualStyleBackColor = true;
            this.radioButton_caractere_vert.CheckedChanged += new System.EventHandler(this.radioButton_caractere_vert_CheckedChanged);
            // 
            // radioButton_caractere_rouge
            // 
            this.radioButton_caractere_rouge.AutoSize = true;
            this.radioButton_caractere_rouge.Location = new System.Drawing.Point(6, 22);
            this.radioButton_caractere_rouge.Name = "radioButton_caractere_rouge";
            this.radioButton_caractere_rouge.Size = new System.Drawing.Size(59, 19);
            this.radioButton_caractere_rouge.TabIndex = 0;
            this.radioButton_caractere_rouge.TabStop = true;
            this.radioButton_caractere_rouge.Text = "Rouge";
            this.radioButton_caractere_rouge.UseVisualStyleBackColor = true;
            this.radioButton_caractere_rouge.CheckedChanged += new System.EventHandler(this.radioButton_caractere_rouge_CheckedChanged);
            // 
            // groupBox_casse
            // 
            this.groupBox_casse.Controls.Add(this.radioButton_casse_majuscule);
            this.groupBox_casse.Controls.Add(this.radioButton_casse_minuscule);
            this.groupBox_casse.Location = new System.Drawing.Point(207, 136);
            this.groupBox_casse.Name = "groupBox_casse";
            this.groupBox_casse.Size = new System.Drawing.Size(97, 78);
            this.groupBox_casse.TabIndex = 9;
            this.groupBox_casse.TabStop = false;
            this.groupBox_casse.Text = "Casse";
            this.groupBox_casse.Visible = false;
            // 
            // radioButton_casse_majuscule
            // 
            this.radioButton_casse_majuscule.AutoSize = true;
            this.radioButton_casse_majuscule.Location = new System.Drawing.Point(6, 47);
            this.radioButton_casse_majuscule.Name = "radioButton_casse_majuscule";
            this.radioButton_casse_majuscule.Size = new System.Drawing.Size(79, 19);
            this.radioButton_casse_majuscule.TabIndex = 1;
            this.radioButton_casse_majuscule.TabStop = true;
            this.radioButton_casse_majuscule.Text = "Majuscule";
            this.radioButton_casse_majuscule.UseVisualStyleBackColor = true;
            // 
            // radioButton_casse_minuscule
            // 
            this.radioButton_casse_minuscule.AutoSize = true;
            this.radioButton_casse_minuscule.Location = new System.Drawing.Point(6, 22);
            this.radioButton_casse_minuscule.Name = "radioButton_casse_minuscule";
            this.radioButton_casse_minuscule.Size = new System.Drawing.Size(80, 19);
            this.radioButton_casse_minuscule.TabIndex = 0;
            this.radioButton_casse_minuscule.TabStop = true;
            this.radioButton_casse_minuscule.Text = "Minuscule";
            this.radioButton_casse_minuscule.UseVisualStyleBackColor = true;
            // 
            // label_rendu_test
            // 
            this.label_rendu_test.AutoSize = true;
            this.label_rendu_test.Location = new System.Drawing.Point(21, 88);
            this.label_rendu_test.Name = "label_rendu_test";
            this.label_rendu_test.Size = new System.Drawing.Size(38, 15);
            this.label_rendu_test.TabIndex = 10;
            this.label_rendu_test.Text = "label1";
            // 
            // Form_CheckBox_Et_Radio_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 235);
            this.Controls.Add(this.label_rendu_test);
            this.Controls.Add(this.groupBox_casse);
            this.Controls.Add(this.groupBox_caractere);
            this.Controls.Add(this.groupBox_fond);
            this.Controls.Add(this.groupBox_choix);
            this.Controls.Add(this.textBox_texte_saisi);
            this.Controls.Add(this.label_Tapez_Texte);
            this.Name = "Form_CheckBox_Et_Radio_Button";
            this.Text = "Form_CheckBox_Et_Radio_Button";
            this.groupBox_choix.ResumeLayout(false);
            this.groupBox_choix.PerformLayout();
            this.groupBox_fond.ResumeLayout(false);
            this.groupBox_fond.PerformLayout();
            this.groupBox_caractere.ResumeLayout(false);
            this.groupBox_caractere.PerformLayout();
            this.groupBox_casse.ResumeLayout(false);
            this.groupBox_casse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Tapez_Texte;
        private TextBox textBox_texte_saisi;
        private CheckBox checkBox_couleur_fond;
        private CheckBox checkBox_couleur_caractere;
        private CheckBox checkBox_casse;
        private GroupBox groupBox_choix;
        private GroupBox groupBox_fond;
        private RadioButton radioButton_fond_bleu;
        private RadioButton radioButton_fond_vert;
        private RadioButton radioButton_fond_rouge;
        private GroupBox groupBox_caractere;
        private RadioButton radioButton_caractere_bleu;
        private RadioButton radioButton_caractere_vert;
        private RadioButton radioButton_caractere_rouge;
        private GroupBox groupBox_casse;
        private RadioButton radioButton_casse_majuscule;
        private RadioButton radioButton_casse_minuscule;
        private Label label_rendu_test;
    }
}