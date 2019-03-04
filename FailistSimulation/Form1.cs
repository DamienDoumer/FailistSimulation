using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FailistSimulation.Services;

namespace FailistSimulation
{
    public partial class Form1 : Form
    {
        Simulator _simulator;
        delegate void StringArgReturningVoidDelegate(string text);

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
            _simulator = new Simulator(arg1, arg2, 10d, 5);
            _simulator.ErrorOccured += _simulator_ErrorOccured;
            _simulator.SimulationFinished += _simulator_SimulationFinished;
            _simulator.Simulate();
        }

        private void AutomaticSimulationButton_Click(object sender, EventArgs e)
        {

        }

        private void StopSimulationButton_Click(object sender, EventArgs e)
        {

        }

        void _simulator_ErrorOccured(Models.IdPlane arg1, Models.IdFailureX arg2, Models.TypePlane arg3, Models.IdComponentFailureX arg4)
        {
            string message = $"Error : {arg2} \n On Component : {arg4} \n On Plane {arg1} \n Of Type {arg3}";
            AddError(message);
        }

        void AddError(string message )
        {
            if (SimulationEventListBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AddError);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                this.SimulationEventListBox.Items.Add(message);
            }
        }

        void _simulator_SimulationFinished()
        {
        }
    }
}
