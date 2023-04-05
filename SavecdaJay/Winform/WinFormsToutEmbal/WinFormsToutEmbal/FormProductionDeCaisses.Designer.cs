namespace WinFormsToutEmbal
{
    partial class FormProductionDeCaisses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductionDeCaisses));
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            productionToolStripMenuItem = new ToolStripMenuItem();
            démarrerToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            bToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            arrêterToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem1 = new ToolStripMenuItem();
            bToolStripMenuItem1 = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            continuerToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem2 = new ToolStripMenuItem();
            bToolStripMenuItem2 = new ToolStripMenuItem();
            cToolStripMenuItem2 = new ToolStripMenuItem();
            progressBarProductionA = new ProgressBar();
            labelProductionA = new Label();
            labelProductionB = new Label();
            progressBarProductionB = new ProgressBar();
            labelProductionC = new Label();
            progressBar1 = new ProgressBar();
            toolStrip1 = new ToolStrip();
            toolStripLabelCaisseA = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabelCaisseB = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabelCaisseC = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripLabelDateTime = new ToolStripLabel();
            tabControl = new TabControl();
            tabPageTypeA = new TabPage();
            textBoxDefautDepuisDemA = new TextBox();
            textBoxTauxDéfautA = new TextBox();
            textBoxNbCaisseProdDemA = new TextBox();
            labelTauxDefautDepuisDemarrageA = new Label();
            labelTauxDefautA = new Label();
            labelNbCaisseProduiteA = new Label();
            tabPage2 = new TabPage();
            textBoxDefautDepuisDemB = new TextBox();
            textBoxTauxDéfautB = new TextBox();
            textBoxNbCaisseProdDemB = new TextBox();
            labelTauxDefautDepuisDemarrageB = new Label();
            labelTauxDefautB = new Label();
            labelNbCaisseProduiteB = new Label();
            TabPage3 = new TabPage();
            textBoxDefautDepuisDemC = new TextBox();
            textBoxTauxDéfautC = new TextBox();
            textBoxNbCaisseProdDemC = new TextBox();
            labelTauxDefautDepuisDemarrageC = new Label();
            labelTauxDefautC = new Label();
            labelNbCaisseProduiteC = new Label();
            buttonSuspenduA = new Button();
            buttonRelancerA = new Button();
            buttonRelancerC = new Button();
            buttonSuspenduC = new Button();
            buttonDemarrerC = new Button();
            buttonSuspenduB = new Button();
            buttonRelancerB = new Button();
            buttonDemarrerB = new Button();
            buttonDemarrerA = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageTypeA.SuspendLayout();
            tabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, productionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(615, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 20);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(111, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // productionToolStripMenuItem
            // 
            productionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { démarrerToolStripMenuItem, arrêterToolStripMenuItem, continuerToolStripMenuItem });
            productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            productionToolStripMenuItem.Size = new Size(78, 20);
            productionToolStripMenuItem.Text = "Production";
            // 
            // démarrerToolStripMenuItem
            // 
            démarrerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, bToolStripMenuItem, cToolStripMenuItem });
            démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            démarrerToolStripMenuItem.Size = new Size(127, 22);
            démarrerToolStripMenuItem.Text = "Démarrer";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(82, 22);
            aToolStripMenuItem.Text = "A";
            // 
            // bToolStripMenuItem
            // 
            bToolStripMenuItem.Name = "bToolStripMenuItem";
            bToolStripMenuItem.Size = new Size(82, 22);
            bToolStripMenuItem.Text = "B";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(82, 22);
            cToolStripMenuItem.Text = "C";
            // 
            // arrêterToolStripMenuItem
            // 
            arrêterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem1, bToolStripMenuItem1, cToolStripMenuItem1 });
            arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            arrêterToolStripMenuItem.Size = new Size(127, 22);
            arrêterToolStripMenuItem.Text = "Arrêter";
            // 
            // aToolStripMenuItem1
            // 
            aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            aToolStripMenuItem1.Size = new Size(82, 22);
            aToolStripMenuItem1.Text = "A";
            // 
            // bToolStripMenuItem1
            // 
            bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            bToolStripMenuItem1.Size = new Size(82, 22);
            bToolStripMenuItem1.Text = "B";
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(82, 22);
            cToolStripMenuItem1.Text = "C";
            // 
            // continuerToolStripMenuItem
            // 
            continuerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem2, bToolStripMenuItem2, cToolStripMenuItem2 });
            continuerToolStripMenuItem.Name = "continuerToolStripMenuItem";
            continuerToolStripMenuItem.Size = new Size(127, 22);
            continuerToolStripMenuItem.Text = "Continuer";
            // 
            // aToolStripMenuItem2
            // 
            aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            aToolStripMenuItem2.Size = new Size(82, 22);
            aToolStripMenuItem2.Text = "A";
            // 
            // bToolStripMenuItem2
            // 
            bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            bToolStripMenuItem2.Size = new Size(82, 22);
            bToolStripMenuItem2.Text = "B";
            // 
            // cToolStripMenuItem2
            // 
            cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            cToolStripMenuItem2.Size = new Size(82, 22);
            cToolStripMenuItem2.Text = "C";
            // 
            // progressBarProductionA
            // 
            progressBarProductionA.Location = new Point(130, 325);
            progressBarProductionA.Maximum = 10000;
            progressBarProductionA.Name = "progressBarProductionA";
            progressBarProductionA.Size = new Size(429, 23);
            progressBarProductionA.TabIndex = 1;
            // 
            // labelProductionA
            // 
            labelProductionA.AutoSize = true;
            labelProductionA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductionA.Location = new Point(37, 333);
            labelProductionA.Name = "labelProductionA";
            labelProductionA.Size = new Size(79, 15);
            labelProductionA.TabIndex = 2;
            labelProductionA.Text = "Production A";
            // 
            // labelProductionB
            // 
            labelProductionB.AutoSize = true;
            labelProductionB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductionB.Location = new Point(38, 382);
            labelProductionB.Name = "labelProductionB";
            labelProductionB.Size = new Size(79, 15);
            labelProductionB.TabIndex = 3;
            labelProductionB.Text = "Production B";
            // 
            // progressBarProductionB
            // 
            progressBarProductionB.Location = new Point(130, 374);
            progressBarProductionB.Maximum = 25000;
            progressBarProductionB.Name = "progressBarProductionB";
            progressBarProductionB.Size = new Size(429, 23);
            progressBarProductionB.TabIndex = 4;
            // 
            // labelProductionC
            // 
            labelProductionC.AutoSize = true;
            labelProductionC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductionC.Location = new Point(37, 429);
            labelProductionC.Name = "labelProductionC";
            labelProductionC.Size = new Size(78, 15);
            labelProductionC.TabIndex = 5;
            labelProductionC.Text = "Production C";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(130, 421);
            progressBar1.Maximum = 120000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(429, 23);
            progressBar1.TabIndex = 6;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelCaisseA, toolStripSeparator2, toolStripLabelCaisseB, toolStripSeparator1, toolStripLabelCaisseC, toolStripSeparator3, toolStripLabelDateTime });
            toolStrip1.Location = new Point(0, 481);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(615, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelCaisseA
            // 
            toolStripLabelCaisseA.AutoSize = false;
            toolStripLabelCaisseA.Name = "toolStripLabelCaisseA";
            toolStripLabelCaisseA.Size = new Size(160, 22);
            toolStripLabelCaisseA.Text = "toolStripLabel1";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabelCaisseB
            // 
            toolStripLabelCaisseB.AutoSize = false;
            toolStripLabelCaisseB.Name = "toolStripLabelCaisseB";
            toolStripLabelCaisseB.Size = new Size(160, 22);
            toolStripLabelCaisseB.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabelCaisseC
            // 
            toolStripLabelCaisseC.AutoSize = false;
            toolStripLabelCaisseC.Name = "toolStripLabelCaisseC";
            toolStripLabelCaisseC.Size = new Size(160, 22);
            toolStripLabelCaisseC.Text = "toolStripLabel1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripLabelDateTime
            // 
            toolStripLabelDateTime.AutoSize = false;
            toolStripLabelDateTime.Name = "toolStripLabelDateTime";
            toolStripLabelDateTime.Size = new Size(80, 22);
            toolStripLabelDateTime.Text = "toolStripLabel1";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageTypeA);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(TabPage3);
            tabControl.Location = new Point(130, 159);
            tabControl.Margin = new Padding(3, 0, 3, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(429, 127);
            tabControl.TabIndex = 8;
            // 
            // tabPageTypeA
            // 
            tabPageTypeA.Controls.Add(textBoxDefautDepuisDemA);
            tabPageTypeA.Controls.Add(textBoxTauxDéfautA);
            tabPageTypeA.Controls.Add(textBoxNbCaisseProdDemA);
            tabPageTypeA.Controls.Add(labelTauxDefautDepuisDemarrageA);
            tabPageTypeA.Controls.Add(labelTauxDefautA);
            tabPageTypeA.Controls.Add(labelNbCaisseProduiteA);
            tabPageTypeA.Location = new Point(4, 24);
            tabPageTypeA.Name = "tabPageTypeA";
            tabPageTypeA.Padding = new Padding(3);
            tabPageTypeA.Size = new Size(421, 99);
            tabPageTypeA.TabIndex = 0;
            tabPageTypeA.Text = "Type A";
            tabPageTypeA.UseVisualStyleBackColor = true;
            // 
            // textBoxDefautDepuisDemA
            // 
            textBoxDefautDepuisDemA.Location = new Point(340, 67);
            textBoxDefautDepuisDemA.Name = "textBoxDefautDepuisDemA";
            textBoxDefautDepuisDemA.ReadOnly = true;
            textBoxDefautDepuisDemA.Size = new Size(75, 23);
            textBoxDefautDepuisDemA.TabIndex = 5;
            // 
            // textBoxTauxDéfautA
            // 
            textBoxTauxDéfautA.Location = new Point(340, 38);
            textBoxTauxDéfautA.Name = "textBoxTauxDéfautA";
            textBoxTauxDéfautA.ReadOnly = true;
            textBoxTauxDéfautA.Size = new Size(75, 23);
            textBoxTauxDéfautA.TabIndex = 4;
            // 
            // textBoxNbCaisseProdDemA
            // 
            textBoxNbCaisseProdDemA.Location = new Point(340, 9);
            textBoxNbCaisseProdDemA.Name = "textBoxNbCaisseProdDemA";
            textBoxNbCaisseProdDemA.ReadOnly = true;
            textBoxNbCaisseProdDemA.Size = new Size(75, 23);
            textBoxNbCaisseProdDemA.TabIndex = 3;
            // 
            // labelTauxDefautDepuisDemarrageA
            // 
            labelTauxDefautDepuisDemarrageA.AutoSize = true;
            labelTauxDefautDepuisDemarrageA.Location = new Point(13, 75);
            labelTauxDefautDepuisDemarrageA.Name = "labelTauxDefautDepuisDemarrageA";
            labelTauxDefautDepuisDemarrageA.Size = new Size(166, 15);
            labelTauxDefautDepuisDemarrageA.TabIndex = 2;
            labelTauxDefautDepuisDemarrageA.Text = "Taux défaut depuis démarrage";
            // 
            // labelTauxDefautA
            // 
            labelTauxDefautA.AutoSize = true;
            labelTauxDefautA.Location = new Point(13, 46);
            labelTauxDefautA.Name = "labelTauxDefautA";
            labelTauxDefautA.Size = new Size(101, 15);
            labelTauxDefautA.TabIndex = 1;
            labelTauxDefautA.Text = "Taux défaut heure";
            // 
            // labelNbCaisseProduiteA
            // 
            labelNbCaisseProduiteA.AutoSize = true;
            labelNbCaisseProduiteA.Location = new Point(13, 17);
            labelNbCaisseProduiteA.Name = "labelNbCaisseProduiteA";
            labelNbCaisseProduiteA.Size = new Size(216, 15);
            labelNbCaisseProduiteA.TabIndex = 0;
            labelNbCaisseProduiteA.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxDefautDepuisDemB);
            tabPage2.Controls.Add(textBoxTauxDéfautB);
            tabPage2.Controls.Add(textBoxNbCaisseProdDemB);
            tabPage2.Controls.Add(labelTauxDefautDepuisDemarrageB);
            tabPage2.Controls.Add(labelTauxDefautB);
            tabPage2.Controls.Add(labelNbCaisseProduiteB);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(421, 99);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Type B";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxDefautDepuisDemB
            // 
            textBoxDefautDepuisDemB.Location = new Point(340, 67);
            textBoxDefautDepuisDemB.Name = "textBoxDefautDepuisDemB";
            textBoxDefautDepuisDemB.ReadOnly = true;
            textBoxDefautDepuisDemB.Size = new Size(75, 23);
            textBoxDefautDepuisDemB.TabIndex = 5;
            // 
            // textBoxTauxDéfautB
            // 
            textBoxTauxDéfautB.Location = new Point(340, 38);
            textBoxTauxDéfautB.Name = "textBoxTauxDéfautB";
            textBoxTauxDéfautB.ReadOnly = true;
            textBoxTauxDéfautB.Size = new Size(75, 23);
            textBoxTauxDéfautB.TabIndex = 4;
            // 
            // textBoxNbCaisseProdDemB
            // 
            textBoxNbCaisseProdDemB.Location = new Point(340, 9);
            textBoxNbCaisseProdDemB.Name = "textBoxNbCaisseProdDemB";
            textBoxNbCaisseProdDemB.ReadOnly = true;
            textBoxNbCaisseProdDemB.Size = new Size(75, 23);
            textBoxNbCaisseProdDemB.TabIndex = 3;
            // 
            // labelTauxDefautDepuisDemarrageB
            // 
            labelTauxDefautDepuisDemarrageB.AutoSize = true;
            labelTauxDefautDepuisDemarrageB.Location = new Point(13, 75);
            labelTauxDefautDepuisDemarrageB.Name = "labelTauxDefautDepuisDemarrageB";
            labelTauxDefautDepuisDemarrageB.Size = new Size(166, 15);
            labelTauxDefautDepuisDemarrageB.TabIndex = 2;
            labelTauxDefautDepuisDemarrageB.Text = "Taux défaut depuis démarrage";
            // 
            // labelTauxDefautB
            // 
            labelTauxDefautB.AutoSize = true;
            labelTauxDefautB.Location = new Point(13, 46);
            labelTauxDefautB.Name = "labelTauxDefautB";
            labelTauxDefautB.Size = new Size(101, 15);
            labelTauxDefautB.TabIndex = 1;
            labelTauxDefautB.Text = "Taux défaut heure";
            // 
            // labelNbCaisseProduiteB
            // 
            labelNbCaisseProduiteB.AutoSize = true;
            labelNbCaisseProduiteB.Location = new Point(13, 17);
            labelNbCaisseProduiteB.Name = "labelNbCaisseProduiteB";
            labelNbCaisseProduiteB.Size = new Size(216, 15);
            labelNbCaisseProduiteB.TabIndex = 0;
            labelNbCaisseProduiteB.Text = "Nombre de caisses depuis le démarrage";
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(textBoxDefautDepuisDemC);
            TabPage3.Controls.Add(textBoxTauxDéfautC);
            TabPage3.Controls.Add(textBoxNbCaisseProdDemC);
            TabPage3.Controls.Add(labelTauxDefautDepuisDemarrageC);
            TabPage3.Controls.Add(labelTauxDefautC);
            TabPage3.Controls.Add(labelNbCaisseProduiteC);
            TabPage3.Location = new Point(4, 24);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(421, 99);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Type C";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxDefautDepuisDemC
            // 
            textBoxDefautDepuisDemC.Location = new Point(340, 67);
            textBoxDefautDepuisDemC.Name = "textBoxDefautDepuisDemC";
            textBoxDefautDepuisDemC.ReadOnly = true;
            textBoxDefautDepuisDemC.Size = new Size(75, 23);
            textBoxDefautDepuisDemC.TabIndex = 5;
            // 
            // textBoxTauxDéfautC
            // 
            textBoxTauxDéfautC.Location = new Point(340, 38);
            textBoxTauxDéfautC.Name = "textBoxTauxDéfautC";
            textBoxTauxDéfautC.ReadOnly = true;
            textBoxTauxDéfautC.Size = new Size(75, 23);
            textBoxTauxDéfautC.TabIndex = 4;
            // 
            // textBoxNbCaisseProdDemC
            // 
            textBoxNbCaisseProdDemC.Location = new Point(340, 9);
            textBoxNbCaisseProdDemC.Name = "textBoxNbCaisseProdDemC";
            textBoxNbCaisseProdDemC.ReadOnly = true;
            textBoxNbCaisseProdDemC.Size = new Size(75, 23);
            textBoxNbCaisseProdDemC.TabIndex = 3;
            // 
            // labelTauxDefautDepuisDemarrageC
            // 
            labelTauxDefautDepuisDemarrageC.AutoSize = true;
            labelTauxDefautDepuisDemarrageC.Location = new Point(13, 75);
            labelTauxDefautDepuisDemarrageC.Name = "labelTauxDefautDepuisDemarrageC";
            labelTauxDefautDepuisDemarrageC.Size = new Size(166, 15);
            labelTauxDefautDepuisDemarrageC.TabIndex = 2;
            labelTauxDefautDepuisDemarrageC.Text = "Taux défaut depuis démarrage";
            // 
            // labelTauxDefautC
            // 
            labelTauxDefautC.AutoSize = true;
            labelTauxDefautC.Location = new Point(13, 46);
            labelTauxDefautC.Name = "labelTauxDefautC";
            labelTauxDefautC.Size = new Size(101, 15);
            labelTauxDefautC.TabIndex = 1;
            labelTauxDefautC.Text = "Taux défaut heure";
            // 
            // labelNbCaisseProduiteC
            // 
            labelNbCaisseProduiteC.AutoSize = true;
            labelNbCaisseProduiteC.Location = new Point(13, 17);
            labelNbCaisseProduiteC.Name = "labelNbCaisseProduiteC";
            labelNbCaisseProduiteC.Size = new Size(216, 15);
            labelNbCaisseProduiteC.TabIndex = 0;
            labelNbCaisseProduiteC.Text = "Nombre de caisses depuis le démarrage";
            // 
            // buttonSuspenduA
            // 
            buttonSuspenduA.BackgroundImage = (Image)resources.GetObject("buttonSuspenduA.BackgroundImage");
            buttonSuspenduA.BackgroundImageLayout = ImageLayout.Center;
            buttonSuspenduA.Enabled = false;
            buttonSuspenduA.Location = new Point(64, 27);
            buttonSuspenduA.Name = "buttonSuspenduA";
            buttonSuspenduA.Size = new Size(46, 83);
            buttonSuspenduA.TabIndex = 10;
            buttonSuspenduA.Text = "A";
            buttonSuspenduA.TextAlign = ContentAlignment.BottomCenter;
            buttonSuspenduA.UseVisualStyleBackColor = true;
            // 
            // buttonRelancerA
            // 
            buttonRelancerA.BackgroundImage = (Image)resources.GetObject("buttonRelancerA.BackgroundImage");
            buttonRelancerA.BackgroundImageLayout = ImageLayout.Center;
            buttonRelancerA.Enabled = false;
            buttonRelancerA.Location = new Point(116, 27);
            buttonRelancerA.Name = "buttonRelancerA";
            buttonRelancerA.Size = new Size(46, 83);
            buttonRelancerA.TabIndex = 11;
            buttonRelancerA.Text = "A";
            buttonRelancerA.TextAlign = ContentAlignment.BottomCenter;
            buttonRelancerA.UseVisualStyleBackColor = true;
            // 
            // buttonRelancerC
            // 
            buttonRelancerC.BackgroundImage = (Image)resources.GetObject("buttonRelancerC.BackgroundImage");
            buttonRelancerC.BackgroundImageLayout = ImageLayout.Center;
            buttonRelancerC.Enabled = false;
            buttonRelancerC.Location = new Point(428, 27);
            buttonRelancerC.Name = "buttonRelancerC";
            buttonRelancerC.Size = new Size(46, 83);
            buttonRelancerC.TabIndex = 12;
            buttonRelancerC.Text = "C";
            buttonRelancerC.TextAlign = ContentAlignment.BottomCenter;
            buttonRelancerC.UseVisualStyleBackColor = true;
            // 
            // buttonSuspenduC
            // 
            buttonSuspenduC.BackgroundImage = (Image)resources.GetObject("buttonSuspenduC.BackgroundImage");
            buttonSuspenduC.BackgroundImageLayout = ImageLayout.Center;
            buttonSuspenduC.Enabled = false;
            buttonSuspenduC.Location = new Point(376, 27);
            buttonSuspenduC.Name = "buttonSuspenduC";
            buttonSuspenduC.Size = new Size(46, 83);
            buttonSuspenduC.TabIndex = 13;
            buttonSuspenduC.Text = "C";
            buttonSuspenduC.TextAlign = ContentAlignment.BottomCenter;
            buttonSuspenduC.UseVisualStyleBackColor = true;
            // 
            // buttonDemarrerC
            // 
            buttonDemarrerC.BackgroundImage = (Image)resources.GetObject("buttonDemarrerC.BackgroundImage");
            buttonDemarrerC.BackgroundImageLayout = ImageLayout.Center;
            buttonDemarrerC.Enabled = false;
            buttonDemarrerC.Location = new Point(324, 27);
            buttonDemarrerC.Name = "buttonDemarrerC";
            buttonDemarrerC.Size = new Size(46, 83);
            buttonDemarrerC.TabIndex = 14;
            buttonDemarrerC.Text = "C";
            buttonDemarrerC.TextAlign = ContentAlignment.BottomCenter;
            buttonDemarrerC.UseVisualStyleBackColor = true;
            // 
            // buttonSuspenduB
            // 
            buttonSuspenduB.BackgroundImage = (Image)resources.GetObject("buttonSuspenduB.BackgroundImage");
            buttonSuspenduB.BackgroundImageLayout = ImageLayout.Center;
            buttonSuspenduB.Enabled = false;
            buttonSuspenduB.Location = new Point(220, 27);
            buttonSuspenduB.Name = "buttonSuspenduB";
            buttonSuspenduB.Size = new Size(46, 83);
            buttonSuspenduB.TabIndex = 15;
            buttonSuspenduB.Text = "B";
            buttonSuspenduB.TextAlign = ContentAlignment.BottomCenter;
            buttonSuspenduB.UseVisualStyleBackColor = true;
            // 
            // buttonRelancerB
            // 
            buttonRelancerB.BackgroundImage = (Image)resources.GetObject("buttonRelancerB.BackgroundImage");
            buttonRelancerB.BackgroundImageLayout = ImageLayout.Center;
            buttonRelancerB.Enabled = false;
            buttonRelancerB.Location = new Point(272, 27);
            buttonRelancerB.Name = "buttonRelancerB";
            buttonRelancerB.Size = new Size(46, 83);
            buttonRelancerB.TabIndex = 16;
            buttonRelancerB.Text = "B";
            buttonRelancerB.TextAlign = ContentAlignment.BottomCenter;
            buttonRelancerB.UseVisualStyleBackColor = true;
            // 
            // buttonDemarrerB
            // 
            buttonDemarrerB.BackgroundImage = (Image)resources.GetObject("buttonDemarrerB.BackgroundImage");
            buttonDemarrerB.BackgroundImageLayout = ImageLayout.Center;
            buttonDemarrerB.Enabled = false;
            buttonDemarrerB.Location = new Point(168, 27);
            buttonDemarrerB.Name = "buttonDemarrerB";
            buttonDemarrerB.Size = new Size(46, 83);
            buttonDemarrerB.TabIndex = 17;
            buttonDemarrerB.Text = "B";
            buttonDemarrerB.TextAlign = ContentAlignment.BottomCenter;
            buttonDemarrerB.UseVisualStyleBackColor = true;
            // 
            // buttonDemarrerA
            // 
            buttonDemarrerA.BackgroundImage = (Image)resources.GetObject("buttonDemarrerA.BackgroundImage");
            buttonDemarrerA.BackgroundImageLayout = ImageLayout.Center;
            buttonDemarrerA.Enabled = false;
            buttonDemarrerA.Location = new Point(12, 27);
            buttonDemarrerA.Name = "buttonDemarrerA";
            buttonDemarrerA.Size = new Size(46, 83);
            buttonDemarrerA.TabIndex = 18;
            buttonDemarrerA.Text = "A";
            buttonDemarrerA.TextAlign = ContentAlignment.BottomCenter;
            buttonDemarrerA.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormProductionDeCaisses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 506);
            Controls.Add(buttonDemarrerA);
            Controls.Add(buttonDemarrerB);
            Controls.Add(buttonRelancerB);
            Controls.Add(buttonSuspenduB);
            Controls.Add(buttonDemarrerC);
            Controls.Add(buttonSuspenduC);
            Controls.Add(buttonRelancerC);
            Controls.Add(buttonRelancerA);
            Controls.Add(buttonSuspenduA);
            Controls.Add(tabControl);
            Controls.Add(toolStrip1);
            Controls.Add(progressBar1);
            Controls.Add(labelProductionC);
            Controls.Add(progressBarProductionB);
            Controls.Add(labelProductionB);
            Controls.Add(labelProductionA);
            Controls.Add(progressBarProductionA);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormProductionDeCaisses";
            Text = "Production De Caisses";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageTypeA.ResumeLayout(false);
            tabPageTypeA.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem productionToolStripMenuItem;
        private ProgressBar progressBarProductionA;
        private Label labelProductionA;
        private Label labelProductionB;
        private ProgressBar progressBarProductionB;
        private ToolStripMenuItem démarrerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem arrêterToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem1;
        private ToolStripMenuItem bToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem continuerToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem2;
        private ToolStripMenuItem bToolStripMenuItem2;
        private ToolStripMenuItem cToolStripMenuItem2;
        private Label labelProductionC;
        private ProgressBar progressBar1;
        private ToolStrip toolStrip1;
        private TabControl tabControl;
        private TabPage tabPageTypeA;
        private TextBox textBoxDefautDepuisDemA;
        private TextBox textBoxTauxDéfautA;
        private TextBox textBoxNbCaisseProdDemA;
        private Label labelTauxDefautDepuisDemarrageA;
        private Label labelTauxDefautA;
        private Label labelNbCaisseProduiteA;
        private TabPage tabPage2;
        private TabPage TabPage3;
        private TextBox textBoxDefautDepuisDemB;
        private TextBox textBoxTauxDéfautB;
        private TextBox textBoxNbCaisseProdDemB;
        private Label labelTauxDefautDepuisDemarrageB;
        private Label labelTauxDefautB;
        private Label labelNbCaisseProduiteB;
        private TextBox textBoxDefautDepuisDemC;
        private TextBox textBoxTauxDéfautC;
        private TextBox textBoxNbCaisseProdDemC;
        private Label labelTauxDefautDepuisDemarrageC;
        private Label labelTauxDefautC;
        private Label labelNbCaisseProduiteC;
        private ToolStripLabel toolStripLabelCaisseA;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabelCaisseB;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabelCaisseC;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel toolStripLabelDateTime;
        private Button buttonSuspenduA;
        private Button buttonRelancerA;
        private Button buttonRelancerC;
        private Button buttonSuspenduC;
        private Button buttonDemarrerC;
        private Button buttonSuspenduB;
        private Button buttonRelancerB;
        private Button buttonDemarrerB;
        private Button buttonDemarrerA;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}