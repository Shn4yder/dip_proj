﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dip_proj
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Enter_btn_Click(object sender, EventArgs e)
        {
            Orders order_frm = new Orders();
            this.Hide();
            order_frm.Show();
        }
    }
}
