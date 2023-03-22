namespace WinFormsSynthese
{
    partial class FormEmprunt
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
            textBox_nom = new TextBox();
            label_capital_emprunte = new Label();
            textBox_capital_emprunte = new TextBox();
            label_Periodicite_emprunt = new Label();
            label_Duree_en_mois = new Label();
            hScrollBar_duree = new HScrollBar();
            label_periodicite_rembs = new Label();
            listBox_periodicite_rembs = new ListBox();
            label_nb_remboursements = new Label();
            label_remboursement = new Label();
            errorProvider_nom = new ErrorProvider(components);
            errorProvider_capital = new ErrorProvider(components);
            groupBox_taux_interet = new GroupBox();
            radioButton_interet_9 = new RadioButton();
            radioButton_interet_8 = new RadioButton();
            radioButton_interet_7 = new RadioButton();
            button_ok = new Button();
            button_annuler = new Button();
            label_montant_remb_periodicite = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_capital).BeginInit();
            groupBox_taux_interet.SuspendLayout();
            SuspendLayout();
            // 
            // label_nom
            // 
            label_nom.AutoSize = true;
            label_nom.Location = new Point(49, 62);
            label_nom.Name = "label_nom";
            label_nom.Size = new Size(52, 25);
            label_nom.TabIndex = 0;
            label_nom.Text = "Nom";
            // 
            // textBox_nom
            // 
            textBox_nom.Location = new Point(213, 55);
            textBox_nom.Name = "textBox_nom";
            textBox_nom.Size = new Size(150, 31);
            textBox_nom.TabIndex = 1;
            textBox_nom.TextChanged += textBox_nom_TextChanged;
            // 
            // label_capital_emprunte
            // 
            label_capital_emprunte.AutoSize = true;
            label_capital_emprunte.Location = new Point(49, 125);
            label_capital_emprunte.Name = "label_capital_emprunte";
            label_capital_emprunte.Size = new Size(148, 25);
            label_capital_emprunte.TabIndex = 2;
            label_capital_emprunte.Text = "Capital Emprunté";
            // 
            // textBox_capital_emprunte
            // 
            textBox_capital_emprunte.Location = new Point(213, 118);
            textBox_capital_emprunte.Name = "textBox_capital_emprunte";
            textBox_capital_emprunte.Size = new Size(150, 31);
            textBox_capital_emprunte.TabIndex = 3;
            textBox_capital_emprunte.TextAlign = HorizontalAlignment.Right;
            textBox_capital_emprunte.TextChanged += textBox_capita_emprunte_TextChanged;
            // 
            // label_Periodicite_emprunt
            // 
            label_Periodicite_emprunt.AutoSize = true;
            label_Periodicite_emprunt.Location = new Point(49, 193);
            label_Periodicite_emprunt.Name = "label_Periodicite_emprunt";
            label_Periodicite_emprunt.Size = new Size(153, 50);
            label_Periodicite_emprunt.TabIndex = 4;
            label_Periodicite_emprunt.Text = "Durée en mois du\r\nremboursement";
            // 
            // label_Duree_en_mois
            // 
            label_Duree_en_mois.AutoSize = true;
            label_Duree_en_mois.Location = new Point(236, 193);
            label_Duree_en_mois.Name = "label_Duree_en_mois";
            label_Duree_en_mois.Size = new Size(59, 25);
            label_Duree_en_mois.TabIndex = 5;
            label_Duree_en_mois.Text = "label1";
            label_Duree_en_mois.Click += label_Duree_en_mois_Click;
            // 
            // hScrollBar_duree
            // 
            hScrollBar_duree.Location = new Point(321, 193);
            hScrollBar_duree.Name = "hScrollBar_duree";
            hScrollBar_duree.Size = new Size(230, 39);
            hScrollBar_duree.TabIndex = 6;
            hScrollBar_duree.Scroll += hScrollBar_duree_Scroll;
            // 
            // label_periodicite_rembs
            // 
            label_periodicite_rembs.AutoSize = true;
            label_periodicite_rembs.Location = new Point(49, 283);
            label_periodicite_rembs.Name = "label_periodicite_rembs";
            label_periodicite_rembs.Size = new Size(250, 25);
            label_periodicite_rembs.TabIndex = 7;
            label_periodicite_rembs.Text = "Périodicité de remboursement";
            // 
            // listBox_periodicite_rembs
            // 
            listBox_periodicite_rembs.FormattingEnabled = true;
            listBox_periodicite_rembs.ItemHeight = 25;
            listBox_periodicite_rembs.Location = new Point(49, 333);
            listBox_periodicite_rembs.Name = "listBox_periodicite_rembs";
            listBox_periodicite_rembs.Size = new Size(315, 129);
            listBox_periodicite_rembs.TabIndex = 8;
            listBox_periodicite_rembs.SelectedIndexChanged += listBox_periodicite_rembs_SelectedIndexChanged;
            // 
            // label_nb_remboursements
            // 
            label_nb_remboursements.AutoSize = true;
            label_nb_remboursements.Location = new Point(493, 333);
            label_nb_remboursements.Name = "label_nb_remboursements";
            label_nb_remboursements.Size = new Size(59, 25);
            label_nb_remboursements.TabIndex = 9;
            label_nb_remboursements.Text = "label1";
            label_nb_remboursements.Click += label_nb_remboursements_Click;
            // 
            // label_remboursement
            // 
            label_remboursement.AutoSize = true;
            label_remboursement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_remboursement.Location = new Point(709, 333);
            label_remboursement.Name = "label_remboursement";
            label_remboursement.Size = new Size(213, 32);
            label_remboursement.TabIndex = 10;
            label_remboursement.Text = "Remboursements";
            // 
            // errorProvider_nom
            // 
            errorProvider_nom.ContainerControl = this;
            // 
            // errorProvider_capital
            // 
            errorProvider_capital.ContainerControl = this;
            // 
            // groupBox_taux_interet
            // 
            groupBox_taux_interet.Controls.Add(radioButton_interet_9);
            groupBox_taux_interet.Controls.Add(radioButton_interet_8);
            groupBox_taux_interet.Controls.Add(radioButton_interet_7);
            groupBox_taux_interet.Location = new Point(639, 33);
            groupBox_taux_interet.Name = "groupBox_taux_interet";
            groupBox_taux_interet.Size = new Size(154, 173);
            groupBox_taux_interet.TabIndex = 11;
            groupBox_taux_interet.TabStop = false;
            groupBox_taux_interet.Text = "Taux d'interêt";
            // 
            // radioButton_interet_9
            // 
            radioButton_interet_9.AutoSize = true;
            radioButton_interet_9.Location = new Point(41, 118);
            radioButton_interet_9.Name = "radioButton_interet_9";
            radioButton_interet_9.Size = new Size(67, 29);
            radioButton_interet_9.TabIndex = 2;
            radioButton_interet_9.TabStop = true;
            radioButton_interet_9.Text = "9 %";
            radioButton_interet_9.UseVisualStyleBackColor = true;
            radioButton_interet_9.CheckedChanged += radioButton_interet_9_CheckedChanged;
            // 
            // radioButton_interet_8
            // 
            radioButton_interet_8.AutoSize = true;
            radioButton_interet_8.Location = new Point(41, 83);
            radioButton_interet_8.Name = "radioButton_interet_8";
            radioButton_interet_8.Size = new Size(67, 29);
            radioButton_interet_8.TabIndex = 1;
            radioButton_interet_8.TabStop = true;
            radioButton_interet_8.Text = "8 %";
            radioButton_interet_8.UseVisualStyleBackColor = true;
            radioButton_interet_8.CheckedChanged += radioButton_interet_8_CheckedChanged;
            // 
            // radioButton_interet_7
            // 
            radioButton_interet_7.AutoSize = true;
            radioButton_interet_7.Location = new Point(41, 48);
            radioButton_interet_7.Name = "radioButton_interet_7";
            radioButton_interet_7.Size = new Size(67, 29);
            radioButton_interet_7.TabIndex = 0;
            radioButton_interet_7.TabStop = true;
            radioButton_interet_7.Text = "7 %";
            radioButton_interet_7.UseVisualStyleBackColor = true;
            radioButton_interet_7.CheckedChanged += radioButton_interet_7_CheckedChanged;
            radioButton_interet_7.Click += radioButton_interet_7_CheckedChanged;
            // 
            // button_ok
            // 
            button_ok.Location = new Point(834, 52);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(111, 33);
            button_ok.TabIndex = 12;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_annuler
            // 
            button_annuler.Location = new Point(834, 112);
            button_annuler.Name = "button_annuler";
            button_annuler.Size = new Size(111, 33);
            button_annuler.TabIndex = 13;
            button_annuler.Text = "Annuler";
            button_annuler.UseVisualStyleBackColor = true;
            button_annuler.Click += button_annuler_Click;
            // 
            // label_montant_remb_periodicite
            // 
            label_montant_remb_periodicite.AutoSize = true;
            label_montant_remb_periodicite.Location = new Point(780, 393);
            label_montant_remb_periodicite.Name = "label_montant_remb_periodicite";
            label_montant_remb_periodicite.Size = new Size(59, 25);
            label_montant_remb_periodicite.TabIndex = 14;
            label_montant_remb_periodicite.Text = "label1";
            label_montant_remb_periodicite.Click += label_montant_remb_periodicite_Click;
            // 
            // FormEmprunt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 530);
            Controls.Add(label_montant_remb_periodicite);
            Controls.Add(button_annuler);
            Controls.Add(button_ok);
            Controls.Add(groupBox_taux_interet);
            Controls.Add(label_remboursement);
            Controls.Add(label_nb_remboursements);
            Controls.Add(listBox_periodicite_rembs);
            Controls.Add(label_periodicite_rembs);
            Controls.Add(hScrollBar_duree);
            Controls.Add(label_Duree_en_mois);
            Controls.Add(label_Periodicite_emprunt);
            Controls.Add(textBox_capital_emprunte);
            Controls.Add(label_capital_emprunte);
            Controls.Add(textBox_nom);
            Controls.Add(label_nom);
            Name = "FormEmprunt";
            Text = "Emprunts";
            ((System.ComponentModel.ISupportInitialize)errorProvider_nom).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_capital).EndInit();
            groupBox_taux_interet.ResumeLayout(false);
            groupBox_taux_interet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nom;
        private TextBox textBox_nom;
        private Label label_capital_emprunte;
        private TextBox textBox_capital_emprunte;
        private Label label_Periodicite_emprunt;
        private Label label_Duree_en_mois;
        private HScrollBar hScrollBar_duree;
        private Label label_periodicite_rembs;
        private ListBox listBox_periodicite_rembs;
        private Label label_nb_remboursements;
        private Label label_remboursement;
        private ErrorProvider errorProvider_nom;
        private Label label_montant_remb_periodicite;
        private Button button_annuler;
        private Button button_ok;
        private GroupBox groupBox_taux_interet;
        private RadioButton radioButton_interet_9;
        private RadioButton radioButton_interet_8;
        private RadioButton radioButton_interet_7;
        private ErrorProvider errorProvider_capital;
    }
}