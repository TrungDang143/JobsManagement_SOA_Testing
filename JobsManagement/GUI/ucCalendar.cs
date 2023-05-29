using JobsManagement.DAO;
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
            dtpk.Value = timeOfDtpk.TimeSelection;
        }

        #region ma tran lich
        #region thong so
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private List<string> dateOfW = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int btnW = 96;
        int btnH = 62;
        int margin = 6;
        #endregion

        void createMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(-margin, 0),
            };
            for (int i = 0; i < 6; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 7; j++)
                {
                    Button btn = new Button()
                    {
                        Width = btnW,
                        Height = btnH,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.White,
                        ForeColor = Color.Black
                    };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + margin, oldBtn.Location.Y);
                    paMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    btn.Click += Btn_Click;
                    btn.MouseEnter += Btn_MouseEnter;

                    oldBtn = btn;
                }
                oldBtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(-margin, oldBtn.Location.Y + btnH + 4)
                };
            }
            HienNgay(timeOfDtpk.TimeSelection);
            
        }

        bool compareTime(DateTime A, DateTime B)
        {
            return A.Year == B.Year && A.Month == B.Month && A.Day == B.Day;
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
        private void HienNgay(DateTime date)
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
                
                //btn.Image = Properties.Resources.rsz_icons8_dot_30;
                //btn.ImageAlign = ContentAlignment.BottomRight;

                if (compareTime(useDate, date))
                {
                    clearColor();
                    btn.BackColor = Color.Yellow;
                }
                if (compareTime(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }

        private void clear()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        private void clearColor()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    if(btn.BackColor != Color.Aqua)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                        btn.FlatAppearance.BorderSize = 0;
                    }    
                }
            }
        }
        private void clearBorder()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    if (btn.BackColor != Color.Aqua)
                    {
                        btn.FlatAppearance.BorderSize = 0;
                    }
                }
            }
        }

        #endregion

        private void chonThu(int vt)
        {
            clearColor();
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    if (j == vt && !string.IsNullOrEmpty(btn.Text)&& btn.BackColor!=Color.Aqua)
                    {
                        btn.BackColor = Color.Yellow;
                    }
                }
            }

            string ngay = DateTime.Now.Day.ToString();
            DateTime time = DateTime.Now;
            for (int i = 0; i < Matrix.Count; i++)
            {
                bool done = false;
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    if (Matrix[i][j].Text.ToString() == ngay)
                    {
                        if(vt < j)
                        {
                                time = time.AddDays(7 + vt - j);                
                        }
                        else
                        {
                            time = time.AddDays(vt - j);
                        }
                        done = true;
                    }
                }
                if (done) break;
            }

            fAddJob f = new fAddJob(time, vt);
            f.ShowDialog();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            
            if (string.IsNullOrEmpty(btn.Text))
                return;

            DateTime dateOfCalendar = new DateTime(dtpk.Value.Year, dtpk.Value.Month, Convert.ToInt32(btn.Text));

            dtpk.Value = dateOfCalendar;

            clearColor();
            btn.BackColor = Color.Yellow;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            clearBorder();
            Button btn = (sender as Button);
            btn.FlatAppearance.BorderColor = Color.Red;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddMonths(1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddMonths(-1);
        }

        private void btnTom_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(1);
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }

        private void dtpkValueChanged(object sender, EventArgs e)
        {
            HienNgay((sender as DateTimePicker).Value);
            timeOfDtpk.TimeSelection = dtpk.Value;
        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            int vt;
            if (btn.Text == "Thứ 2")
                vt = 0;
            else if (btn.Text == "Thứ 3")
                vt = 1;
            else if (btn.Text == "Thứ 4")
                vt = 2;
            else if (btn.Text == "Thứ 5")
                vt = 3;
            else if (btn.Text == "Thứ 6")
                vt = 4;
            else if (btn.Text == "Thứ 7")
                vt = 5;
            else vt = 6;
            chonThu(vt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            mainUI mainF = panel.Parent as mainUI;

            mainF.dateOfdtpk = timeOfDtpk.TimeSelection;

            button2.Click += mainF.btnHome_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fAddJob f = new fAddJob(dtpk.Value, -1);
            f.ShowDialog();
        }
    }
}
