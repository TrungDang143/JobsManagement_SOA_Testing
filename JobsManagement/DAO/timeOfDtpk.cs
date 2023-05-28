using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DAO
{
    internal class timeOfDtpk
    {
        private static DateTime timeSelection = DateTime.Now;

        public static DateTime TimeSelection { get => timeSelection; set => timeSelection = value; }
    }
}
