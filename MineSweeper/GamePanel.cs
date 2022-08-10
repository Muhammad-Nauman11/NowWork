using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class GamePanel : UserControl
    {
        public GamePanel()
        {
            InitializeComponent();
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            int windowW, windowH;

            windowW = this.Parent.Size.Width;
            windowH = this.Parent.Size.Height;
            this.Size = new Size(windowW-windowW/5,windowH-windowH/6);
            this.Location = new Point((windowW-this.Size.Width)/2,(windowH-this.Size.Height)/2);
            
        }
        public void button1_Click(object sender, EventArgs e) 
        {
            Console.WriteLine();
        }
    }
}
