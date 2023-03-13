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
            label_Tapez_Texte = new Label();
            textBox_texte_saisi = new TextBox();
            checkBox_couleur_fond = new CheckBox();
            checkBox_couleur_caractere = new CheckBox();
            checkBox_casse = new CheckBox();
            groupBox_choix = new GroupBox();
            groupBox_fond = new GroupBox();
            radioButton_fond_bleu = new RadioButton();
            radioButton_fond_vert = new RadioButton();
            radioButton_fond_rouge = new RadioButton();
            groupBox_caractere = new GroupBox();
            radioButton_caractere_bleu = new RadioButton();
            radioButton_caractere_vert = new RadioButton();
            radioButton_caractere_rouge = new RadioButton();
            groupBox_casse = new GroupBox();
            radioButton_casse_majuscule = new RadioButton();
            radioButton_casse_minuscule = new RadioButton();
            label_rendu_test = new Label();
            groupBox_choix.SuspendLayout();
            groupBox_fond.SuspendLayout();
            groupBox_caractere.SuspendLayout();
            groupBox_casse.SuspendLayout();
            SuspendLayout();
            // 
            // label_Tapez_Texte
            // 
            label_Tapez_Texte.AutoSize = true;
            label_Tapez_Texte.Location = new Point(27, 27);
            label_Tapez_Texte.Margin = new Padding(4, 0, 4, 0);
            label_Tapez_Texte.Name = "label_Tapez_Texte";
            label_Tapez_Texte.Size = new Size(145, 25);
            label_Tapez_Texte.TabIndex = 0;
            label_Tapez_Texte.Text = "Tapez votre texte";
            // 
            // textBox_texte_saisi
            // 
            textBox_texte_saisi.Location = new Point(30, 68);
            textBox_texte_saisi.Margin = new Padding(4, 5, 4, 5);
            textBox_texte_saisi.Name = "textBox_texte_saisi";
            textBox_texte_saisi.Size = new Size(364, 31);
            textBox_texte_saisi.TabIndex = 1;
            textBox_texte_saisi.TextChanged += textBox_texte_saisi_TextChanged;
            // 
            // checkBox_couleur_fond
            // 
            checkBox_couleur_fond.AutoSize = true;
            checkBox_couleur_fond.Location = new Point(26, 37);
            checkBox_couleur_fond.Margin = new Padding(4, 5, 4, 5);
            checkBox_couleur_fond.Name = "checkBox_couleur_fond";
            checkBox_couleur_fond.Size = new Size(168, 29);
            checkBox_couleur_fond.TabIndex = 2;
            checkBox_couleur_fond.Text = "Couleur du fond";
            checkBox_couleur_fond.UseVisualStyleBackColor = true;
            checkBox_couleur_fond.CheckedChanged += checkBox_couleur_fond_CheckedChanged;
            // 
            // checkBox_couleur_caractere
            // 
            checkBox_couleur_caractere.AutoSize = true;
            checkBox_couleur_caractere.Location = new Point(24, 78);
            checkBox_couleur_caractere.Margin = new Padding(4, 5, 4, 5);
            checkBox_couleur_caractere.Name = "checkBox_couleur_caractere";
            checkBox_couleur_caractere.Size = new Size(215, 29);
            checkBox_couleur_caractere.TabIndex = 3;
            checkBox_couleur_caractere.Text = "Couleur des caractères";
            checkBox_couleur_caractere.UseVisualStyleBackColor = true;
            checkBox_couleur_caractere.CheckedChanged += checkBox_couleur_caractere_CheckedChanged;
            // 
            // checkBox_casse
            // 
            checkBox_casse.AutoSize = true;
            checkBox_casse.Location = new Point(26, 120);
            checkBox_casse.Margin = new Padding(4, 5, 4, 5);
            checkBox_casse.Name = "checkBox_casse";
            checkBox_casse.Size = new Size(83, 29);
            checkBox_casse.TabIndex = 4;
            checkBox_casse.Text = "Casse";
            checkBox_casse.UseVisualStyleBackColor = true;
            checkBox_casse.CheckedChanged += checkBox_casse_CheckedChanged;
            // 
            // groupBox_choix
            // 
            groupBox_choix.Controls.Add(checkBox_couleur_fond);
            groupBox_choix.Controls.Add(checkBox_couleur_caractere);
            groupBox_choix.Controls.Add(checkBox_casse);
            groupBox_choix.Enabled = false;
            groupBox_choix.Location = new Point(417, 27);
            groupBox_choix.Margin = new Padding(4, 5, 4, 5);
            groupBox_choix.Name = "groupBox_choix";
            groupBox_choix.Padding = new Padding(4, 5, 4, 5);
            groupBox_choix.Size = new Size(237, 165);
            groupBox_choix.TabIndex = 6;
            groupBox_choix.TabStop = false;
            groupBox_choix.Text = "Choix";
            // 
            // groupBox_fond
            // 
            groupBox_fond.Controls.Add(radioButton_fond_bleu);
            groupBox_fond.Controls.Add(radioButton_fond_vert);
            groupBox_fond.Controls.Add(radioButton_fond_rouge);
            groupBox_fond.Location = new Point(30, 190);
            groupBox_fond.Margin = new Padding(4, 5, 4, 5);
            groupBox_fond.Name = "groupBox_fond";
            groupBox_fond.Padding = new Padding(4, 5, 4, 5);
            groupBox_fond.Size = new Size(124, 167);
            groupBox_fond.TabIndex = 7;
            groupBox_fond.TabStop = false;
            groupBox_fond.Text = "Fond";
            groupBox_fond.Visible = false;
            // 
            // radioButton_fond_bleu
            // 
            radioButton_fond_bleu.AutoSize = true;
            radioButton_fond_bleu.Location = new Point(11, 120);
            radioButton_fond_bleu.Margin = new Padding(4, 5, 4, 5);
            radioButton_fond_bleu.Name = "radioButton_fond_bleu";
            radioButton_fond_bleu.Size = new Size(70, 29);
            radioButton_fond_bleu.TabIndex = 2;
            radioButton_fond_bleu.TabStop = true;
            radioButton_fond_bleu.Text = "Bleu";
            radioButton_fond_bleu.UseVisualStyleBackColor = true;
            radioButton_fond_bleu.CheckedChanged += radioButton_fond_bleu_CheckedChanged;
            // 
            // radioButton_fond_vert
            // 
            radioButton_fond_vert.AutoSize = true;
            radioButton_fond_vert.Location = new Point(11, 78);
            radioButton_fond_vert.Margin = new Padding(4, 5, 4, 5);
            radioButton_fond_vert.Name = "radioButton_fond_vert";
            radioButton_fond_vert.Size = new Size(68, 29);
            radioButton_fond_vert.TabIndex = 1;
            radioButton_fond_vert.TabStop = true;
            radioButton_fond_vert.Text = "Vert";
            radioButton_fond_vert.UseVisualStyleBackColor = true;
            radioButton_fond_vert.CheckedChanged += radioButton_fond_vert_CheckedChanged;
            // 
            // radioButton_fond_rouge
            // 
            radioButton_fond_rouge.AutoSize = true;
            radioButton_fond_rouge.Location = new Point(11, 37);
            radioButton_fond_rouge.Margin = new Padding(4, 5, 4, 5);
            radioButton_fond_rouge.Name = "radioButton_fond_rouge";
            radioButton_fond_rouge.Size = new Size(88, 29);
            radioButton_fond_rouge.TabIndex = 0;
            radioButton_fond_rouge.TabStop = true;
            radioButton_fond_rouge.Text = "Rouge";
            radioButton_fond_rouge.UseVisualStyleBackColor = true;
            radioButton_fond_rouge.CheckedChanged += radioButton_fond_rouge_CheckedChanged;
            // 
            // groupBox_caractere
            // 
            groupBox_caractere.Controls.Add(radioButton_caractere_bleu);
            groupBox_caractere.Controls.Add(radioButton_caractere_vert);
            groupBox_caractere.Controls.Add(radioButton_caractere_rouge);
            groupBox_caractere.Location = new Point(163, 190);
            groupBox_caractere.Margin = new Padding(4, 5, 4, 5);
            groupBox_caractere.Name = "groupBox_caractere";
            groupBox_caractere.Padding = new Padding(4, 5, 4, 5);
            groupBox_caractere.Size = new Size(124, 167);
            groupBox_caractere.TabIndex = 8;
            groupBox_caractere.TabStop = false;
            groupBox_caractere.Text = "Caractères";
            groupBox_caractere.Visible = false;
            // 
            // radioButton_caractere_bleu
            // 
            radioButton_caractere_bleu.AutoSize = true;
            radioButton_caractere_bleu.Location = new Point(9, 120);
            radioButton_caractere_bleu.Margin = new Padding(4, 5, 4, 5);
            radioButton_caractere_bleu.Name = "radioButton_caractere_bleu";
            radioButton_caractere_bleu.Size = new Size(70, 29);
            radioButton_caractere_bleu.TabIndex = 2;
            radioButton_caractere_bleu.TabStop = true;
            radioButton_caractere_bleu.Text = "Bleu";
            radioButton_caractere_bleu.UseVisualStyleBackColor = true;
            radioButton_caractere_bleu.CheckedChanged += radioButton_caractere_bleu_CheckedChanged;
            // 
            // radioButton_caractere_vert
            // 
            radioButton_caractere_vert.AutoSize = true;
            radioButton_caractere_vert.Location = new Point(9, 78);
            radioButton_caractere_vert.Margin = new Padding(4, 5, 4, 5);
            radioButton_caractere_vert.Name = "radioButton_caractere_vert";
            radioButton_caractere_vert.Size = new Size(68, 29);
            radioButton_caractere_vert.TabIndex = 1;
            radioButton_caractere_vert.TabStop = true;
            radioButton_caractere_vert.Text = "Vert";
            radioButton_caractere_vert.UseVisualStyleBackColor = true;
            radioButton_caractere_vert.CheckedChanged += radioButton_caractere_vert_CheckedChanged;
            // 
            // radioButton_caractere_rouge
            // 
            radioButton_caractere_rouge.AutoSize = true;
            radioButton_caractere_rouge.Location = new Point(9, 37);
            radioButton_caractere_rouge.Margin = new Padding(4, 5, 4, 5);
            radioButton_caractere_rouge.Name = "radioButton_caractere_rouge";
            radioButton_caractere_rouge.Size = new Size(88, 29);
            radioButton_caractere_rouge.TabIndex = 0;
            radioButton_caractere_rouge.TabStop = true;
            radioButton_caractere_rouge.Text = "Rouge";
            radioButton_caractere_rouge.UseVisualStyleBackColor = true;
            radioButton_caractere_rouge.CheckedChanged += radioButton_caractere_rouge_CheckedChanged;
            // 
            // groupBox_casse
            // 
            groupBox_casse.Controls.Add(radioButton_casse_majuscule);
            groupBox_casse.Controls.Add(radioButton_casse_minuscule);
            groupBox_casse.Location = new Point(296, 227);
            groupBox_casse.Margin = new Padding(4, 5, 4, 5);
            groupBox_casse.Name = "groupBox_casse";
            groupBox_casse.Padding = new Padding(4, 5, 4, 5);
            groupBox_casse.Size = new Size(139, 130);
            groupBox_casse.TabIndex = 9;
            groupBox_casse.TabStop = false;
            groupBox_casse.Text = "Casse";
            groupBox_casse.Visible = false;
            // 
            // radioButton_casse_majuscule
            // 
            radioButton_casse_majuscule.AutoSize = true;
            radioButton_casse_majuscule.Location = new Point(9, 78);
            radioButton_casse_majuscule.Margin = new Padding(4, 5, 4, 5);
            radioButton_casse_majuscule.Name = "radioButton_casse_majuscule";
            radioButton_casse_majuscule.Size = new Size(115, 29);
            radioButton_casse_majuscule.TabIndex = 1;
            radioButton_casse_majuscule.TabStop = true;
            radioButton_casse_majuscule.Text = "Majuscule";
            radioButton_casse_majuscule.UseVisualStyleBackColor = true;
            radioButton_casse_majuscule.CheckedChanged += radioButton_casse_majuscule_CheckedChanged;
            // 
            // radioButton_casse_minuscule
            // 
            radioButton_casse_minuscule.AutoSize = true;
            radioButton_casse_minuscule.Location = new Point(9, 37);
            radioButton_casse_minuscule.Margin = new Padding(4, 5, 4, 5);
            radioButton_casse_minuscule.Name = "radioButton_casse_minuscule";
            radioButton_casse_minuscule.Size = new Size(116, 29);
            radioButton_casse_minuscule.TabIndex = 0;
            radioButton_casse_minuscule.TabStop = true;
            radioButton_casse_minuscule.Text = "Minuscule";
            radioButton_casse_minuscule.UseVisualStyleBackColor = true;
            radioButton_casse_minuscule.CheckedChanged += radioButton_casse_minuscule_CheckedChanged;
            radioButton_casse_minuscule.VisibleChanged += radioButton_casse_minuscule_CheckedChanged;
            // 
            // label_rendu_test
            // 
            label_rendu_test.AutoSize = true;
            label_rendu_test.Location = new Point(30, 147);
            label_rendu_test.Margin = new Padding(4, 0, 4, 0);
            label_rendu_test.Name = "label_rendu_test";
            label_rendu_test.Size = new Size(59, 25);
            label_rendu_test.TabIndex = 10;
            label_rendu_test.Text = "label1";
            label_rendu_test.TextChanged += checkBox_casse_CheckedChanged;
            // 
            // Form_CheckBox_Et_Radio_Button
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 392);
            Controls.Add(label_rendu_test);
            Controls.Add(groupBox_casse);
            Controls.Add(groupBox_caractere);
            Controls.Add(groupBox_fond);
            Controls.Add(groupBox_choix);
            Controls.Add(textBox_texte_saisi);
            Controls.Add(label_Tapez_Texte);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_CheckBox_Et_Radio_Button";
            Text = "Form_CheckBox_Et_Radio_Button";
            groupBox_choix.ResumeLayout(false);
            groupBox_choix.PerformLayout();
            groupBox_fond.ResumeLayout(false);
            groupBox_fond.PerformLayout();
            groupBox_caractere.ResumeLayout(false);
            groupBox_caractere.PerformLayout();
            groupBox_casse.ResumeLayout(false);
            groupBox_casse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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