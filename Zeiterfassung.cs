using System;
using System.Collections.Generic;
using System.Text;

namespace Lernzeit
{
    public class Zeiterfassung
    {
        public int Lernzeit { get; set; }

        public string Fach { get; set; }

        public Zeiterfassung(int lernzeit, string fach)
        {
            this.Lernzeit = lernzeit;
            this.Fach = fach;
        }
    }
}
