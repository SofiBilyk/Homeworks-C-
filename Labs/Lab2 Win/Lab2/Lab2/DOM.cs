using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    public class DOM : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public List<Sportsmans> AnalizeFile(Sportsmans mySearch, string path)
        {
            doc.Load(path);
            List<List<Sportsmans>> info = new List<List<Sportsmans>>();
            if(mySearch.section == null && mySearch.status == null && mySearch.name == null && mySearch.surname == null && mySearch.schedule == null && mySearch.competition == null)
            {
                return ErrorCatch(doc);
            }

            if (mySearch.section != null) info.Add(SearchByAttribute("sportsman", "SECTION", mySearch.section, doc));
            if (mySearch.status != null) info.Add(SearchByAttribute("sportsman", "STATUS", mySearch.status, doc));
            if (mySearch.name != null) info.Add(SearchByAttribute("sportsman", "NAME", mySearch.name, doc));
            if (mySearch.surname != null) info.Add(SearchByAttribute("sportsman", "SURNAME", mySearch.surname, doc));
            if (mySearch.schedule != null) info.Add(SearchByAttribute("sportsman", "SCHEDULE", mySearch.schedule, doc));
            if (mySearch.competition != null) info.Add(SearchByAttribute("sportsman", "COMPETITIONS", mySearch.competition, doc));

            return Cross(info, mySearch);
        }

        public List<Sportsmans> SearchByAttribute(string nodeName, string attribute, string myTemplate, XmlDocument doc)
        {
            List<Sportsmans> find = new List<Sportsmans>();

            if(myTemplate != null)
            {
                XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\'" + myTemplate + "\"]");
                foreach(XmlNode e in lst)
                {
                    find.Add(Info(e));
                }
            }
            return find;
        }

        public List<Sportsmans> ErrorCatch(XmlNode node)
        {
            List<Sportsmans> result = new List<Sportsmans>();
            XmlNodeList lst = doc.SelectNodes("//" + "sportsman");
            foreach (XmlNode elem in lst)
            {
                result.Add(Info(elem));
            }
            return result;
        }

        public Sportsmans Info(XmlNode node)
        {
            Sportsmans search = new Sportsmans();
            search.section = node.Attributes.GetNamedItem("SECTION").Value;
            search.status = node.Attributes.GetNamedItem("STATUS").Value;
            search.name = node.Attributes.GetNamedItem("SURNAME").Value;
            search.surname = node.Attributes.GetNamedItem("SURNAME").Value;
            search.schedule = node.Attributes.GetNamedItem("SCHEDULE").Value;
            search.competition = node.Attributes.GetNamedItem("COMPETITIONS").Value;
            return search;
        }


        public List<Sportsmans> Cross(List<List<Sportsmans>> list, Sportsmans myTemplate)
        {
            List<Sportsmans> result = new List<Sportsmans>();
            List<Sportsmans> clear = CheckNodes(list, myTemplate);
            foreach(Sportsmans elem in clear)
            {
                bool IsIn = false;
                foreach(Sportsmans s in result)
                {
                    if (s.Compare(elem))
                    {
                        IsIn = true;
                    }
                }
                if (!IsIn)
                {
                    result.Add(elem);
                }
            }
            return result;
        }

        public List<Sportsmans> CheckNodes(List<List<Sportsmans>> list, Sportsmans myTemplate)
        {
            List<Sportsmans> newResult = new List<Sportsmans>();
            foreach(List<Sportsmans> elem in list)
            {
                foreach(Sportsmans s in elem)
                {
                    if ((myTemplate.section == s.section || myTemplate.section == null) &&
                        (myTemplate.status == s.section || myTemplate.status == null) &&
                        (myTemplate.name == s.section || myTemplate.name == null) &&
                        (myTemplate.surname == s.section || myTemplate.surname == null) &&
                        (myTemplate.schedule == s.section || myTemplate.schedule == null) &&
                        (myTemplate.competition == s.section || myTemplate.competition == null))
                    {
                        newResult.Add(s);
                    }
                }
            }
            return newResult;
        }

    }
}
