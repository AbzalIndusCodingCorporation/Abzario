namespace Abzario {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.canvas = new System.Windows.Forms.Panel();
            this.infopanel = new System.Windows.Forms.Panel();
            this.debug = new System.Windows.Forms.Label();
            this.infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.canvas.Location = new System.Drawing.Point(0, 25);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(707, 373);
            this.canvas.TabIndex = 0;
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.infopanel.Controls.Add(this.debug);
            this.infopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infopanel.Location = new System.Drawing.Point(0, 0);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(707, 25);
            this.infopanel.TabIndex = 1;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(3, 9);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 13);
            this.debug.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 398);
            this.Controls.Add(this.infopanel);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "TheAbzario";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Label debug;


    }
}

