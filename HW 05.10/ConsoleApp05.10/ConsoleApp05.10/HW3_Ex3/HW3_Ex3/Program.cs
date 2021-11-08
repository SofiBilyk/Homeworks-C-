using System;

namespace HW3_Ex3
{
    class Converter
    {
        private double usd;
        private double eur;
        private double result = 0;
        public Converter()
        {
            usd = 26.050;
            eur = 30.000;
        }
        public void Convert()
        {
            Console.WriteLine("Яку валюту ви хочете конвертувати (grn, usd, eur)");
            string from = Console.ReadLine();

            Console.WriteLine("Яку суму?");
            double sum = double.Parse(Console.ReadLine());

            Console.WriteLine("В яку валюту бажаєте конвертувати (grn, usd, eur)");
            string to = Console.ReadLine();

           /* if (from != "usd" || from != "eur" || from != "grn" || to != "usd" || to != "eur" || to != "grn")
            { Console.WriteLine("Напишіть назву валют правильно"); }*/

            switch (from)
            {
                case "grn":
                        switch (to)
                        {
                            case "grn": result = sum; break;
                            case "usd": GrnUsd(sum); break;
                            case "eur": GrnEur(sum); break;
                            default:
                                Console.WriteLine("Напишiть назву валют правильно");
                                break;
                        }
                 
                    break;
                case "usd":
                    switch (to)
                    {
                        case "grn": UsdGrn(sum); break;
                        case "usd": result = sum; break;
                        case "eur": UsdEur(sum); break;
                        default:
                            Console.WriteLine("Напишiть назву валют правильно");
                            break;
                    }
        
                    break;
                case "eur":
                    switch (to)
                    {
                        case "grn":EurGrn(sum); break;
                        case "usd":EurUsd(sum); break;
                        case "eur": result = sum; break;
                        default:
                            Console.WriteLine("Напишiть назву валют правильно");
                            break;
                    }
             
                    break;
                default:
                    Console.WriteLine("Напишiть назву валют правильно");
                    break;
            }

            Console.WriteLine("");
            if (result != 0)
            {
                Console.WriteLine(sum + " " + from + " = " + result + " " + to);
                result = 0;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Convert();
        }
        private double GrnUsd(double sum)
        {
            return result = sum / usd;
        }
        private double GrnEur(double sum)
        {
            return result = sum / eur;
        }
        private double UsdGrn(double sum)
        {
            return result =  sum * usd;
        }
        private double EurGrn(double sum)
        {
            return result =  sum * eur;
        }
        private double UsdEur(double sum)
        {
            return result = sum * (usd/eur);
        }
        private double EurUsd(double sum)
        {
            return result = sum * (eur / usd);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter p = new Converter();
            p.Convert();
        }
    }
}
