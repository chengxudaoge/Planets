namespace Planets
{
    partial class Form2
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
            this.okbutt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.thename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xloc = new System.Windows.Forms.TextBox();
            this.yloc = new System.Windows.Forms.TextBox();
            this.xvel = new System.Windows.Forms.TextBox();
            this.yvel = new System.Windows.Forms.TextBox();
            this.mass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okbutt
            // 
            this.okbutt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbutt.Location = new System.Drawing.Point(66, 195);
            this.okbutt.Name = "okbutt";
            this.okbutt.Size = new System.Drawing.Size(75, 23);
            this.okbutt.TabIndex = 0;
            this.okbutt.Text = "OK";
            this.okbutt.UseVisualStyleBackColor = true;
            this.okbutt.Click += new System.EventHandler(this.okbutt_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(193, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // thename
            // 
            this.thename.Location = new System.Drawing.Point(99, 26);
            this.thename.Name = "thename";
            this.thename.Size = new System.Drawing.Size(152, 20);
            this.thename.TabIndex = 2;
            this.thename.Text = "A Planet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Velocity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "x";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "y";
            // 
            // xloc
            // 
            this.xloc.Location = new System.Drawing.Point(115, 73);
            this.xloc.Name = "xloc";
            this.xloc.Size = new System.Drawing.Size(43, 20);
            this.xloc.TabIndex = 11;
            // 
            // yloc
            // 
            this.yloc.Location = new System.Drawing.Point(208, 73);
            this.yloc.Name = "yloc";
            this.yloc.Size = new System.Drawing.Size(43, 20);
            this.yloc.TabIndex = 12;
            // 
            // xvel
            // 
            this.xvel.Location = new System.Drawing.Point(121, 120);
            this.xvel.Name = "xvel";
            this.xvel.Size = new System.Drawing.Size(43, 20);
            this.xvel.TabIndex = 13;
            // 
            // yvel
            // 
            this.yvel.Location = new System.Drawing.Point(200, 120);
            this.yvel.Name = "yvel";
            this.yvel.Size = new System.Drawing.Size(43, 20);
            this.yvel.TabIndex = 14;
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(121, 149);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(43, 20);
            this.mass.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.yvel);
            this.Controls.Add(this.xvel);
            this.Controls.Add(this.yloc);
            this.Controls.Add(this.xloc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thename);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okbutt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbutt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox thename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xloc;
        private System.Windows.Forms.TextBox yloc;
        private System.Windows.Forms.TextBox xvel;
        private System.Windows.Forms.TextBox yvel;
        private System.Windows.Forms.TextBox mass;
    }
}