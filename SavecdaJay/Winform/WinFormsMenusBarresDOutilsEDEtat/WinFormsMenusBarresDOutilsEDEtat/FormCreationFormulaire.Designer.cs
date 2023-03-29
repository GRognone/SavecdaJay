namespace WinFormsMenusBarresDOutilsEDEtat
{
    partial class FormCreationFormulaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreationFormulaire));
            menuStrip1 = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            sidentifierToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            phase1ToolStripMenuItem = new ToolStripMenuItem();
            additionneurToolStripMenuItem = new ToolStripMenuItem();
            phase2ToolStripMenuItem = new ToolStripMenuItem();
            lesControlesToolStripMenuItem = new ToolStripMenuItem();
            phase3ToolStripMenuItem = new ToolStripMenuItem();
            CheckBoxToolStripMenuItem = new ToolStripMenuItem();
            opBasesListBoxToolStripMenuItem = new ToolStripMenuItem();
            listBoxEtComboBoxToolStripMenuItem = new ToolStripMenuItem();
            DefilementToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            syntheseToolStripMenuItem = new ToolStripMenuItem();
            fenêtresToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStrip1 = new ToolStrip();
            toolStripButtonSIdentifier = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSplitButtonPhase3 = new ToolStripSplitButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStrip2 = new ToolStrip();
            toolStripLabelDate = new ToolStripLabel();
            toolStripLabelDerniereOperation = new ToolStripLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, phase1ToolStripMenuItem, phase2ToolStripMenuItem, phase3ToolStripMenuItem, fenêtresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = fenêtresToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sidentifierToolStripMenuItem, toolStripSeparator1, quitterToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            sidentifierToolStripMenuItem.Size = new Size(130, 22);
            sidentifierToolStripMenuItem.Text = "S'identifier";
            sidentifierToolStripMenuItem.Click += sidentifierToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(127, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(130, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // phase1ToolStripMenuItem
            // 
            phase1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { additionneurToolStripMenuItem });
            phase1ToolStripMenuItem.Enabled = false;
            phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            phase1ToolStripMenuItem.Size = new Size(59, 20);
            phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            additionneurToolStripMenuItem.Size = new Size(144, 22);
            additionneurToolStripMenuItem.Text = "Additionneur";
            additionneurToolStripMenuItem.Click += additionneurToolStripMenuItem_Click;
            // 
            // phase2ToolStripMenuItem
            // 
            phase2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lesControlesToolStripMenuItem });
            phase2ToolStripMenuItem.Enabled = false;
            phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            phase2ToolStripMenuItem.Size = new Size(59, 20);
            phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // lesControlesToolStripMenuItem
            // 
            lesControlesToolStripMenuItem.Name = "lesControlesToolStripMenuItem";
            lesControlesToolStripMenuItem.Size = new Size(143, 22);
            lesControlesToolStripMenuItem.Text = "Les controles";
            lesControlesToolStripMenuItem.Click += lesControlesToolStripMenuItem_Click;
            // 
            // phase3ToolStripMenuItem
            // 
            phase3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CheckBoxToolStripMenuItem, opBasesListBoxToolStripMenuItem, listBoxEtComboBoxToolStripMenuItem, DefilementToolStripMenuItem, toolStripSeparator2, syntheseToolStripMenuItem });
            phase3ToolStripMenuItem.Enabled = false;
            phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            phase3ToolStripMenuItem.Size = new Size(59, 20);
            phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // CheckBoxToolStripMenuItem
            // 
            CheckBoxToolStripMenuItem.Name = "CheckBoxToolStripMenuItem";
            CheckBoxToolStripMenuItem.Size = new Size(249, 22);
            CheckBoxToolStripMenuItem.Text = "CheckBox et boutons radios";
            CheckBoxToolStripMenuItem.Click += CheckBoxToolStripMenuItem_Click;
            // 
            // opBasesListBoxToolStripMenuItem
            // 
            opBasesListBoxToolStripMenuItem.Name = "opBasesListBoxToolStripMenuItem";
            opBasesListBoxToolStripMenuItem.Size = new Size(249, 22);
            opBasesListBoxToolStripMenuItem.Text = "Operations de base sur les listBox";
            opBasesListBoxToolStripMenuItem.Click += opBasesListBoxToolStripMenuItem_Click;
            // 
            // listBoxEtComboBoxToolStripMenuItem
            // 
            listBoxEtComboBoxToolStripMenuItem.Name = "listBoxEtComboBoxToolStripMenuItem";
            listBoxEtComboBoxToolStripMenuItem.Size = new Size(249, 22);
            listBoxEtComboBoxToolStripMenuItem.Text = "ListBox et comboBox";
            listBoxEtComboBoxToolStripMenuItem.Click += listBoxEtComboBoxToolStripMenuItem_Click;
            // 
            // DefilementToolStripMenuItem
            // 
            DefilementToolStripMenuItem.Name = "DefilementToolStripMenuItem";
            DefilementToolStripMenuItem.Size = new Size(249, 22);
            DefilementToolStripMenuItem.Text = "Les composants de defilement";
            DefilementToolStripMenuItem.Click += DefilementToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(246, 6);
            // 
            // syntheseToolStripMenuItem
            // 
            syntheseToolStripMenuItem.Name = "syntheseToolStripMenuItem";
            syntheseToolStripMenuItem.Size = new Size(249, 22);
            syntheseToolStripMenuItem.Text = "Synthèse";
            syntheseToolStripMenuItem.Click += syntheseToolStripMenuItem_Click;
            // 
            // fenêtresToolStripMenuItem
            // 
            fenêtresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem, toolStripSeparator3 });
            fenêtresToolStripMenuItem.Enabled = false;
            fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            fenêtresToolStripMenuItem.Size = new Size(63, 20);
            fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(180, 22);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(180, 22);
            horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(180, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonSIdentifier, toolStripSeparator4, toolStripSplitButtonPhase3, toolStripSeparator5 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSIdentifier
            // 
            toolStripButtonSIdentifier.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSIdentifier.Image = (Image)resources.GetObject("toolStripButtonSIdentifier.Image");
            toolStripButtonSIdentifier.ImageTransparentColor = Color.Magenta;
            toolStripButtonSIdentifier.Name = "toolStripButtonSIdentifier";
            toolStripButtonSIdentifier.Size = new Size(67, 22);
            toolStripButtonSIdentifier.Text = "S'identifier";
            toolStripButtonSIdentifier.Click += toolStripButtonSIdentifier_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripSplitButtonPhase3
            // 
            toolStripSplitButtonPhase3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButtonPhase3.Enabled = false;
            toolStripSplitButtonPhase3.Image = (Image)resources.GetObject("toolStripSplitButtonPhase3.Image");
            toolStripSplitButtonPhase3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButtonPhase3.Name = "toolStripSplitButtonPhase3";
            toolStripSplitButtonPhase3.Size = new Size(63, 22);
            toolStripSplitButtonPhase3.Text = "Phase 3";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabelDate, toolStripLabelDerniereOperation });
            toolStrip2.Location = new Point(0, 425);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 25);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabelDate
            // 
            toolStripLabelDate.Name = "toolStripLabelDate";
            toolStripLabelDate.Size = new Size(86, 22);
            toolStripLabelDate.Text = "toolStripLabel1";
            // 
            // toolStripLabelDerniereOperation
            // 
            toolStripLabelDerniereOperation.Name = "toolStripLabelDerniereOperation";
            toolStripLabelDerniereOperation.Size = new Size(86, 22);
            toolStripLabelDerniereOperation.Text = "toolStripLabel2";
            // 
            // FormCreationFormulaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormCreationFormulaire";
            Text = "Creer des formulaires";
            WindowState = FormWindowState.Maximized;
            Load += FormCreationFormulaire_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem sidentifierToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem phase1ToolStripMenuItem;
        private ToolStripMenuItem phase2ToolStripMenuItem;
        private ToolStripMenuItem phase3ToolStripMenuItem;
        private ToolStripMenuItem CheckBoxToolStripMenuItem;
        private ToolStripMenuItem fenêtresToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonSIdentifier;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSplitButton toolStripSplitButtonPhase3;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabelDate;
        private ToolStripLabel toolStripLabelDerniereOperation;
        private ToolStripMenuItem opBasesListBoxToolStripMenuItem;
        private ToolStripMenuItem listBoxEtComboBoxToolStripMenuItem;
        private ToolStripMenuItem DefilementToolStripMenuItem;
        private ToolStripMenuItem additionneurToolStripMenuItem;
        private ToolStripMenuItem lesControlesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem syntheseToolStripMenuItem;
    }
}