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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.planetcomponent1 = new Planets.planetcomponent();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(86, 208);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // planetcomponent1
            // 
            this.planetcomponent1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("planetcomponent1.BackgroundImage")));
            this.planetcomponent1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.planetcomponent1.Location = new System.Drawing.Point(128, 31);
            this.planetcomponent1.Name = "planetcomponent1";
            this.planetcomponent1.Size = new System.Drawing.Size(106, 103);
            this.planetcomponent1.TabIndex = 1;
            this.planetcomponent1.Click += new System.EventHandler(this.showdialog);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.planetcomponent1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private planetcomponent planetcomponent1;
    }
}

