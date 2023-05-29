using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DTO
{
    internal class LapLai
    {
        private string lap = "";

        public LapLai(int i) {
            switch (i)
            {
                case 0: Lap = "";
                    break;
                case 1:
                    Lap = "Hằng ngày";
                    break;
                case 2:
                    Lap = "T2";
                    break;
                case 3:
                    Lap = "T3";
                    break;
                case 4:
                    Lap = "T4";
                    break;
                case 5:
                    Lap = "T5";
                    break;
                case 6:
                    Lap = "T6";
                    break;
                case 7:
                    Lap = "T7";
                    break;
                default:
                    Lap = "CN";
                    break;
            }
        }

        public string Lap { get => lap; set => lap = value; }
    }
}
