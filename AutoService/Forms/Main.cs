﻿using AutoService.Forms.CardForms;
using AutoService.Forms.EmloyeeForms;
using AutoService.Forms.MenuForms;
using AutoService.Forms.PartForms;
using AutoService.Forms.StatisticsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            EmployeeList form = new EmployeeList();
            form.Show();
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            CarList form = new CarList();
            form.Show();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            PartList form = new PartList();
            form.Show();
        }

   
        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandList form = new BrandList();
            form.Show();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelList form = new ModelList();
            form.Show();
        }

        private void carColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarColorList form = new CarColorList();
            form.Show();
        }

        private void cartsButton_Click(object sender, EventArgs e)
        {
            CardList form = new CardList();
            form.Show();
        }

        private void statsButton_Click(object sender, EventArgs e)
        {
            StatsList form = new StatsList();
            form.Show();
        }
    }
}
