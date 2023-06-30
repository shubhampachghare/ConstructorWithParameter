using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAsics
{
    class Constructor
    {
        public string Model ;
        public string Color;
        public int Year;

        public Constructor (string Model,string Color, int Year)
        {   
           this.Model = Model;
            this.Color = Color;
            this.Year = Year;
        }
    }
}
