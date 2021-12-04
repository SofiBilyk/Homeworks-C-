using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Linq : IStrategy
    {
        List<Sportsman> info = new List<Sportsman>();
        XDocument doc = new XDocument();

        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Sportsman> Algorithm(Sportsman sportsman, string path)
        {
            List<XElement> match = (from val in doc.Descendants("sportsman")
                                    where
                                    ((sportsman.Section == null || sportsman.Section == val.Parent.Parent.Atribute("SECTION").Value) &&
                                    (sportsman.Name == null || sportsman.Name == val.Atribute("NAME").Value) &&
                                    (sportsman.Surname == null || sportsman.Surname == val.Atribute("SURNAME").Value) &&
                                    (sportsman.Faculty == null || sportsman.Faculty == val.Atribute("FACULTY").Value) &&
                                    (sportsman.Schedule == null || sportsman.Schedule == val.Atribute("SCHEDULE").Value) &&
                                    (sportsman.Competition == null || sportsman.Competition == val.Atribute("COMPETITION").Value) &&
                                    (sportsman.Visitor == null || sportsman.Visitor == val.Parent.Atribute("VISITOR").Value))
                                    select val).ToList();
            foreach (XElement obj in match)
            {
                Sportsman sportsman1 = new Sportsman();
                sportsman1.Section = obj.Parent.Parent.Atribute("SECTION").Value;
                sportsman1.Name = obj.Atribute("NAME").Value;
                sportsman1.Surname = obj.Atribute("SURNAME").Value;
                sportsman1.Faculty = obj.Atribute("FACULTY").Value;
                sportsman1.Schedule = obj.Atribute("SCHEDULE").Value;
                sportsman1.Competition = obj.Atribute("COMPETITION").Value;
                sportsman1.Visitor = obj.Atribute("VISITOR").Value;
            }
            return info;
        }
    }
}
