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
            this.components = new System.ComponentModel.Container();
            this.label_nouvel_element = new System.Windows.Forms.Label();
            this.label_lst_list = new System.Windows.Forms.Label();
            this.label_index_element = new System.Windows.Forms.Label();
            this.label_proprietes = new System.Windows.Forms.Label();
            this.labelitems_count = new System.Windows.Forms.Label();
            this.labelselected_index = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.button_ajout_liste = new System.Windows.Forms.Button();
            this.button_selectionner = new System.Windows.Forms.Button();
            this.button_vider_liste = new System.Windows.Forms.Button();
            this.TextBoxSaisieNom = new System.Windows.Forms.TextBox();
            this.textBox_index_element = new System.Windows.Forms.TextBox();
            this.textBox_items_count = new System.Windows.Forms.TextBox();
            this.textBox_selected_items = new System.Windows.Forms.TextBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.listBox_liste_de_nom = new System.Windows.Forms.ListBox();
            this.errorProvider_index_element = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_nouvel_element = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_index_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nouvel_element)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nouvel_element
            // 
            this.label_nouvel_element.AutoSize = true;
            this.label_nouvel_element.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_nouvel_element.Location = new System.Drawing.Point(12, 25);
            this.label_nouvel_element.Name = "label_nouvel_element";
            this.label_nouvel_element.Size = new System.Drawing.Size(96, 15);
            this.label_nouvel_element.TabIndex = 0;
            this.label_nouvel_element.Text = "Nouvel Elément";
            // 
            // label_lst_list
            // 
            this.label_lst_list.AutoSize = true;
            this.label_lst_list.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_lst_list.Location = new System.Drawing.Point(12, 124);
            this.label_lst_list.Name = "label_lst_list";
            this.label_lst_list.Size = new System.Drawing.Size(49, 15);
            this.label_lst_list.TabIndex = 1;
            this.label_lst_list.Text = "LstListe";
            // 
            // label_index_element
            // 
            this.label_index_element.AutoSize = true;
            this.label_index_element.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_index_element.Location = new System.Drawing.Point(227, 25);
            this.label_index_element.Name = "label_index_element";
            this.label_index_element.Size = new System.Drawing.Size(88, 15);
            this.label_index_element.TabIndex = 2;
            this.label_index_element.Text = "Index Elément";
            // 
            // label_proprietes
            // 
            this.label_proprietes.AutoSize = true;
            this.label_proprietes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_proprietes.Location = new System.Drawing.Point(227, 124);
            this.label_proprietes.Name = "label_proprietes";
            this.label_proprietes.Size = new System.Drawing.Size(65, 15);
            this.label_proprietes.TabIndex = 3;
            this.label_proprietes.Text = "Propriétés";
            // 
            // labelitems_count
            // 
            this.labelitems_count.AutoSize = true;
            this.labelitems_count.Location = new System.Drawing.Point(227, 152);
            this.labelitems_count.Name = "labelitems_count";
            this.labelitems_count.Size = new System.Drawing.Size(72, 15);
            this.labelitems_count.TabIndex = 4;
            this.labelitems_count.Text = "Items.Count";
            // 
            // labelselected_index
            // 
            this.labelselected_index.AutoSize = true;
            this.labelselected_index.Location = new System.Drawing.Point(230, 181);
            this.labelselected_index.Name = "labelselected_index";
            this.labelselected_index.Size = new System.Drawing.Size(80, 15);
            this.labelselected_index.TabIndex = 5;
            this.labelselected_index.Text = "SelectedIndex";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(230, 210);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(28, 15);
            this.label_text.TabIndex = 6;
            this.label_text.Text = "Text";
            // 
            // button_ajout_liste
            // 
            this.button_ajout_liste.Location = new System.Drawing.Point(12, 81);
            this.button_ajout_liste.Name = "button_ajout_liste";
            this.button_ajout_liste.Size = new System.Drawing.Size(158, 23);
            this.button_ajout_liste.TabIndex = 7;
            this.button_ajout_liste.Text = "Ajout Liste";
            this.button_ajout_liste.UseVisualStyleBackColor = true;
            this.button_ajout_liste.Click += new System.EventHandler(this.button_ajout_liste_Click);
            // 
            // button_selectionner
            // 
            this.button_selectionner.Location = new System.Drawing.Point(298, 43);
            this.button_selectionner.Name = "button_selectionner";
            this.button_selectionner.Size = new System.Drawing.Size(139, 23);
            this.button_selectionner.TabIndex = 8;
            this.button_selectionner.Text = "Selectionner";
            this.button_selectionner.UseVisualStyleBackColor = true;
            this.button_selectionner.Click += new System.EventHandler(this.button_selectionner_Click);
            // 
            // button_vider_liste
            // 
            this.button_vider_liste.Location = new System.Drawing.Point(298, 81);
            this.button_vider_liste.Name = "button_vider_liste";
            this.button_vider_liste.Size = new System.Drawing.Size(139, 23);
            this.button_vider_liste.TabIndex = 9;
            this.button_vider_liste.Text = "Vider la Liste";
            this.button_vider_liste.UseVisualStyleBackColor = true;
            this.button_vider_liste.Click += new System.EventHandler(this.button_vider_liste_Click);
            // 
            // TextBoxSaisieNom
            // 
            this.TextBoxSaisieNom.Location = new System.Drawing.Point(12, 43);
            this.TextBoxSaisieNom.Name = "TextBoxSaisieNom";
            this.TextBoxSaisieNom.Size = new System.Drawing.Size(158, 23);
            this.TextBoxSaisieNom.TabIndex = 10;
            this.TextBoxSaisieNom.TextChanged += new System.EventHandler(this.textBox_saisie_liste_TextChanged);
            // 
            // textBox_index_element
            // 
            this.textBox_index_element.Location = new System.Drawing.Point(227, 43);
            this.textBox_index_element.Name = "textBox_index_element";
            this.textBox_index_element.Size = new System.Drawing.Size(43, 23);
            this.textBox_index_element.TabIndex = 11;
            this.textBox_index_element.TextChanged += new System.EventHandler(this.textBox_index_element_TextChanged);
            // 
            // textBox_items_count
            // 
            this.textBox_items_count.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_items_count.Location = new System.Drawing.Point(316, 144);
            this.textBox_items_count.Name = "textBox_items_count";
            this.textBox_items_count.Size = new System.Drawing.Size(48, 23);
            this.textBox_items_count.TabIndex = 12;
            this.textBox_items_count.Text = "0";
            // 
            // textBox_selected_items
            // 
            this.textBox_selected_items.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_selected_items.Location = new System.Drawing.Point(316, 173);
            this.textBox_selected_items.Name = "textBox_selected_items";
            this.textBox_selected_items.Size = new System.Drawing.Size(48, 23);
            this.textBox_selected_items.TabIndex = 13;
            // 
            // textBox_text
            // 
            this.textBox_text.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_text.Location = new System.Drawing.Point(316, 202);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(123, 23);
            this.textBox_text.TabIndex = 16;
            // 
            // listBox_liste_de_nom
            // 
            this.listBox_liste_de_nom.FormattingEnabled = true;
            this.listBox_liste_de_nom.ItemHeight = 15;
            this.listBox_liste_de_nom.Location = new System.Drawing.Point(12, 144);
            this.listBox_liste_de_nom.Name = "listBox_liste_de_nom";
            this.listBox_liste_de_nom.Size = new System.Drawing.Size(122, 79);
            this.listBox_liste_de_nom.TabIndex = 15;
            this.listBox_liste_de_nom.SelectedIndexChanged += new System.EventHandler(this.listBox_liste_de_nom_SelectedIndexChanged);
            // 
            // errorProvider_index_element
            // 
            this.errorProvider_index_element.ContainerControl = this;
            // 
            // errorProvider_nouvel_element
            // 
            this.errorProvider_nouvel_element.ContainerControl = this;
            // 
            // FormLes_listesEtLeurPropriete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(451, 263);
            this.Controls.Add(this.listBox_liste_de_nom);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.textBox_selected_items);
            this.Controls.Add(this.textBox_items_count);
            this.Controls.Add(this.textBox_index_element);
            this.Controls.Add(this.TextBoxSaisieNom);
            this.Controls.Add(this.button_vider_liste);
            this.Controls.Add(this.button_selectionner);
            this.Controls.Add(this.button_ajout_liste);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.labelselected_index);
            this.Controls.Add(this.labelitems_count);
            this.Controls.Add(this.label_proprietes);
            this.Controls.Add(this.label_index_element);
            this.Controls.Add(this.label_lst_list);
            this.Controls.Add(this.label_nouvel_element);
            this.MaximumSize = new System.Drawing.Size(467, 302);
            this.MinimumSize = new System.Drawing.Size(467, 302);
            this.Name = "FormLes_listesEtLeurPropriete";
            this.Text = "FormLes_listesEtLeurPropriete";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_index_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nouvel_element)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox TextBoxSaisieNom;
        private TextBox textBox_index_element;
        private TextBox textBox_items_count;
        private TextBox textBox_selected_items;
        private TextBox textBox_text;
        private ListBox listBox_liste_de_nom;
        private ErrorProvider errorProvider_index_element;
        private ErrorProvider errorProvider_nouvel_element;
    }
}