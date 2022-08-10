using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MineCell : UserControl
    {
        public MineCell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MineCell_Load(object sender, EventArgs e)
        {
            btnMineCell.Size = new Size((Point)this.Size);
            //this.Parent.Parent.Widge
        }
    }
}
