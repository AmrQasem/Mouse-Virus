using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseVirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        Point DPosition;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DPosition.X = 0;
            DPosition.Y = 0;
            Cursor.Position = DPosition;
        }
    }
}
