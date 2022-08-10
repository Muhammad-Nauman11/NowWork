
namespace MineSweeper
{
    partial class GameButton
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
            this.btnProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(0, 0);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(158, 46);
            this.btnProceed.TabIndex = 0;
            this.btnProceed.Text = "Menu";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // GameButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnProceed);
            this.Name = "GameButton";
            this.Size = new System.Drawing.Size(158, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProceed;
    }
}
