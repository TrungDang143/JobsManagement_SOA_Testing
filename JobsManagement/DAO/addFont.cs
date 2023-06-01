using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsManagement.DAO
{
    internal class addFont
    {
        public static void newFont()
        {
            PrivateFontCollection newFont = new PrivateFontCollection();
            newFont.AddFontFile(@".\JobsManagement\Font\DIGIFACE.ttf");
        }
    }
}
