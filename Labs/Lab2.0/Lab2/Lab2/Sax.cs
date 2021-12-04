using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class Sax : IStrategy
    {
        XmlDocument doc = new XmlDocument();

        public Sax(string path)
        {
            doc.Load(path);
        }

        public List<Sportsman> Algorithm(Sportsman sportsman, string path)
        {
            List<Sportsman> AllResult = new List<Sportsman>();
            var xmlReader = new XmlTextReader(@"DataBase.xml");
            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        string Section = "";
                        string Visitor = "";
                        string Name = "";
                        string Surname = "";
                        string Faculty = "";
                        string Schedule = "";
                        string Competition = "";

                        if (xmlReader.Name.Equals("Section") && (xmlReader.Value.Equals(sportsman.Section) || sportsman.Section.Equals(String.Empty)))
                        {
                            Section = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                            if (xmlReader.Name.Equals("Visitor") && (xmlReader.Value.Equals(sportsman.Visitor) || sportsman.Visitor.Equals(String.Empty)))
                            {
                                Visitor = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();
                                if (xmlReader.Name.Equals("Name") && (xmlReader.Value.Equals(sportsman.Name) || sportsman.Name.Equals(String.Empty)))
                                {
                                    Name = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();
                                    if (xmlReader.Name.Equals("Surname") && (xmlReader.Value.Equals(sportsman.Surname) || sportsman.Surname.Equals(String.Empty)))
                                    {
                                        Surname = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                        if (xmlReader.Name.Equals("Faculty") && (xmlReader.Value.Equals(sportsman.Faculty) || sportsman.Faculty.Equals(String.Empty)))
                                        {
                                            Faculty = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (xmlReader.Name.Equals("Schedule") && (xmlReader.Value.Equals(sportsman.Schedule) || sportsman.Schedule.Equals(String.Empty)))
                                            {
                                                Schedule = xmlReader.Value;
                                                xmlReader.MoveToNextAttribute();
                                                if (xmlReader.Name.Equals("Competition") && (xmlReader.Value.Equals(sportsman.Competition) || sportsman.Competition.Equals(String.Empty)))
                                                {
                                                    Competition = xmlReader.Value;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (Section != "" && Visitor != "" && Name != "" && Surname != "" && Faculty != "" && Schedule != "" && Competition != "")
                        {
                            Sportsman mySportsman = new Sportsman();
                            mySportsman.Section = Section;
                            mySportsman.Visitor = Visitor;
                            mySportsman.Name = Name;
                            mySportsman.Surname = Surname;
                            mySportsman.Faculty = Faculty;
                            mySportsman.Schedule = Schedule;
                            mySportsman.Competition = Competition;

                            AllResult.Add(mySportsman);
                        }
                    }
                    
                }
            }
            xmlReader.Close();
            return AllResult;
        }

       
      

    }
}
