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
            components = new System.ComponentModel.Container();
            button_1_element_source_to_cible = new Button();
            button_all_element_source_to_cible = new Button();
            button_1_element_cible_to_source = new Button();
            button_all_element_cible_to_source = new Button();
            button_cible_selectline_up = new Button();
            button_cible_selectline_down = new Button();
            comboBox_userInput = new ComboBox();
            listBox1 = new ListBox();
            label_source = new Label();
            label_cible = new Label();
            errorProvider_control_user_input = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider_control_user_input).BeginInit();
            SuspendLayout();
            // 
            // button_1_element_source_to_cible
            // 
            button_1_element_source_to_cible.Enabled = false;
            button_1_element_source_to_cible.Location = new Point(139, 38);
            button_1_element_source_to_cible.Name = "button_1_element_source_to_cible";
            button_1_element_source_to_cible.Size = new Size(75, 23);
            button_1_element_source_to_cible.TabIndex = 0;
            button_1_element_source_to_cible.Text = ">";
            button_1_element_source_to_cible.UseVisualStyleBackColor = true;
            button_1_element_source_to_cible.EnabledChanged += comboBox_userInput_TextChanged;
            button_1_element_source_to_cible.Click += button_1_element_source_to_cible_Click;
            // 
            // button_all_element_source_to_cible
            // 
            button_all_element_source_to_cible.Enabled = false;
            button_all_element_source_to_cible.Location = new Point(139, 67);
            button_all_element_source_to_cible.Name = "button_all_element_source_to_cible";
            button_all_element_source_to_cible.Size = new Size(75, 23);
            button_all_element_source_to_cible.TabIndex = 1;
            button_all_element_source_to_cible.Text = ">>";
            button_all_element_source_to_cible.UseVisualStyleBackColor = true;
            button_all_element_source_to_cible.EnabledChanged += comboBox_userInput_TextChanged;
            button_all_element_source_to_cible.Click += button_all_element_source_to_cible_Click;
            // 
            // button_1_element_cible_to_source
            // 
            button_1_element_cible_to_source.Enabled = false;
            button_1_element_cible_to_source.Location = new Point(139, 134);
            button_1_element_cible_to_source.Name = "button_1_element_cible_to_source";
            button_1_element_cible_to_source.Size = new Size(75, 23);
            button_1_element_cible_to_source.TabIndex = 2;
            button_1_element_cible_to_source.Text = "<";
            button_1_element_cible_to_source.UseVisualStyleBackColor = true;
            button_1_element_cible_to_source.Click += button_1_element_cible_to_source_Click;
            // 
            // button_all_element_cible_to_source
            // 
            button_all_element_cible_to_source.Enabled = false;
            button_all_element_cible_to_source.Location = new Point(139, 163);
            button_all_element_cible_to_source.Name = "button_all_element_cible_to_source";
            button_all_element_cible_to_source.Size = new Size(75, 23);
            button_all_element_cible_to_source.TabIndex = 3;
            button_all_element_cible_to_source.Text = "<<";
            button_all_element_cible_to_source.UseVisualStyleBackColor = true;
            button_all_element_cible_to_source.Click += button_all_element_cible_to_source_Click;
            // 
            // button_cible_selectline_up
            // 
            button_cible_selectline_up.Enabled = false;
            button_cible_selectline_up.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_cible_selectline_up.Location = new Point(253, 138);
            button_cible_selectline_up.Name = "button_cible_selectline_up";
            button_cible_selectline_up.Size = new Size(23, 23);
            button_cible_selectline_up.TabIndex = 4;
            button_cible_selectline_up.Text = "↑";
            button_cible_selectline_up.UseVisualStyleBackColor = true;
            button_cible_selectline_up.Click += button_cible_selectline_up_Click;
            // 
            // button_cible_selectline_down
            // 
            button_cible_selectline_down.Enabled = false;
            button_cible_selectline_down.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_cible_selectline_down.Location = new Point(282, 138);
            button_cible_selectline_down.Name = "button_cible_selectline_down";
            button_cible_selectline_down.Size = new Size(23, 23);
            button_cible_selectline_down.TabIndex = 5;
            button_cible_selectline_down.Text = "↓";
            button_cible_selectline_down.UseVisualStyleBackColor = true;
            button_cible_selectline_down.Click += button_cible_selectline_down_Click;
            // 
            // comboBox_userInput
            // 
            comboBox_userInput.FormattingEnabled = true;
            comboBox_userInput.Location = new Point(12, 38);
            comboBox_userInput.Name = "comboBox_userInput";
            comboBox_userInput.Size = new Size(121, 23);
            comboBox_userInput.TabIndex = 6;
            comboBox_userInput.DropDown += comboBox_userInput_DropDown;
            comboBox_userInput.SelectedIndexChanged += comboBox_userInput_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(220, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_Selected_IndexChanged;
            // 
            // label_source
            // 
            label_source.AutoSize = true;
            label_source.Location = new Point(57, 9);
            label_source.Name = "label_source";
            label_source.Size = new Size(39, 15);
            label_source.TabIndex = 8;
            label_source.Text = "Souce";
            // 
            // label_cible
            // 
            label_cible.AutoSize = true;
            label_cible.Location = new Point(253, 9);
            label_cible.Name = "label_cible";
            label_cible.Size = new Size(34, 15);
            label_cible.TabIndex = 9;
            label_cible.Text = "Cible";
            // 
            // errorProvider_control_user_input
            // 
            errorProvider_control_user_input.ContainerControl = this;
            errorProvider_control_user_input.RightToLeftChanged += comboBox_userInput_TextChanged;
            // 
            // Listes_et_ComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 224);
            Controls.Add(label_cible);
            Controls.Add(label_source);
            Controls.Add(listBox1);
            Controls.Add(comboBox_userInput);
            Controls.Add(button_cible_selectline_down);
            Controls.Add(button_cible_selectline_up);
            Controls.Add(button_all_element_cible_to_source);
            Controls.Add(button_1_element_cible_to_source);
            Controls.Add(button_all_element_source_to_cible);
            Controls.Add(button_1_element_source_to_cible);
            MaximumSize = new Size(376, 263);
            MinimumSize = new Size(376, 263);
            Name = "Listes_et_ComboBox";
            Text = "Listes_et_ComboBox";
            ((System.ComponentModel.ISupportInitialize)errorProvider_control_user_input).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button button_all_element_source_to_cible;
    }
}