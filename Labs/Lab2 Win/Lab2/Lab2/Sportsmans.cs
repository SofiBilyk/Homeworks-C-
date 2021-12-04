using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Sportsmans
    {
        public string section = null;
        public string status = null;
        public string name = null;
        public string surname = null;
        public string schedule = null;
        public string competition = null;

        public Sportsmans() { }

        public Sportsmans(string[] data)
        {
            section = data[0];
            status = data[1];
            name = data[2];
            surname = data[3];
            schedule = data[4];
            competition = data[5];
        }

        public bool Compare(Sportsmans obj)
        {
            if ((this.section == obj.section) &&
                (this.status == obj.status) &&
                (this.name == obj.name) &&
                (this.surname == obj.surname) &&
                (this.schedule == obj.schedule) &&
                (this.competition == obj.competition))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
