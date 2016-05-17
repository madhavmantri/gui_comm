namespace gui
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
            this.components = new System.ComponentModel.Container();
            this.SelectPort = new System.Windows.Forms.Label();
            this.Kp = new System.Windows.Forms.TextBox();
            this.Kd = new System.Windows.Forms.TextBox();
            this.KpLabel = new System.Windows.Forms.Label();
            this.KdLabel = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.Send_constants = new System.Windows.Forms.Button();
            this.Plot = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.Ports = new System.Windows.Forms.ComboBox();
            this.OpenLoop = new System.Windows.Forms.CheckBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.FPS = new System.Windows.Forms.TextBox();
            this.FramesPerSecond = new System.Windows.Forms.Label();
            this.Velocity_left_textbox = new System.Windows.Forms.TextBox();
            this.R_vel_text_label = new System.Windows.Forms.Label();
            this.L_vel_text_label = new System.Windows.Forms.Label();
            this.Send_targets = new System.Windows.Forms.Button();
            this.Velocity_right_textbox = new System.Windows.Forms.TextBox();
            this.Graph = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // SelectPort
            // 
            this.SelectPort.AutoSize = true;
            this.SelectPort.Location = new System.Drawing.Point(12, 9);
            this.SelectPort.Name = "SelectPort";
            this.SelectPort.Size = new System.Drawing.Size(59, 13);
            this.SelectPort.TabIndex = 1;
            this.SelectPort.Text = "Select Port";
            // 
            // Kp
            // 
            this.Kp.Location = new System.Drawing.Point(35, 162);
            this.Kp.Name = "Kp";
            this.Kp.Size = new System.Drawing.Size(100, 20);
            this.Kp.TabIndex = 3;
            // 
            // Kd
            // 
            this.Kd.Location = new System.Drawing.Point(35, 195);
            this.Kd.Name = "Kd";
            this.Kd.Size = new System.Drawing.Size(100, 20);
            this.Kd.TabIndex = 5;
            // 
            // KpLabel
            // 
            this.KpLabel.AutoSize = true;
            this.KpLabel.Location = new System.Drawing.Point(9, 165);
            this.KpLabel.Name = "KpLabel";
            this.KpLabel.Size = new System.Drawing.Size(20, 13);
            this.KpLabel.TabIndex = 6;
            this.KpLabel.Text = "Kp";
            // 
            // KdLabel
            // 
            this.KdLabel.AutoSize = true;
            this.KdLabel.Location = new System.Drawing.Point(9, 195);
            this.KdLabel.Name = "KdLabel";
            this.KdLabel.Size = new System.Drawing.Size(20, 13);
            this.KdLabel.TabIndex = 8;
            this.KdLabel.Text = "Kd";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(103, 52);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 9;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Send_constants
            // 
            this.Send_constants.Location = new System.Drawing.Point(16, 231);
            this.Send_constants.Name = "Send_constants";
            this.Send_constants.Size = new System.Drawing.Size(119, 23);
            this.Send_constants.TabIndex = 10;
            this.Send_constants.Text = "Send PID Constants";
            this.Send_constants.UseVisualStyleBackColor = true;
            this.Send_constants.Click += new System.EventHandler(this.Send_Click);
            // 
            // Plot
            // 
            this.Plot.Location = new System.Drawing.Point(280, 400);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(75, 23);
            this.Plot.TabIndex = 11;
            this.Plot.Text = "Plot";
            this.Plot.UseVisualStyleBackColor = true;
            this.Plot.Click += new System.EventHandler(this.Plot_Click);
            // 
            // Ports
            // 
            this.Ports.FormattingEnabled = true;
            this.Ports.Location = new System.Drawing.Point(12, 25);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(121, 21);
            this.Ports.TabIndex = 12;
            // 
            // OpenLoop
            // 
            this.OpenLoop.AutoSize = true;
            this.OpenLoop.Location = new System.Drawing.Point(16, 139);
            this.OpenLoop.Name = "OpenLoop";
            this.OpenLoop.Size = new System.Drawing.Size(79, 17);
            this.OpenLoop.TabIndex = 13;
            this.OpenLoop.Text = "Open Loop";
            this.OpenLoop.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(455, 400);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FPS
            // 
            this.FPS.Location = new System.Drawing.Point(14, 113);
            this.FPS.Name = "FPS";
            this.FPS.Size = new System.Drawing.Size(121, 20);
            this.FPS.TabIndex = 20;
            // 
            // FramesPerSecond
            // 
            this.FramesPerSecond.AutoSize = true;
            this.FramesPerSecond.Location = new System.Drawing.Point(13, 87);
            this.FramesPerSecond.Name = "FramesPerSecond";
            this.FramesPerSecond.Size = new System.Drawing.Size(41, 13);
            this.FramesPerSecond.TabIndex = 21;
            this.FramesPerSecond.Text = "Frames";
            // 
            // Velocity_left_textbox
            // 
            this.Velocity_left_textbox.Location = new System.Drawing.Point(12, 334);
            this.Velocity_left_textbox.Name = "Velocity_left_textbox";
            this.Velocity_left_textbox.Size = new System.Drawing.Size(100, 20);
            this.Velocity_left_textbox.TabIndex = 26;
            // 
            // R_vel_text_label
            // 
            this.R_vel_text_label.AutoSize = true;
            this.R_vel_text_label.Location = new System.Drawing.Point(9, 270);
            this.R_vel_text_label.Name = "R_vel_text_label";
            this.R_vel_text_label.Size = new System.Drawing.Size(66, 13);
            this.R_vel_text_label.TabIndex = 27;
            this.R_vel_text_label.Text = "velocity right";
            // 
            // L_vel_text_label
            // 
            this.L_vel_text_label.AutoSize = true;
            this.L_vel_text_label.Location = new System.Drawing.Point(11, 318);
            this.L_vel_text_label.Name = "L_vel_text_label";
            this.L_vel_text_label.Size = new System.Drawing.Size(60, 13);
            this.L_vel_text_label.TabIndex = 28;
            this.L_vel_text_label.Text = "velocity left";
            // 
            // Send_targets
            // 
            this.Send_targets.Location = new System.Drawing.Point(16, 360);
            this.Send_targets.Name = "Send_targets";
            this.Send_targets.Size = new System.Drawing.Size(117, 25);
            this.Send_targets.TabIndex = 29;
            this.Send_targets.Text = "Send Targets";
            this.Send_targets.UseVisualStyleBackColor = true;
            this.Send_targets.Click += new System.EventHandler(this.Send_targets_Click);
            // 
            // Velocity_right_textbox
            // 
            this.Velocity_right_textbox.Location = new System.Drawing.Point(12, 286);
            this.Velocity_right_textbox.Name = "Velocity_right_textbox";
            this.Velocity_right_textbox.Size = new System.Drawing.Size(100, 20);
            this.Velocity_right_textbox.TabIndex = 30;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(184, 25);
            this.Graph.Name = "Graph";
            this.Graph.ScrollGrace = 0D;
            this.Graph.ScrollMaxX = 0D;
            this.Graph.ScrollMaxY = 0D;
            this.Graph.ScrollMaxY2 = 0D;
            this.Graph.ScrollMinX = 0D;
            this.Graph.ScrollMinY = 0D;
            this.Graph.ScrollMinY2 = 0D;
            this.Graph.Size = new System.Drawing.Size(441, 350);
            this.Graph.TabIndex = 31;
            this.Graph.Load += new System.EventHandler(this.Graph_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 476);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.Velocity_right_textbox);
            this.Controls.Add(this.Send_targets);
            this.Controls.Add(this.L_vel_text_label);
            this.Controls.Add(this.R_vel_text_label);
            this.Controls.Add(this.Velocity_left_textbox);
            this.Controls.Add(this.FramesPerSecond);
            this.Controls.Add(this.FPS);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OpenLoop);
            this.Controls.Add(this.Ports);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.Send_constants);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.KdLabel);
            this.Controls.Add(this.KpLabel);
            this.Controls.Add(this.Kd);
            this.Controls.Add(this.Kp);
            this.Controls.Add(this.SelectPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectPort;
        private System.Windows.Forms.TextBox Kp;
        private System.Windows.Forms.TextBox Kd;
        private System.Windows.Forms.Label KpLabel;
        private System.Windows.Forms.Label KdLabel;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Send_constants;
        private System.Windows.Forms.Button Plot;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ComboBox Ports;
        private System.Windows.Forms.CheckBox OpenLoop;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox FPS;
        private System.Windows.Forms.Label FramesPerSecond;
        private System.Windows.Forms.TextBox Velocity_left_textbox;
        private System.Windows.Forms.Label R_vel_text_label;
        private System.Windows.Forms.Label L_vel_text_label;
        private System.Windows.Forms.Button Send_targets;
        private System.Windows.Forms.TextBox Velocity_right_textbox;
        private ZedGraph.ZedGraphControl Graph;
    }
}

