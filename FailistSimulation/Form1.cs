﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FailistSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ManualSimulationButton_Click(object sender, EventArgs e)
        {
            ManualSimulationDialog manualSimulationDialog = new ManualSimulationDialog();
            manualSimulationDialog.OptionsSelected += ManualSimulationDialog_OptionsSelected;
            manualSimulationDialog.ShowDialog();
        }

        private void ManualSimulationDialog_OptionsSelected(List<Models.IdFailureX> arg1, Models.IdPlane arg2)
        {
            Debug.WriteLine("Manual Simulation selected.");
        }

        private void AutomaticSimulationButton_Click(object sender, EventArgs e)
        {

        }

        private void StopSimulationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
