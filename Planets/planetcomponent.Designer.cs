namespace Planets
{
    partial class planetcomponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.thelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thelabel
            // 
            this.thelabel.AutoSize = true;
            this.thelabel.Location = new System.Drawing.Point(3, 0);
            this.thelabel.Name = "thelabel";
            this.thelabel.Size = new System.Drawing.Size(49, 13);
            this.thelabel.TabIndex = 0;
            this.thelabel.Text = "MyName";
            // 
            // planetcomponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.thelabel);
            this.Name = "planetcomponent";
            this.Size = new System.Drawing.Size(52, 25);
            this.DoubleClick += new System.EventHandler(this.showmydialog);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.planet_MyMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.planet_MyMouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thelabel;
    }
}
