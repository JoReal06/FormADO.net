﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdo_net ado = new FormAdo_net();
            ado.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEntityFram entity = new FormEntityFram();
            entity.ShowDialog();
        }
    }
}
