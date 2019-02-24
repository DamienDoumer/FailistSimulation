namespace FailistSimulation
{
    partial class ManualSimulationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SelectedErrorListBox = new System.Windows.Forms.ListBox();
            this.RemoveErrorButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectedPlane = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveErrorButton);
            this.groupBox1.Controls.Add(this.SelectedErrorListBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Errors";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(494, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Plane Errors";
            // 
            // SelectedErrorListBox
            // 
            this.SelectedErrorListBox.FormattingEnabled = true;
            this.SelectedErrorListBox.ItemHeight = 16;
            this.SelectedErrorListBox.Location = new System.Drawing.Point(18, 32);
            this.SelectedErrorListBox.Name = "SelectedErrorListBox";
            this.SelectedErrorListBox.Size = new System.Drawing.Size(789, 276);
            this.SelectedErrorListBox.TabIndex = 1;
            // 
            // RemoveErrorButton
            // 
            this.RemoveErrorButton.Location = new System.Drawing.Point(702, 319);
            this.RemoveErrorButton.Name = "RemoveErrorButton";
            this.RemoveErrorButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveErrorButton.TabIndex = 2;
            this.RemoveErrorButton.Text = "Remove";
            this.RemoveErrorButton.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(18, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(494, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Select A Plane";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectedPlane);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Plane";
            // 
            // SelectedPlane
            // 
            this.SelectedPlane.AutoSize = true;
            this.SelectedPlane.Location = new System.Drawing.Point(538, 43);
            this.SelectedPlane.Name = "SelectedPlane";
            this.SelectedPlane.Size = new System.Drawing.Size(103, 17);
            this.SelectedPlane.TabIndex = 2;
            this.SelectedPlane.Text = "Selected Plane";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(714, 502);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(105, 23);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // ManualSimulationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 545);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManualSimulationDialog";
            this.Text = "ManualSimulationDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RemoveErrorButton;
        private System.Windows.Forms.ListBox SelectedErrorListBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SelectedPlane;
        private System.Windows.Forms.Button DoneButton;
    }
}