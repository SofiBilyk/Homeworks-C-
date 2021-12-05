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
    class DOM : IAnalizatorXMLStrategy
    {
        XmlDocument doc = new XmlDocument();

        public List<Sportsmans> AnalyzeFile(Sportsmans mySearch, string path)
        {
            doc.Load(@path);
            List<List<Sportsmans>> info = new List<List<Sportsmans>>();

            if (mySearch.Section == null && mySearch.Status == null && mySearch.Section == null && mySearch.Surname == null && mySearch.Schedule == null && mySearch.Competition == null)
            {
                return ErrorCatch(doc);
            }

            if (mySearch.Section != null) info.Add(SearchByAttribute("Sportsman", "Section", mySearch.Section, doc));
            if (mySearch.Status != null) info.Add(SearchByAttribute("Sportsman", "Status", mySearch.Status, doc));
            if (mySearch.Name != null) info.Add(SearchByAttribute("Sportsman", "Name", mySearch.Name, doc));
            if (mySearch.Surname != null) info.Add(SearchByAttribute("Sportsman", "Surname", mySearch.Surname, doc));
            if (mySearch.Schedule != null) info.Add(SearchByAttribute("Sportsman", "Schedule", mySearch.Schedule, doc));
            if (mySearch.Competition != null) info.Add(SearchByAttribute("Sportsman", "Competition", mySearch.Competition, doc));

            return Cross(info, mySearch);
        }

        public List<Sportsmans> SearchByAttribute(string nodeName, string attribyte, string myTemplate, XmlDocument doc)
        {
            List<Sportsmans> find = new List<Sportsmans>();
            if (myTemplate != null)
            {
                XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + attribyte + "=\"" + myTemplate + "\"]");
                foreach (XmlNode e in lst)
                {
                    find.Add(Info(e));
                }
            }
            return find;
        }

        public List<Sportsmans> ErrorCatch(XmlDocument doc)
        {
            List<Sportsmans> result = new List<Sportsmans>();
            XmlNodeList lst = doc.SelectNodes("//" + "Sportsman");
            foreach (XmlNode elem in lst)
            {
                result.Add(Info(elem));
            }
            return result;
        }

        public Sportsmans Info(XmlNode node)
        {
            Sportsmans search = new Sportsmans();
            search.Section = node.Attributes.GetNamedItem("Section").Value;
            search.Status = node.Attributes.GetNamedItem("Status").Value;
            search.Name = node.Attributes.GetNamedItem("Name").Value;
            search.Surname = node.Attributes.GetNamedItem("Surname").Value;
            search.Schedule = node.Attributes.GetNamedItem("Schedule").Value;
            search.Competition = node.Attributes.GetNamedItem("Competition").Value;

            return search;
        }

        public List<Sportsmans> Cross(List<List<Sportsmans>> list, Sportsmans myTemplate)
        {
            List<Sportsmans> result = new List<Sportsmans>();
            List<Sportsmans> clear = CheckNodes(list, myTemplate);
            foreach (Sportsmans elem in clear)
            {
                bool isIn = false;
                foreach (Sportsmans s in result)
                {
                    if (s.Compare(elem))
                    {
                        isIn = true;
                    }
                }
                if (!isIn)
                {
                    result.Add(elem);
                }
            }
            return result;
        }

        public List<Sportsmans> CheckNodes(List<List<Sportsmans>> list, Sportsmans myTemplate)
        {
            List<Sportsmans> newResult = new List<Sportsmans>();
            foreach (List<Sportsmans> elem in list)
            {
                foreach (Sportsmans s in elem)
                {
                    if ((myTemplate.Section == s.Section || myTemplate.Section == null) &&
                        (myTemplate.Status == s.Status || myTemplate.Status == null) &&
                        (myTemplate.Name == s.Name || myTemplate.Name == null) &&
                        (myTemplate.Surname == s.Surname || myTemplate.Surname == null) &&
                        (myTemplate.Schedule == s.Schedule || myTemplate.Schedule == null) &&
                        (myTemplate.Competition == s.Competition || myTemplate.Competition == null))
                    {
                        newResult.Add(s);
                    }
                }
            }
            return newResult;
        }
    }
}
