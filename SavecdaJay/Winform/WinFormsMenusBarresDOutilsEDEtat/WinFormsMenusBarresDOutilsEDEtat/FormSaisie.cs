﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLesDifferentsObjetsGraphiques;

namespace WinFormsMenusBarresDOutilsEDEtat
{
    public partial class FormSaisieTextePhase3ChekBoxBtRadio : Form
    {
        public FormSaisieTextePhase3ChekBoxBtRadio()
        {
            InitializeComponent();
        }
        private void buttonValider_Click(object sender, EventArgs e)
        {
            string texte = textBoxSaisie.Text;
            FormLesDifferentsObjetsGraphiques formDifObjGraph = new FormLesDifferentsObjetsGraphiques(textBoxSaisie.Text);
            formDifObjGraph.Show();
        }
        private void textBoxSaisie_TextChanged(object sender, EventArgs e)
        {

        }

    }
}