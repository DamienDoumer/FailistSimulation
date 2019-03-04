using FailistSimulation.Models;
using FailistSimulation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FailistSimulation
{
    public partial class ManualSimulationDialog : Form
    {
        public event Action<List<IdFailureX>, IdPlane> OptionsSelected;
        private FailistObject _failistObject;

        public ManualSimulationDialog()
        {
            InitializeComponent();
            _failistObject = DataAccessor.DeserializeData();

            foreach (var item in _failistObject.IdFailureX)
            {
                comboBox1.Items.Add(item);
            }
            foreach (var item in _failistObject.IdPlanes)
            {
                comboBox2.Items.Add(item);
            }
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            RemoveErrorButton.Click += RemoveErrorButton_Click;
        }

        protected override void OnClosed(EventArgs e)
        {
            foreach (var @delegate in OptionsSelected.GetInvocationList())
            {
                OptionsSelected -= @delegate as Action<List<IdFailureX>, IdPlane>;
            }
            base.OnClosed(e);
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (SelectedErrorListBox.Items.Count < 1 || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select at least an error and a plane to proceed.");
                return;
            }
            var items = _failistObject.IdFailureX.Where(f => SelectedErrorListBox.Items.Contains(f.ToString()));
            OptionsSelected?.Invoke(new List<IdFailureX>(_failistObject.IdFailureX.Where(f => SelectedErrorListBox.Items.Contains(f.ToString()))),
                _failistObject.IdPlanes.Where(p => p.ToString() == comboBox2.SelectedItem.ToString()).FirstOrDefault());
            this.Close();
        }

        void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedErrorListBox.Items.Add(_failistObject.IdFailureX.Where(f => f.ToString() == comboBox1.SelectedItem.ToString()).FirstOrDefault());
        }

        void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPlane.Text = comboBox2.SelectedItem?.ToString();
        }

        void RemoveErrorButton_Click(object sender, EventArgs e)
        {
            if (SelectedErrorListBox.Items.Count < 1)
                return;

            SelectedErrorListBox.Items.Remove(SelectedErrorListBox.SelectedItem);
        }
    }
}