using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Lab2Sport
{
    class SAX : IAnalizatorXMLStrategy
    {
        public List<Sportsmans> AnalyzeFile(Sportsmans sportsman, string path)
        {
            List<Sportsmans> AllResults = new List<Sportsmans>();
            var xmlReader = new XmlTextReader(path);
            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        string Section = "";
                        string Status = "";
                        string Name = "";
                        string Surname = "";
                        string Schedule = "";
                        string Competition = "";

                        if (xmlReader.Name.Equals("Section") && (xmlReader.Value.Equals(sportsman.Section) || sportsman.Section == null))
                        {
                            Section = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("Status") && (xmlReader.Value.Equals(sportsman.Status) || sportsman.Status == null))
                            {
                                Status = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("Name") && (xmlReader.Value.Equals(sportsman.Name) || sportsman.Name == null))
                                {
                                    Name = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("Surname") && (xmlReader.Value.Equals(sportsman.Surname) || sportsman.Surname == null))
                                    {
                                        Surname = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();

                                        if (xmlReader.Name.Equals("Schedule") && (xmlReader.Value.Equals(sportsman.Schedule) || sportsman.Schedule == null))
                                        {
                                            Schedule = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();

                                            if (xmlReader.Name.Equals("Competition") && (xmlReader.Value.Equals(sportsman.Competition) || sportsman.Competition == null))
                                            {
                                                Competition = xmlReader.Value;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        if (Section != "" && Status != "" && Name != "" && Surname != "" && Schedule != "" && Competition != "")
                        {
                            Sportsmans mySportsman = new Sportsmans();
                            mySportsman.Section = Section;
                            mySportsman.Status = Status;
                            mySportsman.Name = Name;
                            mySportsman.Surname = Surname;
                            mySportsman.Schedule = Schedule;
                            mySportsman.Competition = Competition;

                            AllResults.Add(mySportsman);
                        }
                    }
                }
            }
            xmlReader.Close();
            return AllResults;
        }
    }
}
