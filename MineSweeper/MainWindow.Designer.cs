
namespace MineSweeper
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.WidgetContainer = new System.Windows.Forms.Panel();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.pictureTimer = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panelFlag = new System.Windows.Forms.Panel();
            this.pictureFlag = new System.Windows.Forms.PictureBox();
            this.lblFlagImage = new System.Windows.Forms.Label();
            this.lblNumberOfFlag = new System.Windows.Forms.Label();
            this.panelGameType = new System.Windows.Forms.Panel();
            this.cmbTimerType = new System.Windows.Forms.ComboBox();
            this.cmbGameType = new System.Windows.Forms.ComboBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.WidgetContainer.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.panelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTimer)).BeginInit();
            this.panelFlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).BeginInit();
            this.panelGameType.SuspendLayout();
            this.SuspendLayout();
            // 
            // WidgetContainer
            // 
            this.WidgetContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WidgetContainer.Controls.Add(this.StatusPanel);
            this.WidgetContainer.Location = new System.Drawing.Point(0, 0);
            this.WidgetContainer.Name = "WidgetContainer";
            this.WidgetContainer.Size = new System.Drawing.Size(798, 449);
            this.WidgetContainer.TabIndex = 0;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.Gold;
            this.StatusPanel.Controls.Add(this.panelTimer);
            this.StatusPanel.Controls.Add(this.panelFlag);
            this.StatusPanel.Controls.Add(this.panelGameType);
            this.StatusPanel.Location = new System.Drawing.Point(3, 0);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(795, 49);
            this.StatusPanel.TabIndex = 0;
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.pictureTimer);
            this.panelTimer.Controls.Add(this.lblTimer);
            this.panelTimer.Location = new System.Drawing.Point(635, 2);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(150, 44);
            this.panelTimer.TabIndex = 1;
            // 
            // pictureTimer
            // 
            this.pictureTimer.Location = new System.Drawing.Point(22, 5);
            this.pictureTimer.Name = "pictureTimer";
            this.pictureTimer.Size = new System.Drawing.Size(42, 34);
            this.pictureTimer.TabIndex = 1;
            this.pictureTimer.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(85, 10);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(63, 25);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Timer";
            // 
            // panelFlag
            // 
            this.panelFlag.Controls.Add(this.pictureFlag);
            this.panelFlag.Controls.Add(this.lblFlagImage);
            this.panelFlag.Controls.Add(this.lblNumberOfFlag);
            this.panelFlag.Location = new System.Drawing.Point(481, 2);
            this.panelFlag.Name = "panelFlag";
            this.panelFlag.Size = new System.Drawing.Size(148, 44);
            this.panelFlag.TabIndex = 1;
            // 
            // pictureFlag
            // 
            this.pictureFlag.Location = new System.Drawing.Point(22, 5);
            this.pictureFlag.Name = "pictureFlag";
            this.pictureFlag.Size = new System.Drawing.Size(57, 34);
            this.pictureFlag.TabIndex = 1;
            this.pictureFlag.TabStop = false;
            // 
            // lblFlagImage
            // 
            this.lblFlagImage.AutoSize = true;
            this.lblFlagImage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFlagImage.ForeColor = System.Drawing.Color.Red;
            this.lblFlagImage.Location = new System.Drawing.Point(3, 8);
            this.lblFlagImage.Name = "lblFlagImage";
            this.lblFlagImage.Size = new System.Drawing.Size(0, 25);
            this.lblFlagImage.TabIndex = 0;
            // 
            // lblNumberOfFlag
            // 
            this.lblNumberOfFlag.AutoSize = true;
            this.lblNumberOfFlag.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfFlag.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfFlag.Location = new System.Drawing.Point(85, 8);
            this.lblNumberOfFlag.Name = "lblNumberOfFlag";
            this.lblNumberOfFlag.Size = new System.Drawing.Size(49, 25);
            this.lblNumberOfFlag.TabIndex = 0;
            this.lblNumberOfFlag.Text = "Flag";
            // 
            // panelGameType
            // 
            this.panelGameType.Controls.Add(this.cmbTimerType);
            this.panelGameType.Controls.Add(this.cmbGameType);
            this.panelGameType.Location = new System.Drawing.Point(3, 2);
            this.panelGameType.Name = "panelGameType";
            this.panelGameType.Size = new System.Drawing.Size(302, 44);
            this.panelGameType.TabIndex = 1;
            // 
            // cmbTimerType
            // 
            this.cmbTimerType.BackColor = System.Drawing.Color.Gold;
            this.cmbTimerType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTimerType.ForeColor = System.Drawing.Color.Red;
            this.cmbTimerType.FormattingEnabled = true;
            this.cmbTimerType.Location = new System.Drawing.Point(162, 10);
            this.cmbTimerType.Name = "cmbTimerType";
            this.cmbTimerType.Size = new System.Drawing.Size(121, 29);
            this.cmbTimerType.TabIndex = 1;
            this.cmbTimerType.SelectedIndexChanged += new System.EventHandler(this.cmbTimerType_SelectedIndexChanged);
            // 
            // cmbGameType
            // 
            this.cmbGameType.BackColor = System.Drawing.Color.Gold;
            this.cmbGameType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbGameType.ForeColor = System.Drawing.Color.Red;
            this.cmbGameType.FormattingEnabled = true;
            this.cmbGameType.Location = new System.Drawing.Point(3, 10);
            this.cmbGameType.Name = "cmbGameType";
            this.cmbGameType.Size = new System.Drawing.Size(121, 29);
            this.cmbGameType.TabIndex = 1;
            this.cmbGameType.SelectedIndexChanged += new System.EventHandler(this.cmbGameType_SelectedIndexChanged);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WidgetContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MineSweeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.WidgetContainer.ResumeLayout(false);
            this.StatusPanel.ResumeLayout(false);
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTimer)).EndInit();
            this.panelFlag.ResumeLayout(false);
            this.panelFlag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).EndInit();
            this.panelGameType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WidgetContainer;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panelFlag;
        private System.Windows.Forms.Label lblNumberOfFlag;
        private System.Windows.Forms.Panel panelGameType;
        private System.Windows.Forms.ComboBox cmbTimerType;
        private System.Windows.Forms.ComboBox cmbGameType;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblFlagImage;
        private System.Windows.Forms.PictureBox pictureTimer;
        private System.Windows.Forms.PictureBox pictureFlag;
    }
}

