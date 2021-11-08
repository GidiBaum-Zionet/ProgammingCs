
namespace DrawWinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawControl = new Base.WinForms.DrawControl();
            this.SuspendLayout();
            // 
            // drawControl
            // 
            this.drawControl.BackColor = System.Drawing.Color.White;
            this.drawControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawControl.Location = new System.Drawing.Point(0, 0);
            this.drawControl.MaxX = 1F;
            this.drawControl.MaxY = 1F;
            this.drawControl.MinX = -1F;
            this.drawControl.MinY = -1F;
            this.drawControl.Name = "drawControl";
            this.drawControl.Size = new System.Drawing.Size(800, 450);
            this.drawControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Base.WinForms.DrawControl drawControl;
    }
}

