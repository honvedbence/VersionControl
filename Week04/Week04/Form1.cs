﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities();
        List<Flat> Flats;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Flats = context.Flat.ToList();
        }
    }
}
