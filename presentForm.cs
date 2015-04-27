﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KairosApp
{
    public partial class presentForm : Form
    {
        public presentForm(string sermonTitle, string sermonText)
        {
            InitializeComponent();
            sermonTitleLabel.Font = new Font(sermonTitleLabel.Font.FontFamily, 20);
            sermonTitleLabel.Text = sermonTitle;

            sermonTextTextbox.Text = sermonText;
        }
    }
}