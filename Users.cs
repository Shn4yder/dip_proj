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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void good_MenuItem_Click(object sender, EventArgs e)
        {
            Goods_adm gds_frm  = new Goods_adm();
            this.Hide();
            gds_frm.Show();
        }

        private void note_MenuItem_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            this.Hide();
            notes.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddUser add_frm = new AddUser();
            add_frm.Show();
        }
    }
}
