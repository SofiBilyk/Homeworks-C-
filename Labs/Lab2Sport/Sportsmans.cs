using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sport
{
    public class Sportsmans
    {
        public string Section = null;
        public string Status = null;
        public string Name = null;
        public string Surname = null;
        public string Schedule = null;
        public string Competition = null;

        public Sportsmans() { }

        public Sportsmans(string[] data)
        {
            Section = data[0];
            Status = data[1];
            Section = data[2];
            Surname = data[3];
            Schedule = data[4];
            Competition = data[5];
        }
        public bool Compare(Sportsmans obj)
        {
            if ((this.Section == obj.Section) &&
                (this.Status == obj.Status) &&
                (this.Section == obj.Section) &&
                (this.Surname == obj.Surname) &&
                (this.Schedule == obj.Schedule) &&
                (this.Competition == obj.Competition))
            {
                return true;
            }
            else return false;
        }
    }
}
