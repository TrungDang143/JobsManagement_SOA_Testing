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
    public partial class ucCalendar : UserControl
    {
        public ucCalendar()
        {
            InitializeComponent();
            createMatrix();
        }

        #region Peoperties
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private List<string> dateOfW = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion

        void createMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(-6, 0),
            };
            for (int i = 0; i < 6; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button()
                    {
                        Width = 96,
                        Height = 50,
                        FlatStyle = FlatStyle.Flat
                    };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + 6, oldBtn.Location.Y + 1);

                    paMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(-6, oldBtn.Location.Y + 50)
                };
            }
            SetDate();
        }


        int dayOfM(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        void AddDay(DateTime date)
        {
            clear();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= dayOfM(date); i++)
            {
                int column = dateOfW.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                btn.Text = i.ToString();
                if (compareTime(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.Red;
                }
                if (compareTime(useDate, date))
                {
                    btn.BackColor = Color.Cyan;
                }

                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }

        void clear()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }
        }
        void SetDate()
        {
            dateTimePicker.Value = DateTime.Now;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(-1);
        }

        private void btnTom_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDate();
        }

        bool compareTime(DateTime A, DateTime B)
        {
            return A.Year == B.Year && A.Month == B.Month && A.Day == B.Day;
        }
        private void dtpkValueChanged(object sender, EventArgs e)
        {
            AddDay((sender as DateTimePicker).Value);
        }
    }
}
