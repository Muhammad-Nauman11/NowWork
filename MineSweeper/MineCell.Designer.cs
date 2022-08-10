
namespace MineSweeper
{
    partial class MineCell
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
            this.btnMineCell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMineCell
            // 
            this.btnMineCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMineCell.Location = new System.Drawing.Point(0, 0);
            this.btnMineCell.Name = "btnMineCell";
            this.btnMineCell.Size = new System.Drawing.Size(83, 84);
            this.btnMineCell.TabIndex = 0;
            this.btnMineCell.Text = "button1";
            this.btnMineCell.UseVisualStyleBackColor = true;
            this.btnMineCell.Click += new System.EventHandler(this.button1_Click);
            // 
            // MineCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMineCell);
            this.Name = "MineCell";
            this.Size = new System.Drawing.Size(83, 84);
            this.Load += new System.EventHandler(this.MineCell_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMineCell;
    }
}
