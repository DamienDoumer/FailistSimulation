namespace FailistSimulation
{
    partial class Form1
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
            this.SimulationEventListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SimulationStatusLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StopSimulationButton = new System.Windows.Forms.Button();
            this.ManualSimulationButton = new System.Windows.Forms.Button();
            this.AutomaticSimulationButton = new System.Windows.Forms.Button();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.TimeIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SimulationEventListBox
            // 
            this.SimulationEventListBox.FormattingEnabled = true;
            this.SimulationEventListBox.ItemHeight = 16;
            this.SimulationEventListBox.Location = new System.Drawing.Point(35, 39);
            this.SimulationEventListBox.Name = "SimulationEventListBox";
            this.SimulationEventListBox.Size = new System.Drawing.Size(836, 340);
            this.SimulationEventListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SimulationEventListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 403);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation Events";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SimulationStatusLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation Status";
            // 
            // SimulationStatusLabel
            // 
            this.SimulationStatusLabel.AutoSize = true;
            this.SimulationStatusLabel.Location = new System.Drawing.Point(7, 31);
            this.SimulationStatusLabel.Name = "SimulationStatusLabel";
            this.SimulationStatusLabel.Size = new System.Drawing.Size(160, 17);
            this.SimulationStatusLabel.TabIndex = 0;
            this.SimulationStatusLabel.Text = "No Simulation Going On";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopSimulationButton);
            this.groupBox3.Controls.Add(this.ManualSimulationButton);
            this.groupBox3.Controls.Add(this.AutomaticSimulationButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 547);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(883, 84);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulation Options";
            // 
            // StopSimulationButton
            // 
            this.StopSimulationButton.Location = new System.Drawing.Point(619, 21);
            this.StopSimulationButton.Name = "StopSimulationButton";
            this.StopSimulationButton.Size = new System.Drawing.Size(206, 40);
            this.StopSimulationButton.TabIndex = 2;
            this.StopSimulationButton.Text = "Stop Simulation";
            this.StopSimulationButton.UseVisualStyleBackColor = true;
            this.StopSimulationButton.Click += new System.EventHandler(this.StopSimulationButton_Click);
            // 
            // ManualSimulationButton
            // 
            this.ManualSimulationButton.Location = new System.Drawing.Point(337, 21);
            this.ManualSimulationButton.Name = "ManualSimulationButton";
            this.ManualSimulationButton.Size = new System.Drawing.Size(206, 40);
            this.ManualSimulationButton.TabIndex = 1;
            this.ManualSimulationButton.Text = "Manual Simulation";
            this.ManualSimulationButton.UseVisualStyleBackColor = true;
            this.ManualSimulationButton.Click += new System.EventHandler(this.ManualSimulationButton_Click);
            // 
            // AutomaticSimulationButton
            // 
            this.AutomaticSimulationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutomaticSimulationButton.Location = new System.Drawing.Point(34, 21);
            this.AutomaticSimulationButton.Name = "AutomaticSimulationButton";
            this.AutomaticSimulationButton.Size = new System.Drawing.Size(206, 40);
            this.AutomaticSimulationButton.TabIndex = 0;
            this.AutomaticSimulationButton.Text = "Automatic Simulation";
            this.AutomaticSimulationButton.UseVisualStyleBackColor = true;
            this.AutomaticSimulationButton.Click += new System.EventHandler(this.AutomaticSimulationButton_Click);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(350, 468);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(206, 22);
            this.DurationTextBox.TabIndex = 5;
            // 
            // TimeIntervalTextBox
            // 
            this.TimeIntervalTextBox.Location = new System.Drawing.Point(632, 468);
            this.TimeIntervalTextBox.Name = "TimeIntervalTextBox";
            this.TimeIntervalTextBox.Size = new System.Drawing.Size(206, 22);
            this.TimeIntervalTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time Intervals";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeIntervalTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Failist Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SimulationEventListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SimulationStatusLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button StopSimulationButton;
        private System.Windows.Forms.Button ManualSimulationButton;
        private System.Windows.Forms.Button AutomaticSimulationButton;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox TimeIntervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

