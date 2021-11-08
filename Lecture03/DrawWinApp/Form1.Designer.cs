
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
            this.drawControl1 = new Base.WinForms.DrawControl();
            this.SuspendLayout();
            // 
            // drawControl1
            // 
            this.drawControl1.BackColor = System.Drawing.Color.White;
            this.drawControl1.Location = new System.Drawing.Point(51, 25);
            this.drawControl1.MaxX = 1F;
            this.drawControl1.MaxY = 1F;
            this.drawControl1.MinX = -1F;
            this.drawControl1.MinY = -1F;
            this.drawControl1.Name = "drawControl1";
            this.drawControl1.Size = new System.Drawing.Size(707, 378);
            this.drawControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Base.WinForms.DrawControl drawControl1;
    }
}

