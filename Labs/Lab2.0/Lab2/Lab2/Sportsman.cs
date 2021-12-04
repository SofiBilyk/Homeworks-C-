using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Sportsman
    {
        public string Section = null;
        public string Visitor = null;
        public string Name = null;
        public string Surname = null;
        public string Faculty = null;
        public string Schedule = null;
        public string Competition = null;

        public Sportsman() { }

        public Sportsman(string[] data)
        {
            Section = data[0];
            Visitor = data[0];
            Name = data[1];
            Surname = data[2];
            Faculty = data[3];
            Schedule = data[4];
            Competition = data[5];
        }
        public Sportsman(IStrategy algo)
        {
            Section = String.Empty;
            Visitor = String.Empty;
            Name = String.Empty;
            Surname = String.Empty;
            Faculty = String.Empty;
            Schedule = String.Empty;
            Competition = String.Empty;
        }

        public bool Comparing(Sportsman sportsman)
        {
            if ((this.Section == sportsman.Section) &&
                (this.Visitor == sportsman.Visitor) &&
                (this.Name == sportsman.Name) &&
                (this.Surname == sportsman.Surname) &&
                (this.Faculty == sportsman.Faculty) &&
                (this.Schedule == sportsman.Schedule) &&
                (this.Competition == sportsman.Competition))
                return true;
            else return false;

        }

        public IStrategy Algo { get; set; }

        public List<Sportsman> Algorithm(Sportsman param, string path)
        {
            return Algo.Algorithm(param, path);
        }

    }
}
