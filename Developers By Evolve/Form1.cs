﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developers_By_Evolve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgramFileClass fc = new ProgramFileClass();
            fc.create("C:\\Users\\Italo\\Desktop\\");
        }
    }
}
