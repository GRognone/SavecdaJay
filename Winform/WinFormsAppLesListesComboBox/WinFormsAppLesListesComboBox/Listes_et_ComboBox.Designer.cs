namespace WinFormsAppLesListesComboBox
{
    partial class Listes_et_ComboBox
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
            this.button_1_element_source_to_cible = new System.Windows.Forms.Button();
            this.button_All_element_source_to_cible = new System.Windows.Forms.Button();
            this.button_1_element_cible_to_source = new System.Windows.Forms.Button();
            this.button_all_element_cible_to_source = new System.Windows.Forms.Button();
            this.button_cible_selectline_up = new System.Windows.Forms.Button();
            this.button_cible_selectline_down = new System.Windows.Forms.Button();
            this.comboBox_userInput = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_source = new System.Windows.Forms.Label();
            this.label_cible = new System.Windows.Forms.Label();
            this.errorProvider_control_user_input = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_control_user_input)).BeginInit();
            this.SuspendLayout();
            // 
            // button_1_element_source_to_cible
            // 
            this.button_1_element_source_to_cible.Enabled = false;
            this.button_1_element_source_to_cible.Location = new System.Drawing.Point(139, 38);
            this.button_1_element_source_to_cible.Name = "button_1_element_source_to_cible";
            this.button_1_element_source_to_cible.Size = new System.Drawing.Size(75, 23);
            this.button_1_element_source_to_cible.TabIndex = 0;
            this.button_1_element_source_to_cible.Text = ">";
            this.button_1_element_source_to_cible.UseVisualStyleBackColor = true;
            this.button_1_element_source_to_cible.EnabledChanged += new System.EventHandler(this.comboBox_userInput_TextChanged);
            this.button_1_element_source_to_cible.Click += new System.EventHandler(this.button_1_element_source_to_cible_Click);
            // 
            // button_All_element_source_to_cible
            // 
            this.button_All_element_source_to_cible.Enabled = false;
            this.button_All_element_source_to_cible.Location = new System.Drawing.Point(139, 67);
            this.button_All_element_source_to_cible.Name = "button_All_element_source_to_cible";
            this.button_All_element_source_to_cible.Size = new System.Drawing.Size(75, 23);
            this.button_All_element_source_to_cible.TabIndex = 1;
            this.button_All_element_source_to_cible.Text = ">>";
            this.button_All_element_source_to_cible.UseVisualStyleBackColor = true;
            this.button_All_element_source_to_cible.EnabledChanged += new System.EventHandler(this.comboBox_userInput_TextChanged);
            this.button_All_element_source_to_cible.Click += new System.EventHandler(this.button_All_element_source_to_cible_Click);
            // 
            // button_1_element_cible_to_source
            // 
            this.button_1_element_cible_to_source.Enabled = false;
            this.button_1_element_cible_to_source.Location = new System.Drawing.Point(139, 134);
            this.button_1_element_cible_to_source.Name = "button_1_element_cible_to_source";
            this.button_1_element_cible_to_source.Size = new System.Drawing.Size(75, 23);
            this.button_1_element_cible_to_source.TabIndex = 2;
            this.button_1_element_cible_to_source.Text = "<";
            this.button_1_element_cible_to_source.UseVisualStyleBackColor = true;
            this.button_1_element_cible_to_source.Click += new System.EventHandler(this.button_1_element_cible_to_source_Click);
            // 
            // button_all_element_cible_to_source
            // 
            this.button_all_element_cible_to_source.Enabled = false;
            this.button_all_element_cible_to_source.Location = new System.Drawing.Point(139, 163);
            this.button_all_element_cible_to_source.Name = "button_all_element_cible_to_source";
            this.button_all_element_cible_to_source.Size = new System.Drawing.Size(75, 23);
            this.button_all_element_cible_to_source.TabIndex = 3;
            this.button_all_element_cible_to_source.Text = "<<";
            this.button_all_element_cible_to_source.UseVisualStyleBackColor = true;
            this.button_all_element_cible_to_source.Click += new System.EventHandler(this.button_all_element_cible_to_source_Click);
            // 
            // button_cible_selectline_up
            // 
            this.button_cible_selectline_up.Enabled = false;
            this.button_cible_selectline_up.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cible_selectline_up.Location = new System.Drawing.Point(253, 138);
            this.button_cible_selectline_up.Name = "button_cible_selectline_up";
            this.button_cible_selectline_up.Size = new System.Drawing.Size(23, 23);
            this.button_cible_selectline_up.TabIndex = 4;
            this.button_cible_selectline_up.Text = "↑";
            this.button_cible_selectline_up.UseVisualStyleBackColor = true;
            this.button_cible_selectline_up.Click += new System.EventHandler(this.button_cible_selectline_up_Click);
            // 
            // button_cible_selectline_down
            // 
            this.button_cible_selectline_down.Enabled = false;
            this.button_cible_selectline_down.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cible_selectline_down.Location = new System.Drawing.Point(282, 138);
            this.button_cible_selectline_down.Name = "button_cible_selectline_down";
            this.button_cible_selectline_down.Size = new System.Drawing.Size(23, 23);
            this.button_cible_selectline_down.TabIndex = 5;
            this.button_cible_selectline_down.Text = "↓";
            this.button_cible_selectline_down.UseVisualStyleBackColor = true;
            this.button_cible_selectline_down.Click += new System.EventHandler(this.button_cible_selectline_down_Click);
            // 
            // comboBox_userInput
            // 
            this.comboBox_userInput.FormattingEnabled = true;
            this.comboBox_userInput.Location = new System.Drawing.Point(12, 38);
            this.comboBox_userInput.Name = "comboBox_userInput";
            this.comboBox_userInput.Size = new System.Drawing.Size(121, 23);
            this.comboBox_userInput.TabIndex = 6;
            this.comboBox_userInput.DropDown += new System.EventHandler(this.comboBox_userInput_DropDown);
            this.comboBox_userInput.SelectedIndexChanged += new System.EventHandler(this.comboBox_userInput_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(220, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_Selected_IndexChanged);
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Location = new System.Drawing.Point(57, 9);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(39, 15);
            this.label_source.TabIndex = 8;
            this.label_source.Text = "Souce";
            // 
            // label_cible
            // 
            this.label_cible.AutoSize = true;
            this.label_cible.Location = new System.Drawing.Point(253, 9);
            this.label_cible.Name = "label_cible";
            this.label_cible.Size = new System.Drawing.Size(34, 15);
            this.label_cible.TabIndex = 9;
            this.label_cible.Text = "Cible";
            // 
            // errorProvider_control_user_input
            // 
            this.errorProvider_control_user_input.ContainerControl = this;
            this.errorProvider_control_user_input.RightToLeftChanged += new System.EventHandler(this.comboBox_userInput_TextChanged);
            // 
            // Listes_et_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 224);
            this.Controls.Add(this.label_cible);
            this.Controls.Add(this.label_source);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox_userInput);
            this.Controls.Add(this.button_cible_selectline_down);
            this.Controls.Add(this.button_cible_selectline_up);
            this.Controls.Add(this.button_all_element_cible_to_source);
            this.Controls.Add(this.button_1_element_cible_to_source);
            this.Controls.Add(this.button_All_element_source_to_cible);
            this.Controls.Add(this.button_1_element_source_to_cible);
            this.MaximumSize = new System.Drawing.Size(376, 263);
            this.MinimumSize = new System.Drawing.Size(376, 263);
            this.Name = "Listes_et_ComboBox";
            this.Text = "Listes_et_ComboBox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_control_user_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_1_element_source_to_cible;
        private Button button_All_element_source_to_cible;
        private Button button_1_element_cible_to_source;
        private Button button_all_element_cible_to_source;
        private Button button_cible_selectline_up;
        private Button button_cible_selectline_down;
        private ComboBox comboBox_userInput;
        private ListBox listBox1;
        private Label label_source;
        private Label label_cible;
        private ErrorProvider errorProvider_control_user_input;
    }
}