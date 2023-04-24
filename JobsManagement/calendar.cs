using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsManagement
{
    public partial class fCalendar : Form
    {
        public fCalendar()
        {
            InitializeComponent();
            createMatrix();
        }
        void createMatrix()
        {
            Button oldBtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(-6, 0),
            };
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Button btn = new Button()
                    {
                        Width = 96, Height = 51
                    };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + 6, oldBtn.Location.Y);

                    paMatrix.Controls.Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button()
                {
                    Width = 0, Height = 0, Location = new Point(-6, oldBtn.Location.Y + 51)
                };
            }
        }
        private void btnWed_Click(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {

        }

        private void fCalendar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
