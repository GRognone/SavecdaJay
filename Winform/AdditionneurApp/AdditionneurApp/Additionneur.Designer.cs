namespace AdditionneurApp
{
    partial class Additionneur
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
            button_vider = new Button();
            button_calculer = new Button();
            textBox_affichage = new TextBox();
            SuspendLayout();
            // 
            // button_0
            // 
            button_0.Location = new Point(12, 291);
            button_0.Name = "button_0";
            button_0.Size = new Size(100, 100);
            button_0.TabIndex = 0;
            button_0.Tag = "0";
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_All_Click;
            // 
            // button_1
            // 
            button_1.Location = new Point(118, 291);
            button_1.Name = "button_1";
            button_1.Size = new Size(100, 100);
            button_1.TabIndex = 1;
            button_1.Tag = "1";
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_All_Click;
            // 
            // button_2
            // 
            button_2.Location = new Point(224, 291);
            button_2.Name = "button_2";
            button_2.Size = new Size(100, 100);
            button_2.TabIndex = 2;
            button_2.Tag = "2";
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_All_Click;
            // 
            // button_3
            // 
            button_3.Location = new Point(331, 291);
            button_3.Name = "button_3";
            button_3.Size = new Size(100, 100);
            button_3.TabIndex = 3;
            button_3.Tag = "3";
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_All_Click;
            // 
            // button_4
            // 
            button_4.Location = new Point(437, 291);
            button_4.Name = "button_4";
            button_4.Size = new Size(100, 100);
            button_4.TabIndex = 4;
            button_4.Tag = "4";
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_All_Click;
            // 
            // button_5
            // 
            button_5.Location = new Point(12, 397);
            button_5.Name = "button_5";
            button_5.Size = new Size(100, 100);
            button_5.TabIndex = 5;
            button_5.Tag = "5";
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_All_Click;
            // 
            // button_6
            // 
            button_6.Location = new Point(118, 397);
            button_6.Name = "button_6";
            button_6.Size = new Size(100, 100);
            button_6.TabIndex = 6;
            button_6.Tag = "6";
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_All_Click;
            // 
            // button_7
            // 
            button_7.Location = new Point(224, 397);
            button_7.Name = "button_7";
            button_7.Size = new Size(100, 100);
            button_7.TabIndex = 7;
            button_7.Tag = "7";
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_All_Click;
            // 
            // button_8
            // 
            button_8.Location = new Point(330, 397);
            button_8.Name = "button_8";
            button_8.Size = new Size(100, 100);
            button_8.TabIndex = 8;
            button_8.Tag = "8";
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_All_Click;
            // 
            // button_9
            // 
            button_9.Location = new Point(436, 397);
            button_9.Name = "button_9";
            button_9.Size = new Size(100, 100);
            button_9.TabIndex = 9;
            button_9.Tag = "9";
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_All_Click;
            // 
            // button_vider
            // 
            button_vider.Location = new Point(12, 535);
            button_vider.Name = "button_vider";
            button_vider.Size = new Size(200, 50);
            button_vider.TabIndex = 10;
            button_vider.Text = "Vider";
            button_vider.UseVisualStyleBackColor = true;
            button_vider.Click += button_vider_Click;
            // 
            // button_calculer
            // 
            button_calculer.Location = new Point(317, 535);
            button_calculer.Name = "button_calculer";
            button_calculer.Size = new Size(220, 50);
            button_calculer.TabIndex = 11;
            button_calculer.Text = "Calculer";
            button_calculer.UseVisualStyleBackColor = true;
            button_calculer.Click += button_calculer_Click;
            // 
            // textBox_affichage
            // 
            textBox_affichage.Location = new Point(12, 12);
            textBox_affichage.Multiline = true;
            textBox_affichage.Name = "textBox_affichage";
            textBox_affichage.ScrollBars = ScrollBars.Vertical;
            textBox_affichage.Size = new Size(524, 239);
            textBox_affichage.TabIndex = 12;
            // 
            // Additionneur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(549, 608);
            Controls.Add(textBox_affichage);
            Controls.Add(button_calculer);
            Controls.Add(button_vider);
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
            MaximumSize = new Size(571, 664);
            MinimumSize = new Size(571, 664);
            Name = "Additionneur";
            Text = "Additionneur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button_vider;
        private Button button_calculer;
        private TextBox textBox_affichage;
    }
}