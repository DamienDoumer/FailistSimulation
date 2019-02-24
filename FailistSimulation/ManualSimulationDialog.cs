using FailistSimulation.Models;
using FailistSimulation.Services;
using System;
using System.Collections.Generic;
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
            OptionsSelected?.Invoke(null, null);
        }
    }
}
