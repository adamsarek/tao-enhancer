﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAO_Enhancer
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ItemsForm().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EntryForm().Show();
            Hide();
        }
    }
}