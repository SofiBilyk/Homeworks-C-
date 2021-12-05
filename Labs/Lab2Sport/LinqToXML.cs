using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Lab2Sport
{
    class LinqToXML : IAnalizatorXMLStrategy
    {
        private List<Sportsmans> find = null;
        XDocument doc = new XDocument();

        public List<Sportsmans> AnalyzeFile(Sportsmans mySearch, string path)
        {
            doc = XDocument.Load(@path);
            find = new List<Sportsmans>();
            List<XElement> matches = (from val in doc.Descendants("Sportsman")
                                      where ((mySearch.Section == null || mySearch.Section == val.Attribute("Setion").Value) &&
                                      (mySearch.Status == null || mySearch.Status == val.Attribute("Status").Value) &&
                                      (mySearch.Name == null || mySearch.Name  == val.Attribute("Name").Value) &&
                                      (mySearch.Surname == null || mySearch.Surname == val.Attribute("Surname").Value) &&
                                      (mySearch.Schedule == null || mySearch.Schedule == val.Attribute("Schedule").Value) &&
                                      (mySearch.Competition == null || mySearch.Competition == val.Attribute("Competition").Value))
                                      select val).ToList();
            foreach (XElement match in matches)
            {
                Sportsmans res = new Sportsmans();
                res.Section = match.Attribute("Section").Value;
                res.Status = match.Attribute("Status").Value;
                res.Name = match.Attribute("Name").Value;
                res.Surname = match.Attribute("Surname").Value;
                res.Schedule = match.Attribute("Schedule").Value;
                res.Competition = match.Attribute("Competition").Value;
                find.Add(res);
            }
            return find;
        }
    }
}
