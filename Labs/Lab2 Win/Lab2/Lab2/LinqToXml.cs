using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    class LinqToXml : IStrategy
    {
        private List<Sportsmans> find = null;
        XDocument doc = new XDocument();

        public List<Sportsmans> AnalizeFile(Sportsmans mySearch, string path)
        {
            doc = XDocument.Load(@path);
            find = new List<Sportsmans>();
            List<XElement> matches = (from val in doc.Descendants("sportsman")
                                      where ((mySearch.section == null || mySearch.section == val.Attribute("SECTION").Value) &&
                                      (mySearch.status == null || mySearch.status == val.Attribute("STATUS").Value) &&
                                      (mySearch.name == null || mySearch.name == val.Attribute("NAME").Value) &&
                                      (mySearch.surname == null || mySearch.surname == val.Attribute("SURNAME").Value) &&
                                      (mySearch.schedule == null || mySearch.schedule == val.Attribute("SCHEDULE").Value) &&
                                      (mySearch.competition == null || mySearch.competition == val.Attribute("COMPETITIONS").Value))
                                      select val).ToList();
            foreach(XElement match in matches)
            {
                Sportsmans res = new Sportsmans();
                res.section = match.Attribute("SECTION").Value;
                res.status = match.Attribute("STATUS").Value;
                res.name = match.Attribute("NAME").Value;
                res.surname = match.Attribute("SURNAME").Value;
                res.schedule = match.Attribute("SCHEDULE").Value;
                res.competition = match.Attribute("COMPETITIONS").Value;
                find.Add(res);
            }

            return find;
        }
    }
}
