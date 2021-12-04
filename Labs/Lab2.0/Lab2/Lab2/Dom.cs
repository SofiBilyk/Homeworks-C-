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
                if (sportsman.Visitor != null) info.Add(SearchByParam("visitor", "VISITOR", sportsman.Visitor, doc, 1));
                if (sportsman.Name != null) info.Add(SearchByParam("name", "NAME", sportsman.Name, doc, 2));
                if (sportsman.Surname != null) info.Add(SearchByParam("surname", "SURNAME", sportsman.Surname, doc, 2));
                if (sportsman.Faculty != null) info.Add(SearchByParam("faculty", "FACULTY", sportsman.Faculty, doc, 2));
                if (sportsman.Schedule != null) info.Add(SearchByParam("schedule", "SCHEDULE", sportsman.Schedule, doc, 2));
                if (sportsman.Competition != null) info.Add(SearchByParam("competition", "COMPETITION", sportsman.Competition, doc, 2));

            }
            catch { }

            return Cross(info);
        }

        public static Sportsman Info(XmlNode node)
        {
            Sportsman nw = new Sportsman();
            nw.Section = node.ParentNode.ParentNode.Attributes.GetNamedItem("SECTION").Value;
            nw.Visitor = node.ParentNode.Attributes.GetNamedItem("VISITOR").Value;
            nw.Name = node.Attributes.GetNamedItem("NAME").Value;
            nw.Surname = node.Attributes.GetNamedItem("SURNAME").Value;
            nw.Faculty = node.Attributes.GetNamedItem("FACULTY").Value;
            nw.Schedule = node.Attributes.GetNamedItem("SCHEDULE").Value;
            nw.Competition = node.Attributes.GetNamedItem("COMPETITION").Value;
            
            return nw;
        }

        public static List<Sportsman> AllSportsmans(XmlDocument doc)
        {
            List<Sportsman> data2 = new List<Sportsman>();
            XmlNodeList elem = doc.SelectNodes("//student");
            try
            {
                foreach (XmlNode el in elem)
                {
                    data2.Add(Info(el));
                }
            }
            catch { }
            return data2;
        }

        public static List<Sportsman> SearchByParam(string nodename, string val, string param, XmlDocument doc, int n)
        {
            List<Sportsman> sportsmans = new List<Sportsman>();
            if (string.IsNullOrWhiteSpace(param))
            {
                return sportsmans;
            }
            switch (n)
            {
                case 0:
                    {
                        XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                        try
                        {
                            foreach (XmlNode e in elem)
                            {
                                XmlNodeList list1 = e.ChildNodes;
                                foreach (XmlNode el in list1)
                                {
                                    XmlNodeList list2 = el.ChildNodes;
                                    foreach (XmlNode el1 in list2)
                                    {
                                        sportsmans.Add(Info(el1));
                                    }
                                }
                            }
                        }
                        catch { return sportsmans; }

                        break;
                    }
                case 1:
                    {
                        XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                        try
                        {
                            foreach (XmlNode e in elem)
                            {
                                XmlNodeList list1 = e.ChildNodes;
                                foreach (XmlNode el in list1)
                                {

                                    sportsmans.Add(Info(el));

                                }
                            }
                        }
                        catch { return sportsmans; }
                        break;
                    }
                case 2:
                    {
                        XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                        try
                        {
                            foreach (XmlNode e in elem)
                            {
                                sportsmans.Add(Info(e));
                            }
                        }
                        catch { return sportsmans; }
                        break;
                    }
                default:
                    {
                        return sportsmans;
                    }

            }
            return sportsmans;
        }
        public static List<Sportsman> Cross(List<List<Sportsman>> list)
        {
            List<Sportsman> result = new List<Sportsman>();
            try
            {
                if (list != null)
                {
                    Sportsman[] st = list[0].ToArray();
                    if (st != null)
                    {
                        foreach (Sportsman elem in st)
                        {
                            bool IsIn = true;
                            foreach (List<Sportsman> t in list)
                            {
                                if (t.Count <= 0) return new List<Sportsman>();

                                foreach (Sportsman s in t)
                                {
                                    IsIn = false;
                                    if (elem.Comparing(s))
                                    {
                                        IsIn = true;
                                        break;
                                    }
                                }
                                if (!IsIn) break;
                            }
                            if (IsIn)
                            {
                                result.Add(elem);
                            }
                        }
                    }
                }
            }
            catch { }
            return result;
        }




    }
    
}
