namespace Planets
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
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addPlanet = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.anniversary = new System.Windows.Forms.Label();
            this.init = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(50, 10);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start/Stop";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addPlanet
            // 
            this.addPlanet.Location = new System.Drawing.Point(141, 10);
            this.addPlanet.Name = "addPlanet";
            this.addPlanet.Size = new System.Drawing.Size(75, 23);
            this.addPlanet.TabIndex = 3;
            this.addPlanet.Text = "Add Planet";
            this.addPlanet.UseVisualStyleBackColor = true;
            this.addPlanet.Click += new System.EventHandler(this.addPlanet_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(18, 32);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(22, 13);
            this.time.TabIndex = 4;
            this.time.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(294, 11);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(100, 20);
            this.interval.TabIndex = 6;
            this.interval.Text = "0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Interval (s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scale FS=(meters)";
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(499, 11);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(100, 20);
            this.scale.TabIndex = 8;
            this.scale.Text = "0.1";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(625, 10);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // anniversary
            // 
            this.anniversary.AutoSize = true;
            this.anniversary.Location = new System.Drawing.Point(488, 38);
            this.anniversary.Name = "anniversary";
            this.anniversary.Size = new System.Drawing.Size(0, 13);
            this.anniversary.TabIndex = 11;
            // 
            // init
            // 
            this.init.Location = new System.Drawing.Point(625, 50);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(75, 23);
            this.init.TabIndex = 12;
            this.init.Text = "Init...";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 345);
            this.Controls.Add(this.init);
            this.Controls.Add(this.anniversary);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.addPlanet);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button addPlanet;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scale;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label anniversary;
        private System.Windows.Forms.Button init;
    }
}

