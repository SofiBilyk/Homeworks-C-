using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                                    ((sportsman.Section == null || sportsman.Section == val.Parent.Parent.Attribute("SECTION").Value) &&
                                    (sportsman.Visitor == null || sportsman.Visitor == val.Parent.Attribute("VISITOR").Value) &&
                                    (sportsman.Name == null || sportsman.Name == val.Attribute("NAME").Value) &&
                                    (sportsman.Surname == null || sportsman.Surname == val.Attribute("SURNAME").Value) &&
                                    (sportsman.Faculty == null || sportsman.Faculty == val.Attribute("FACULTY").Value) &&
                                    (sportsman.Schedule == null || sportsman.Schedule == val.Attribute("SCHEDULE").Value) &&
                                    (sportsman.Competition == null || sportsman.Competition == val.Attribute("COMPETITION").Value))
                                    select val).ToList();
            foreach (XElement obj in match)
            {
                Sportsman sportsman1 = new Sportsman();
                sportsman1.Section = obj.Parent.Parent.Attribute("SECTION").Value;
                sportsman1.Visitor = obj.Parent.Attribute("VISITOR").Value;
                sportsman1.Name = obj.Attribute("NAME").Value;
                sportsman1.Surname = obj.Attribute("SURNAME").Value;
                sportsman1.Faculty = obj.Attribute("FACULTY").Value;
                sportsman1.Schedule = obj.Attribute("SCHEDULE").Value;
                sportsman1.Competition = obj.Attribute("COMPETITION").Value;
                
            }
            return info;
        }

    }
}
