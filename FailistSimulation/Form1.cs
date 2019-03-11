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
using System.Runtime.InteropServices;

namespace FailistSimulation
{
    public partial class Form1 : Form
    {
        Simulator _simulator;
        delegate void StringArgReturningVoidDelegate(string text);
        bool _isSimulationMode;
        private List<string> commment = new List<string> { "Comment 1", "Comment 2", "Comment 3", "Comment 4", "Comment 5" };

        [DllImport("/home/damien/Desktop/Epitech/Exos/Failist/FailistSimulation/FailistSimulation/bin/Debug/libfaillist.so", EntryPoint = "error_report")]
        static extern void error_report(string[] message);

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            TimeIntervalTextBox.Visible = false;
            label2.Visible = false;
            SimulationEventListBox.ItemHeight = 50;
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

        string[] ToStringArray(Models.IdPlane idPlane, Models.TypePlane typePlane, int nbFailures, Models.IdFailureX idFailureX, Models.IdComponentFailureX idComponentFailure)
        {
            Random rnd = new Random();
            int level = rnd.Next(1, 5);
            String comm = commment[rnd.Next(commment.Count)];

            string[] str = new string[] { idPlane.ToString(), typePlane.Id, nbFailures.ToString(), idFailureX.Id, DateTime.Now.Ticks.ToString(), level.ToString(), comm.Length.ToString(), comm };
            return str;
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
            var stringArr = ToStringArray(arg1, arg3, 0, arg2, arg4);
            error_report(stringArr);
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