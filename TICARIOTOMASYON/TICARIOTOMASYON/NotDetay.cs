﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICARIOTOMASYON
{
    public partial class NotDetay : Form
    {
        public NotDetay()
        {
            InitializeComponent();
        }

        public string metin;
        private void NotDetay_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = metin;
        }
    }
}
