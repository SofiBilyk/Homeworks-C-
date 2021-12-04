using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class Dom : IStrategy
    {
        XmlDocument doc = new XmlDocument();

        public Dom(string path)
        {
            doc.Load(path);
        }

        public List<Sportsman> Algorithm(Sportsman sportsman, string path)
        {
            List<List<Sportsman>> info = new List<List<Sportsman>>();
            try
            {
                if (sportsman.Section != null) info.Add(SearchByParam("section", "SECTION", sportsman.Section, doc, 0));
                if (sportsman.Name != null) info.Add(SearchByParam("name", "NAME", sportsman.Name, doc, 2));
                if (sportsman.Surname != null) info.Add(SearchByParam("surname", "SURNAME", sportsman.Surname, doc, 2));
                if (sportsman.Faculty != null) info.Add(SearchByParam("faculty", "FACULTY", sportsman.Faculty, doc, 2));
                if (sportsman.Schedule != null) info.Add(SearchByParam("schedule", "SCHEDULE", sportsman.Schedule, doc, 2));
                if (sportsman.Competition != null) info.Add(SearchByParam("competition", "COMPETITION", sportsman.Competition, doc, 2));
                if (sportsman.Visitor != null) info.Add(SearchByParam("visitor", "VISITOR", sportsman.Visitor, doc, 1));

            }
            catch { }

            return Cross(info);
        }

        private List<Sportsman> SearchByParam(string v1, string v2, (object Name, XmlDocument doc, int) p)
        {
            throw new NotImplementedException();
        }

        private List<Sportsman> Cross(List<List<Sportsman>> info)
        {
            throw new NotImplementedException();
        }

        private List<Sportsman> SearchByParam(string v1, string v2, object section, XmlDocument doc, int v3)
        {
            throw new NotImplementedException();
        }
    }
     

}
