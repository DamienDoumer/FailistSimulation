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
        bool _isSimulationMode;

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            TimeIntervalTextBox.Visible = false;
            label2.Visible = false;
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
            if (!_isSimulationMode)
            {
                string strDuration = DurationTextBox.Text;
                string strInterval = TimeIntervalTextBox.Text;
                int duration = 0;
                int interval = 0;

                if (!int.TryParse(strDuration, out duration))
                {
                    MessageBox.Show("Please enter a valid duration in Seconds");
                    return;
                }
                if (!int.TryParse(strInterval, out interval))
                {
                    MessageBox.Show("Please enter a valid interval integer less than.");
                    return;
                }

                if (_simulator != null)
                {
                    _simulator.ErrorOccured -= _simulator_ErrorOccured;
                    _simulator.SimulationFinished -= _simulator_SimulationFinished;
                }

                interval = new Random().Next(1, 20);
                _simulator = new Simulator(arg1, arg2, duration, interval);
                Simulate();
            }
            else
            {
                MessageBox.Show("Simulation going on.");
            }
        }

        private void AutomaticSimulationButton_Click(object sender, EventArgs e)
        {
            if (!_isSimulationMode)
            {
                string strDuration = DurationTextBox.Text;
                //string strInterval = TimeIntervalTextBox.Text;
                string strInterval = "1";
                int duration = 0;
                int interval = 0;

                if (!int.TryParse(strDuration, out duration))
                {
                    MessageBox.Show("Please enter a valid duration in Seconds");
                    return;
                }
                if (!int.TryParse(strInterval, out interval))
                {
                    MessageBox.Show("Please enter a valid interval integer less than.");
                    return;
                }

                if (_simulator != null)
                {
                    _simulator.ErrorOccured -= _simulator_ErrorOccured;
                    _simulator.SimulationFinished -= _simulator_SimulationFinished;
                }

                interval = new Random().Next(1, 20);
                _simulator = new Simulator((double)duration, interval);
                Simulate();
            }
            else
            {
                MessageBox.Show("Simulation going on.");
            }
        }

        public void Simulate()
        {
            if (SimulationEventListBox.Items.Count > 0)
            {
                SimulationEventListBox.Items.Clear();
            }
            _simulator.ErrorOccured += _simulator_ErrorOccured;
            _simulator.SimulationFinished += _simulator_SimulationFinished;
            _simulator.Simulate();
            _isSimulationMode = true;
            SimulationStatusLabel.Text = "Simulation started.";
        }

        private void StopSimulationButton_Click(object sender, EventArgs e)
        {
            if (_isSimulationMode)
            {
                _simulator.Stop();
                SimulationStatusLabel.Text = "Simulation Stopped";
                _isSimulationMode = false;
            }
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
            _isSimulationMode = false;
            SimulationFinished("Simulation Completed.");
        }
        void SimulationFinished(string message)
        {
            if (SimulationStatusLabel.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SimulationFinished);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                this.SimulationStatusLabel.Text = message;
            }
        }
    }
}