namespace WinFormsOperationBaseListBox
{
    partial class FormLes_listesEtLeurPropriete
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
            label_nouvel_element = new Label();
            label_lst_list = new Label();
            label_index_element = new Label();
            label_proprietes = new Label();
            labelitems_count = new Label();
            labelselected_index = new Label();
            label_text = new Label();
            button_ajout_liste = new Button();
            button_selectionner = new Button();
            button_vider_liste = new Button();
            textBox_saisie_liste = new TextBox();
            textBox_index_element = new TextBox();
            textBox_items_count = new TextBox();
            textBox_selected_items = new TextBox();
            textBox_text = new TextBox();
            listBox_liste_de_nom = new ListBox();
            errorProvider_index_element = new ErrorProvider(components);
            errorProvider_nouvel_element = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider_index_element).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nouvel_element).BeginInit();
            SuspendLayout();
            // 
            // label_nouvel_element
            // 
            label_nouvel_element.AutoSize = true;
            label_nouvel_element.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_nouvel_element.Location = new Point(17, 42);
            label_nouvel_element.Margin = new Padding(4, 0, 4, 0);
            label_nouvel_element.Name = "label_nouvel_element";
            label_nouvel_element.Size = new Size(147, 25);
            label_nouvel_element.TabIndex = 0;
            label_nouvel_element.Text = "Nouvel Elément";
            // 
            // label_lst_list
            // 
            label_lst_list.AutoSize = true;
            label_lst_list.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_lst_list.Location = new Point(17, 207);
            label_lst_list.Margin = new Padding(4, 0, 4, 0);
            label_lst_list.Name = "label_lst_list";
            label_lst_list.Size = new Size(75, 25);
            label_lst_list.TabIndex = 1;
            label_lst_list.Text = "LstListe";
            // 
            // label_index_element
            // 
            label_index_element.AutoSize = true;
            label_index_element.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_index_element.Location = new Point(324, 42);
            label_index_element.Margin = new Padding(4, 0, 4, 0);
            label_index_element.Name = "label_index_element";
            label_index_element.Size = new Size(134, 25);
            label_index_element.TabIndex = 2;
            label_index_element.Text = "Index Elément";
            // 
            // label_proprietes
            // 
            label_proprietes.AutoSize = true;
            label_proprietes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_proprietes.Location = new Point(324, 207);
            label_proprietes.Margin = new Padding(4, 0, 4, 0);
            label_proprietes.Name = "label_proprietes";
            label_proprietes.Size = new Size(99, 25);
            label_proprietes.TabIndex = 3;
            label_proprietes.Text = "Propriétés";
            // 
            // labelitems_count
            // 
            labelitems_count.AutoSize = true;
            labelitems_count.Location = new Point(324, 253);
            labelitems_count.Margin = new Padding(4, 0, 4, 0);
            labelitems_count.Name = "labelitems_count";
            labelitems_count.Size = new Size(108, 25);
            labelitems_count.TabIndex = 4;
            labelitems_count.Text = "Items.Count";
            // 
            // labelselected_index
            // 
            labelselected_index.AutoSize = true;
            labelselected_index.Location = new Point(329, 302);
            labelselected_index.Margin = new Padding(4, 0, 4, 0);
            labelselected_index.Name = "labelselected_index";
            labelselected_index.Size = new Size(121, 25);
            labelselected_index.TabIndex = 5;
            labelselected_index.Text = "SelectedIndex";
            // 
            // label_text
            // 
            label_text.AutoSize = true;
            label_text.Location = new Point(329, 350);
            label_text.Margin = new Padding(4, 0, 4, 0);
            label_text.Name = "label_text";
            label_text.Size = new Size(42, 25);
            label_text.TabIndex = 6;
            label_text.Text = "Text";
            // 
            // button_ajout_liste
            // 
            button_ajout_liste.Location = new Point(17, 135);
            button_ajout_liste.Margin = new Padding(4, 5, 4, 5);
            button_ajout_liste.Name = "button_ajout_liste";
            button_ajout_liste.Size = new Size(226, 38);
            button_ajout_liste.TabIndex = 7;
            button_ajout_liste.Text = "Ajout Liste";
            button_ajout_liste.UseVisualStyleBackColor = true;
            button_ajout_liste.Click += button_ajout_liste_Click;
            // 
            // button_selectionner
            // 
            button_selectionner.Location = new Point(426, 72);
            button_selectionner.Margin = new Padding(4, 5, 4, 5);
            button_selectionner.Name = "button_selectionner";
            button_selectionner.Size = new Size(199, 38);
            button_selectionner.TabIndex = 8;
            button_selectionner.Text = "Selectionner";
            button_selectionner.UseVisualStyleBackColor = true;
            button_selectionner.Click += button_selectionner_Click;
            // 
            // button_vider_liste
            // 
            button_vider_liste.Location = new Point(426, 135);
            button_vider_liste.Margin = new Padding(4, 5, 4, 5);
            button_vider_liste.Name = "button_vider_liste";
            button_vider_liste.Size = new Size(199, 38);
            button_vider_liste.TabIndex = 9;
            button_vider_liste.Text = "Vider la Liste";
            button_vider_liste.UseVisualStyleBackColor = true;
            button_vider_liste.Click += button_vider_liste_Click;
            // 
            // textBox_saisie_liste
            // 
            textBox_saisie_liste.Location = new Point(17, 72);
            textBox_saisie_liste.Margin = new Padding(4, 5, 4, 5);
            textBox_saisie_liste.Name = "textBox_saisie_liste";
            textBox_saisie_liste.Size = new Size(224, 31);
            textBox_saisie_liste.TabIndex = 10;
            textBox_saisie_liste.TextChanged += textBox_saisie_liste_TextChanged;
            // 
            // textBox_index_element
            // 
            textBox_index_element.Location = new Point(324, 72);
            textBox_index_element.Margin = new Padding(4, 5, 4, 5);
            textBox_index_element.Name = "textBox_index_element";
            textBox_index_element.Size = new Size(60, 31);
            textBox_index_element.TabIndex = 11;
            textBox_index_element.TextChanged += textBox_index_element_TextChanged;
            // 
            // textBox_items_count
            // 
            textBox_items_count.BackColor = SystemColors.ScrollBar;
            textBox_items_count.Location = new Point(451, 240);
            textBox_items_count.Margin = new Padding(4, 5, 4, 5);
            textBox_items_count.Name = "textBox_items_count";
            textBox_items_count.Size = new Size(67, 31);
            textBox_items_count.TabIndex = 12;
            // 
            // textBox_selected_items
            // 
            textBox_selected_items.BackColor = SystemColors.ScrollBar;
            textBox_selected_items.Location = new Point(451, 288);
            textBox_selected_items.Margin = new Padding(4, 5, 4, 5);
            textBox_selected_items.Name = "textBox_selected_items";
            textBox_selected_items.Size = new Size(67, 31);
            textBox_selected_items.TabIndex = 13;
            // 
            // textBox_text
            // 
            textBox_text.BackColor = SystemColors.ScrollBar;
            textBox_text.Location = new Point(451, 337);
            textBox_text.Margin = new Padding(4, 5, 4, 5);
            textBox_text.Name = "textBox_text";
            textBox_text.Size = new Size(174, 31);
            textBox_text.TabIndex = 16;
            // 
            // listBox_liste_de_nom
            // 
            listBox_liste_de_nom.FormattingEnabled = true;
            listBox_liste_de_nom.ItemHeight = 25;
            listBox_liste_de_nom.Location = new Point(17, 240);
            listBox_liste_de_nom.Margin = new Padding(4, 5, 4, 5);
            listBox_liste_de_nom.Name = "listBox_liste_de_nom";
            listBox_liste_de_nom.Size = new Size(173, 129);
            listBox_liste_de_nom.TabIndex = 15;
            listBox_liste_de_nom.SelectedIndexChanged += listBox_liste_de_nom_SelectedIndexChanged;
            // 
            // errorProvider_index_element
            // 
            errorProvider_index_element.ContainerControl = this;
            // 
            // errorProvider_nouvel_element
            // 
            errorProvider_nouvel_element.ContainerControl = this;
            // 
            // FormLes_listesEtLeurPropriete
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(638, 422);
            Controls.Add(listBox_liste_de_nom);
            Controls.Add(textBox_text);
            Controls.Add(textBox_selected_items);
            Controls.Add(textBox_items_count);
            Controls.Add(textBox_index_element);
            Controls.Add(textBox_saisie_liste);
            Controls.Add(button_vider_liste);
            Controls.Add(button_selectionner);
            Controls.Add(button_ajout_liste);
            Controls.Add(label_text);
            Controls.Add(labelselected_index);
            Controls.Add(labelitems_count);
            Controls.Add(label_proprietes);
            Controls.Add(label_index_element);
            Controls.Add(label_lst_list);
            Controls.Add(label_nouvel_element);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(660, 478);
            MinimumSize = new Size(660, 478);
            Name = "FormLes_listesEtLeurPropriete";
            Text = "FormLes_listesEtLeurPropriete";
            Load += FormLes_listesEtLeurPropriete_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider_index_element).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nouvel_element).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nouvel_element;
        private Label label_lst_list;
        private Label label_index_element;
        private Label label_proprietes;
        private Label labelitems_count;
        private Label labelselected_index;
        private Label label_text;
        private Button button_ajout_liste;
        private Button button_selectionner;
        private Button button_vider_liste;
        private TextBox textBox_saisie_liste;
        private TextBox textBox_index_element;
        private TextBox textBox_items_count;
        private TextBox textBox_selected_items;
        private TextBox textBox_text;
        private ListBox listBox_liste_de_nom;
        private ErrorProvider errorProvider_index_element;
        private ErrorProvider errorProvider_nouvel_element;
    }
}