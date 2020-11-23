using System;
using System.Collections.Generic;

namespace Lernzeit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zeiterfassung> zeiterfassungen = new List<Zeiterfassung>();

            zeiterfassungen.Add(new Zeiterfassung(60, "Programmierung"));
            zeiterfassungen.Add(new Zeiterfassung(123, "Mathematik"));
            zeiterfassungen.Add(new Zeiterfassung(25, "Deutsch"));
        }
    }
}
