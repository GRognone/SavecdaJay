namespace WinFormsLesDifferentsObjetsGraphiques
{
    partial class FormLesDifferentsObjetsGraphiques
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
            labelTapezTexte = new Label();
            textBox_texte_saisi = new TextBox();
            groupBox_choix = new GroupBox();
            checkBox_casse = new CheckBox();
            checkBox_couleur_caractere = new CheckBox();
            checkBox_couleur_fond = new CheckBox();
            label_rendu_test = new Label();
            groupBox_fond = new GroupBox();
            radioButton_fond_bleu = new RadioButton();
            radioButton_fond_vert = new RadioButton();
            radioButton_fond_rouge = new RadioButton();
            groupBox_caractere = new GroupBox();
            radioButton_caractere_noir = new RadioButton();
            radioButton_caractere_blanc = new RadioButton();
            radioButton_caractere_rouge = new RadioButton();
            groupBox_casse = new GroupBox();
            radioButton_casse_majuscule = new RadioButton();
            radioButton_casse_minuscule = new RadioButton();
            groupBox_choix.SuspendLayout();
            groupBox_fond.SuspendLayout();
            groupBox_caractere.SuspendLayout();
            groupBox_casse.SuspendLayout();
            SuspendLayout();
            // 
            // labelTapezTexte
            // 
            labelTapezTexte.AutoSize = true;
            labelTapezTexte.Location = new Point(12, 19);
            labelTapezTexte.Name = "labelTapezTexte";
            labelTapezTexte.Size = new Size(95, 15);
            labelTapezTexte.TabIndex = 0;
            labelTapezTexte.Text = "Tapez votre texte";
            // 
            // textBox_texte_saisi
            // 
            textBox_texte_saisi.Location = new Point(12, 48);
            textBox_texte_saisi.Name = "textBox_texte_saisi";
            textBox_texte_saisi.Size = new Size(255, 23);
            textBox_texte_saisi.TabIndex = 1;
            textBox_texte_saisi.TextChanged += textBox_texte_saisi_TextChanged;
            // 
            // groupBox_choix
            // 
            groupBox_choix.Controls.Add(checkBox_casse);
            groupBox_choix.Controls.Add(checkBox_couleur_caractere);
            groupBox_choix.Controls.Add(checkBox_couleur_fond);
            groupBox_choix.Enabled = false;
            groupBox_choix.Location = new Point(308, 19);
            groupBox_choix.Name = "groupBox_choix";
            groupBox_choix.Size = new Size(200, 100);
            groupBox_choix.TabIndex = 2;
            groupBox_choix.TabStop = false;
            groupBox_choix.Text = "Choix";
            // 
            // checkBox_casse
            // 
            checkBox_casse.AutoSize = true;
            checkBox_casse.Location = new Point(10, 77);
            checkBox_casse.Name = "checkBox_casse";
            checkBox_casse.Size = new Size(56, 19);
            checkBox_casse.TabIndex = 2;
            checkBox_casse.Text = "Casse";
            checkBox_casse.UseVisualStyleBackColor = true;
            checkBox_casse.CheckedChanged += checkBox_casse_CheckedChanged;
            // 
            // checkBox_couleur_caractere
            // 
            checkBox_couleur_caractere.AutoSize = true;
            checkBox_couleur_caractere.Location = new Point(13, 49);
            checkBox_couleur_caractere.Name = "checkBox_couleur_caractere";
            checkBox_couleur_caractere.Size = new Size(145, 19);
            checkBox_couleur_caractere.TabIndex = 1;
            checkBox_couleur_caractere.Text = "Couleur des caractères";
            checkBox_couleur_caractere.UseVisualStyleBackColor = true;
            checkBox_couleur_caractere.CheckedChanged += checkBox_couleur_caractere_CheckedChanged;
            // 
            // checkBox_couleur_fond
            // 
            checkBox_couleur_fond.AutoSize = true;
            checkBox_couleur_fond.Location = new Point(14, 24);
            checkBox_couleur_fond.Name = "checkBox_couleur_fond";
            checkBox_couleur_fond.Size = new Size(113, 19);
            checkBox_couleur_fond.TabIndex = 0;
            checkBox_couleur_fond.Text = "Couleur du fond";
            checkBox_couleur_fond.UseVisualStyleBackColor = true;
            checkBox_couleur_fond.CheckedChanged += checkBox_couleur_fond_CheckedChanged;
            // 
            // label_rendu_test
            // 
            label_rendu_test.AutoSize = true;
            label_rendu_test.Location = new Point(15, 131);
            label_rendu_test.Name = "label_rendu_test";
            label_rendu_test.Size = new Size(0, 15);
            label_rendu_test.TabIndex = 3;
            // 
            // groupBox_fond
            // 
            groupBox_fond.Controls.Add(radioButton_fond_bleu);
            groupBox_fond.Controls.Add(radioButton_fond_vert);
            groupBox_fond.Controls.Add(radioButton_fond_rouge);
            groupBox_fond.Location = new Point(15, 169);
            groupBox_fond.Name = "groupBox_fond";
            groupBox_fond.Size = new Size(108, 100);
            groupBox_fond.TabIndex = 4;
            groupBox_fond.TabStop = false;
            groupBox_fond.Text = "Fond";
            groupBox_fond.Visible = false;
            // 
            // radioButton_fond_bleu
            // 
            radioButton_fond_bleu.AutoSize = true;
            radioButton_fond_bleu.Location = new Point(16, 76);
            radioButton_fond_bleu.Name = "radioButton_fond_bleu";
            radioButton_fond_bleu.Size = new Size(48, 19);
            radioButton_fond_bleu.TabIndex = 2;
            radioButton_fond_bleu.TabStop = true;
            radioButton_fond_bleu.Text = "Bleu";
            radioButton_fond_bleu.UseVisualStyleBackColor = true;
            radioButton_fond_bleu.CheckedChanged += radioButton_fond_bleu_CheckedChanged;
            // 
            // radioButton_fond_vert
            // 
            radioButton_fond_vert.AutoSize = true;
            radioButton_fond_vert.Location = new Point(14, 50);
            radioButton_fond_vert.Name = "radioButton_fond_vert";
            radioButton_fond_vert.Size = new Size(45, 19);
            radioButton_fond_vert.TabIndex = 1;
            radioButton_fond_vert.TabStop = true;
            radioButton_fond_vert.Text = "Vert";
            radioButton_fond_vert.UseVisualStyleBackColor = true;
            radioButton_fond_vert.CheckedChanged += radioButton_fond_vert_CheckedChanged;
            // 
            // radioButton_fond_rouge
            // 
            radioButton_fond_rouge.AutoSize = true;
            radioButton_fond_rouge.Location = new Point(15, 24);
            radioButton_fond_rouge.Name = "radioButton_fond_rouge";
            radioButton_fond_rouge.Size = new Size(59, 19);
            radioButton_fond_rouge.TabIndex = 0;
            radioButton_fond_rouge.TabStop = true;
            radioButton_fond_rouge.Text = "Rouge";
            radioButton_fond_rouge.UseVisualStyleBackColor = true;
            radioButton_fond_rouge.CheckedChanged += radioButton_fond_rouge_CheckedChanged;
            // 
            // groupBox_caractere
            // 
            groupBox_caractere.Controls.Add(radioButton_caractere_noir);
            groupBox_caractere.Controls.Add(radioButton_caractere_blanc);
            groupBox_caractere.Controls.Add(radioButton_caractere_rouge);
            groupBox_caractere.Location = new Point(139, 169);
            groupBox_caractere.Name = "groupBox_caractere";
            groupBox_caractere.Size = new Size(94, 100);
            groupBox_caractere.TabIndex = 5;
            groupBox_caractere.TabStop = false;
            groupBox_caractere.Text = "Caractère";
            groupBox_caractere.Visible = false;
            // 
            // radioButton_caractere_noir
            // 
            radioButton_caractere_noir.AutoSize = true;
            radioButton_caractere_noir.Location = new Point(11, 76);
            radioButton_caractere_noir.Name = "radioButton_caractere_noir";
            radioButton_caractere_noir.Size = new Size(48, 19);
            radioButton_caractere_noir.TabIndex = 2;
            radioButton_caractere_noir.TabStop = true;
            radioButton_caractere_noir.Text = "Noir";
            radioButton_caractere_noir.UseVisualStyleBackColor = true;
            radioButton_caractere_noir.CheckedChanged += radioButton_caractere_noir_CheckedChanged;
            // 
            // radioButton_caractere_blanc
            // 
            radioButton_caractere_blanc.AutoSize = true;
            radioButton_caractere_blanc.Location = new Point(14, 50);
            radioButton_caractere_blanc.Name = "radioButton_caractere_blanc";
            radioButton_caractere_blanc.Size = new Size(54, 19);
            radioButton_caractere_blanc.TabIndex = 1;
            radioButton_caractere_blanc.TabStop = true;
            radioButton_caractere_blanc.Text = "Blanc";
            radioButton_caractere_blanc.UseVisualStyleBackColor = true;
            radioButton_caractere_blanc.CheckedChanged += radioButton_caractere_blanc_CheckedChanged;
            // 
            // radioButton_caractere_rouge
            // 
            radioButton_caractere_rouge.AutoSize = true;
            radioButton_caractere_rouge.Location = new Point(14, 24);
            radioButton_caractere_rouge.Name = "radioButton_caractere_rouge";
            radioButton_caractere_rouge.Size = new Size(59, 19);
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
            groupBox_casse.Location = new Point(239, 193);
            groupBox_casse.Name = "groupBox_casse";
            groupBox_casse.Size = new Size(117, 76);
            groupBox_casse.TabIndex = 6;
            groupBox_casse.TabStop = false;
            groupBox_casse.Text = "Casse";
            groupBox_casse.Visible = false;
            // 
            // radioButton_casse_majuscule
            // 
            radioButton_casse_majuscule.AutoSize = true;
            radioButton_casse_majuscule.Location = new Point(11, 51);
            radioButton_casse_majuscule.Name = "radioButton_casse_majuscule";
            radioButton_casse_majuscule.Size = new Size(79, 19);
            radioButton_casse_majuscule.TabIndex = 1;
            radioButton_casse_majuscule.TabStop = true;
            radioButton_casse_majuscule.Text = "Majuscule";
            radioButton_casse_majuscule.UseVisualStyleBackColor = true;
            radioButton_casse_majuscule.CheckedChanged += radioButton_casse_majuscule_CheckedChanged;
            // 
            // radioButton_casse_minuscule
            // 
            radioButton_casse_minuscule.AutoSize = true;
            radioButton_casse_minuscule.Location = new Point(11, 26);
            radioButton_casse_minuscule.Name = "radioButton_casse_minuscule";
            radioButton_casse_minuscule.Size = new Size(80, 19);
            radioButton_casse_minuscule.TabIndex = 0;
            radioButton_casse_minuscule.TabStop = true;
            radioButton_casse_minuscule.Text = "Minuscule";
            radioButton_casse_minuscule.UseVisualStyleBackColor = true;
            radioButton_casse_minuscule.CheckedChanged += radioButton_casse_minuscule_CheckedChanged;
            // 
            // FormLesDifferentsObjetsGraphiques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 310);
            Controls.Add(groupBox_casse);
            Controls.Add(groupBox_caractere);
            Controls.Add(groupBox_fond);
            Controls.Add(label_rendu_test);
            Controls.Add(groupBox_choix);
            Controls.Add(textBox_texte_saisi);
            Controls.Add(labelTapezTexte);
            Name = "FormLesDifferentsObjetsGraphiques";
            Text = "FormLesDifferentsObjetsGraphiques";
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

        private Label labelTapezTexte;
        private TextBox textBox_texte_saisi;
        private GroupBox groupBox_choix;
        private CheckBox checkBox_couleur_fond;
        private CheckBox checkBox_casse;
        private CheckBox checkBox_couleur_caractere;
        private Label label_rendu_test;
        private GroupBox groupBox_fond;
        private RadioButton radioButton_fond_bleu;
        private RadioButton radioButton_fond_vert;
        private RadioButton radioButton_fond_rouge;
        private GroupBox groupBox_caractere;
        private RadioButton radioButton_caractere_noir;
        private RadioButton radioButton_caractere_blanc;
        private RadioButton radioButton_caractere_rouge;
        private GroupBox groupBox_casse;
        private RadioButton radioButton_casse_majuscule;
        private RadioButton radioButton_casse_minuscule;
    }
}