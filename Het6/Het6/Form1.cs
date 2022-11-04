﻿using Het6.Abstarctions;
using Het6.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Het6
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();

        private Toy _nextToy;

        private IToyFactory _factory;

        public IToyFactory Factory
        {
            get { return _factory; }
            set
            {   _factory = value;
                DisplayNext();
            }
        }


        public Form1()
        {
            InitializeComponent();

            Factory = new CarFactory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = toy.Width * -1;
            toy.Top = 250;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition= 0;

            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                {
                    maxPosition = toy.Left;
                }
            }
            if (maxPosition == 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);

            }
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
            {
                mainPanel.Controls.Remove(_nextToy);
            }

            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            mainPanel.Controls.Add(_nextToy);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = buttonColor.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            button.BackColor = colorPicker.Color;
        }
    }
}
