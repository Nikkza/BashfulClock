namespace BashfulClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxAlarmMinute2 = new System.Windows.Forms.TextBox();
            this.buttonSetAlarm2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAlarmHoure2 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBoxSetHour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSetMinute = new System.Windows.Forms.TextBox();
            this.buttonStartClock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Panelstart = new System.Windows.Forms.Panel();
            this.labelClock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAlarmMinute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlarmHour = new System.Windows.Forms.TextBox();
            this.buttonSetAlarm = new System.Windows.Forms.Button();
            this.PanelAlarm2 = new System.Windows.Forms.Panel();
            this.labelAlarm2 = new System.Windows.Forms.Label();
            this.PanelAlarm1 = new System.Windows.Forms.Panel();
            this.labelAlarm1 = new System.Windows.Forms.Label();
            this.Panelstart.SuspendLayout();
            this.PanelAlarm2.SuspendLayout();
            this.PanelAlarm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxAlarmMinute2
            // 
            this.textBoxAlarmMinute2.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAlarmMinute2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlarmMinute2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlarmMinute2.ForeColor = System.Drawing.Color.White;
            this.textBoxAlarmMinute2.Location = new System.Drawing.Point(135, 96);
            this.textBoxAlarmMinute2.Name = "textBoxAlarmMinute2";
            this.textBoxAlarmMinute2.Size = new System.Drawing.Size(160, 25);
            this.textBoxAlarmMinute2.TabIndex = 6;
            // 
            // buttonSetAlarm2
            // 
            this.buttonSetAlarm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetAlarm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAlarm2.ForeColor = System.Drawing.Color.White;
            this.buttonSetAlarm2.Location = new System.Drawing.Point(135, 136);
            this.buttonSetAlarm2.Name = "buttonSetAlarm2";
            this.buttonSetAlarm2.Size = new System.Drawing.Size(162, 40);
            this.buttonSetAlarm2.TabIndex = 9;
            this.buttonSetAlarm2.Text = "Set Alarm";
            this.buttonSetAlarm2.UseVisualStyleBackColor = true;
            this.buttonSetAlarm2.Click += new System.EventHandler(this.buttonSetAlarm2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-3, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Set minute:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Set hour:";
            // 
            // textBoxAlarmHoure2
            // 
            this.textBoxAlarmHoure2.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAlarmHoure2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlarmHoure2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlarmHoure2.ForeColor = System.Drawing.Color.White;
            this.textBoxAlarmHoure2.Location = new System.Drawing.Point(135, 46);
            this.textBoxAlarmHoure2.Name = "textBoxAlarmHoure2";
            this.textBoxAlarmHoure2.Size = new System.Drawing.Size(160, 25);
            this.textBoxAlarmHoure2.TabIndex = 5;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBoxSetHour
            // 
            this.textBoxSetHour.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSetHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSetHour.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetHour.ForeColor = System.Drawing.Color.White;
            this.textBoxSetHour.Location = new System.Drawing.Point(154, 47);
            this.textBoxSetHour.Name = "textBoxSetHour";
            this.textBoxSetHour.Size = new System.Drawing.Size(222, 25);
            this.textBoxSetHour.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Set minute:";
            // 
            // textBoxSetMinute
            // 
            this.textBoxSetMinute.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSetMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSetMinute.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetMinute.ForeColor = System.Drawing.Color.White;
            this.textBoxSetMinute.Location = new System.Drawing.Point(154, 96);
            this.textBoxSetMinute.Name = "textBoxSetMinute";
            this.textBoxSetMinute.Size = new System.Drawing.Size(222, 25);
            this.textBoxSetMinute.TabIndex = 2;
            // 
            // buttonStartClock
            // 
            this.buttonStartClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartClock.ForeColor = System.Drawing.Color.White;
            this.buttonStartClock.Location = new System.Drawing.Point(144, 115);
            this.buttonStartClock.Name = "buttonStartClock";
            this.buttonStartClock.Size = new System.Drawing.Size(222, 53);
            this.buttonStartClock.TabIndex = 7;
            this.buttonStartClock.Text = "Start Clock";
            this.buttonStartClock.UseVisualStyleBackColor = true;
            this.buttonStartClock.Click += new System.EventHandler(this.buttonStartClock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set hour:";
            // 
            // Panelstart
            // 
            this.Panelstart.BackColor = System.Drawing.Color.Transparent;
            this.Panelstart.Controls.Add(this.labelClock);
            this.Panelstart.Controls.Add(this.buttonStartClock);
            this.Panelstart.Location = new System.Drawing.Point(10, 24);
            this.Panelstart.Margin = new System.Windows.Forms.Padding(2);
            this.Panelstart.Name = "Panelstart";
            this.Panelstart.Size = new System.Drawing.Size(736, 171);
            this.Panelstart.TabIndex = 10;
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.Color.White;
            this.labelClock.Location = new System.Drawing.Point(400, 23);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(325, 120);
            this.labelClock.TabIndex = 7;
            this.labelClock.Text = "00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set hour:";
            // 
            // textBoxAlarmMinute
            // 
            this.textBoxAlarmMinute.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAlarmMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlarmMinute.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlarmMinute.ForeColor = System.Drawing.Color.White;
            this.textBoxAlarmMinute.Location = new System.Drawing.Point(131, 96);
            this.textBoxAlarmMinute.Name = "textBoxAlarmMinute";
            this.textBoxAlarmMinute.Size = new System.Drawing.Size(160, 25);
            this.textBoxAlarmMinute.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Set minute:";
            // 
            // textBoxAlarmHour
            // 
            this.textBoxAlarmHour.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAlarmHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlarmHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlarmHour.ForeColor = System.Drawing.Color.White;
            this.textBoxAlarmHour.Location = new System.Drawing.Point(131, 46);
            this.textBoxAlarmHour.Name = "textBoxAlarmHour";
            this.textBoxAlarmHour.Size = new System.Drawing.Size(160, 25);
            this.textBoxAlarmHour.TabIndex = 3;
            // 
            // buttonSetAlarm
            // 
            this.buttonSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAlarm.ForeColor = System.Drawing.Color.White;
            this.buttonSetAlarm.Location = new System.Drawing.Point(131, 136);
            this.buttonSetAlarm.Name = "buttonSetAlarm";
            this.buttonSetAlarm.Size = new System.Drawing.Size(160, 40);
            this.buttonSetAlarm.TabIndex = 8;
            this.buttonSetAlarm.Text = "Set Alarm";
            this.buttonSetAlarm.UseVisualStyleBackColor = true;
            this.buttonSetAlarm.Click += new System.EventHandler(this.buttonSetAlarm_Click);
            // 
            // PanelAlarm2
            // 
            this.PanelAlarm2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAlarm2.Controls.Add(this.labelAlarm2);
            this.PanelAlarm2.Controls.Add(this.buttonSetAlarm2);
            this.PanelAlarm2.Controls.Add(this.textBoxAlarmMinute2);
            this.PanelAlarm2.Controls.Add(this.label4);
            this.PanelAlarm2.Controls.Add(this.textBoxAlarmHoure2);
            this.PanelAlarm2.Controls.Add(this.label3);
            this.PanelAlarm2.Location = new System.Drawing.Point(440, 200);
            this.PanelAlarm2.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAlarm2.Name = "PanelAlarm2";
            this.PanelAlarm2.Size = new System.Drawing.Size(297, 258);
            this.PanelAlarm2.TabIndex = 12;
            // 
            // labelAlarm2
            // 
            this.labelAlarm2.AutoSize = true;
            this.labelAlarm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAlarm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarm2.ForeColor = System.Drawing.Color.White;
            this.labelAlarm2.Location = new System.Drawing.Point(149, 179);
            this.labelAlarm2.Name = "labelAlarm2";
            this.labelAlarm2.Size = new System.Drawing.Size(145, 55);
            this.labelAlarm2.TabIndex = 11;
            this.labelAlarm2.Text = "00:00";
            // 
            // PanelAlarm1
            // 
            this.PanelAlarm1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAlarm1.Controls.Add(this.labelAlarm1);
            this.PanelAlarm1.Controls.Add(this.textBoxAlarmHour);
            this.PanelAlarm1.Controls.Add(this.buttonSetAlarm);
            this.PanelAlarm1.Controls.Add(this.label5);
            this.PanelAlarm1.Controls.Add(this.textBoxAlarmMinute);
            this.PanelAlarm1.Controls.Add(this.label6);
            this.PanelAlarm1.Location = new System.Drawing.Point(22, 200);
            this.PanelAlarm1.Margin = new System.Windows.Forms.Padding(2);
            this.PanelAlarm1.Name = "PanelAlarm1";
            this.PanelAlarm1.Size = new System.Drawing.Size(353, 258);
            this.PanelAlarm1.TabIndex = 11;
            // 
            // labelAlarm1
            // 
            this.labelAlarm1.AutoSize = true;
            this.labelAlarm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAlarm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarm1.ForeColor = System.Drawing.Color.White;
            this.labelAlarm1.Location = new System.Drawing.Point(137, 179);
            this.labelAlarm1.Name = "labelAlarm1";
            this.labelAlarm1.Size = new System.Drawing.Size(145, 55);
            this.labelAlarm1.TabIndex = 10;
            this.labelAlarm1.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 459);
            this.Controls.Add(this.PanelAlarm1);
            this.Controls.Add(this.PanelAlarm2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetMinute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSetHour);
            this.Controls.Add(this.Panelstart);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The BashfulClock";
            this.Panelstart.ResumeLayout(false);
            this.Panelstart.PerformLayout();
            this.PanelAlarm2.ResumeLayout(false);
            this.PanelAlarm2.PerformLayout();
            this.PanelAlarm1.ResumeLayout(false);
            this.PanelAlarm1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSetAlarm2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAlarmMinute2;
        private System.Windows.Forms.TextBox textBoxAlarmHoure2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxSetHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSetMinute;
        private System.Windows.Forms.Button buttonStartClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panelstart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAlarmMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlarmHour;
        private System.Windows.Forms.Button buttonSetAlarm;
        private System.Windows.Forms.Panel PanelAlarm2;
        private System.Windows.Forms.Panel PanelAlarm1;
        public System.Windows.Forms.Label labelClock;
        public System.Windows.Forms.Label labelAlarm2;
        public System.Windows.Forms.Label labelAlarm1;
    }
}

