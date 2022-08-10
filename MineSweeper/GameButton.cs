using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class GameButton : UserControl
    {
        public GameButton()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            MainWindow parentWindow = (MainWindow)this.Parent.Parent;//This will close the parent of parent of button: button's parent is panel and panel's parent is MainWindow
            string processType =btnProceed.Text;
            switch (processType) 
            {
                case "Play":
                    parentWindow.StartGame();
                    break;
                case "Score":
                    break;
                case "Quit":
                    parentWindow.Close();
                    break;
            }

        }
        public void ChangeText(string textIn) 
        {
            btnProceed.Text = textIn;
        }
    }
}
