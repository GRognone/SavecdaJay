namespace WinFormsAdditionneurMetier
{
    partial class FormAdditionneur
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
            textBox_Affichage = new TextBox();
            button_0 = new Button();
            button_1 = new Button();
            button_2 = new Button();
            button_3 = new Button();
            button_4 = new Button();
            button_5 = new Button();
            button_6 = new Button();
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            button_Vider = new Button();
            button_Calculer = new Button();
            SuspendLayout();
            // 
            // textBox_Affichage
            // 
            textBox_Affichage.Location = new Point(12, 25);
            textBox_Affichage.Multiline = true;
            textBox_Affichage.Name = "textBox_Affichage";
            textBox_Affichage.Size = new Size(399, 155);
            textBox_Affichage.TabIndex = 0;
            // 
            // button_0
            // 
            button_0.Location = new Point(11, 208);
            button_0.Name = "button_0";
            button_0.Size = new Size(75, 75);
            button_0.TabIndex = 1;
            button_0.Tag = "0";
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_all_Click;
            // 
            // button_1
            // 
            button_1.Location = new Point(92, 208);
            button_1.Name = "button_1";
            button_1.Size = new Size(75, 75);
            button_1.TabIndex = 2;
            button_1.Tag = "1";
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_all_Click;
            // 
            // button_2
            // 
            button_2.Location = new Point(173, 208);
            button_2.Name = "button_2";
            button_2.Size = new Size(75, 75);
            button_2.TabIndex = 3;
            button_2.Tag = "2";
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_all_Click;
            // 
            // button_3
            // 
            button_3.Location = new Point(254, 208);
            button_3.Name = "button_3";
            button_3.Size = new Size(75, 75);
            button_3.TabIndex = 4;
            button_3.Tag = "3";
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_all_Click;
            // 
            // button_4
            // 
            button_4.Location = new Point(335, 208);
            button_4.Name = "button_4";
            button_4.Size = new Size(75, 75);
            button_4.TabIndex = 5;
            button_4.Tag = "4";
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_all_Click;
            // 
            // button_5
            // 
            button_5.Location = new Point(11, 289);
            button_5.Name = "button_5";
            button_5.Size = new Size(75, 75);
            button_5.TabIndex = 6;
            button_5.Tag = "5";
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_all_Click;
            // 
            // button_6
            // 
            button_6.Location = new Point(92, 289);
            button_6.Name = "button_6";
            button_6.Size = new Size(75, 75);
            button_6.TabIndex = 7;
            button_6.Tag = "6";
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_all_Click;
            // 
            // button_7
            // 
            button_7.Location = new Point(173, 289);
            button_7.Name = "button_7";
            button_7.Size = new Size(75, 75);
            button_7.TabIndex = 8;
            button_7.Tag = "7";
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_all_Click;
            // 
            // button_8
            // 
            button_8.Location = new Point(254, 289);
            button_8.Name = "button_8";
            button_8.Size = new Size(75, 75);
            button_8.TabIndex = 9;
            button_8.Tag = "8";
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_all_Click;
            // 
            // button_9
            // 
            button_9.Location = new Point(335, 289);
            button_9.Name = "button_9";
            button_9.Size = new Size(75, 75);
            button_9.TabIndex = 10;
            button_9.Tag = "9";
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_all_Click;
            // 
            // button_Vider
            // 
            button_Vider.Location = new Point(11, 370);
            button_Vider.Name = "button_Vider";
            button_Vider.Size = new Size(156, 37);
            button_Vider.TabIndex = 11;
            button_Vider.Text = "Vider";
            button_Vider.UseVisualStyleBackColor = true;
            button_Vider.Click += button_Vider_Click;
            // 
            // button_Calculer
            // 
            button_Calculer.Location = new Point(254, 370);
            button_Calculer.Name = "button_Calculer";
            button_Calculer.Size = new Size(156, 37);
            button_Calculer.TabIndex = 12;
            button_Calculer.Text = "Calculer";
            button_Calculer.UseVisualStyleBackColor = true;
            button_Calculer.Click += button_Calculer_Click;
            // 
            // FormAdditionneur
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 426);
            Controls.Add(button_Calculer);
            Controls.Add(button_Vider);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(button_0);
            Controls.Add(textBox_Affichage);
            Name = "FormAdditionneur";
            Text = "Additionneur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Affichage;
        private Button button_0;
        private Button button_1;
        private Button button_2;
        private Button button_3;
        private Button button_4;
        private Button button_5;
        private Button button_6;
        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_Vider;
        private Button button_Calculer;
    }
}