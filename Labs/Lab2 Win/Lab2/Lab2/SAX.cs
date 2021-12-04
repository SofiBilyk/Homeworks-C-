using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    public class SAX : IStrategy
    {
        private List<Sportsmans> lastResult = null;

        public List<Sportsmans> AnalizeFile(Sportsmans mySearch, string path)
        {
            XmlReader reader = XmlReader.Create(path);
            List<Sportsmans> result = new List<Sportsmans>();

            Sportsmans find = null;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if(reader.Name == "sportsman")
                        {
                            find = new Sportsmans();

                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "SECTION")
                                {
                                    find.section = reader.Value;
                                }
                                if (reader.Name == "STATUS")
                                {
                                    find.status = reader.Value;
                                }
                                if (reader.Name == "NAME")
                                {
                                    find.name = reader.Value;
                                }
                                if (reader.Name == "SURNAME")
                                {
                                    find.surname = reader.Value;
                                }
                                if (reader.Name == "SCHEDULE")
                                {
                                    find.schedule = reader.Value;
                                }
                                if (reader.Name == "COMPETITION")
                                {
                                    find.competition = reader.Value;
                                }
                            }

                            result.Add(find);
                        }
                        break;
                }
            }
            lastResult = Filter(result, mySearch);
            return lastResult;
        }


        private List<Sportsmans> Filter(List<Sportsmans> allRes, Sportsmans myTemplate)
        {
            List<Sportsmans> newResult = new List<Sportsmans>();
            if(allRes != null)
            {
                foreach(Sportsmans i in allRes)
                {
                    if((myTemplate.section == i.section || myTemplate.section == null)&&
                        (myTemplate.status == i.status || myTemplate.status == null) &&
                        (myTemplate.name == i.name || myTemplate.name == null) &&
                        (myTemplate.surname == i.surname || myTemplate.surname == null) &&
                        (myTemplate.schedule == i.schedule || myTemplate.schedule == null) &&
                        (myTemplate.competition == i.competition || myTemplate.competition == null))
                    {
                        newResult.Add(i);
                    }
                }
            }
            return newResult;
        }
    }
}
