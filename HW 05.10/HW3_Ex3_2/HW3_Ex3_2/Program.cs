using System;

namespace HW3_Ex3_2
{
  
    public class Converter
    {
        double usd;
        double eur;
        double sum;
        public Converter(double _usd, double _eur)
        {
            usd = _usd;
            eur = _eur;
        }
        public double Try()
        {
            double suma;
            bool indecate = double.TryParse(Console.ReadLine(), out suma);
            while (indecate == false || suma <= 0)
            {
                Console.WriteLine("Write correct sum");
                indecate = double.TryParse(Console.ReadLine(), out suma);
            }
            return suma;
        }
        public void Grn_To_Usd()
        {
            Console.WriteLine("How much grn do you wanna change?");
            sum = Try();
            Console.WriteLine("You get: "+ (sum/usd).ToString() + " USD");
        }

        public void Grn_To_Eur()
        {
            Console.WriteLine("How much grn do you wanna change?");
            sum = Try();
            Console.WriteLine("You get: " + (sum / eur).ToString() + " EUR");
        }

        public void Usd_To_Grn()
        {
            Console.WriteLine("How much usd do you wanna change?");
            sum = Try();
            Console.WriteLine("You get: " + (sum * usd).ToString() + " GRN");
        }
        public void Eur_To_Grn()
        {
            Console.WriteLine("How much eur do you wanna change?");
            sum = Try();
            Console.WriteLine("You get: " + (sum * eur).ToString() + " GRN");
        }
    }

    class Converte : Converter
    {
        string what;
        string to;
        public Converte(double _usd, double _eur) : base(_usd, _eur)
        {
            Console.WriteLine("What do you wanna convert? (grn, usd, eur)");
            what = Console.ReadLine();
            Console.WriteLine("What do you wanna get? (grn, usd, eur)");
            to = Console.ReadLine();
        }

        public void Convert()
        {
            switch (what)
            {
                case "grn":
                    {
                        switch (to)
                        {
                            case "usd":
                                {
                                    Grn_To_Usd();
                                    break;
                                }
                            case "eur":
                                {
                                    Grn_To_Eur();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("I can convert grn only to eur or usd");
                                    break;
                                }
                        }
                        break;
                    }
                case "usd":
                    {
                        if (to == "grn") Usd_To_Grn();
                        else Console.WriteLine("I can convert usd only to grn");
                        break;
                    }
                case "eur":
                    {
                        if (to == "grn") Eur_To_Grn();
                        else Console.WriteLine("I can convert eur only to grn");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please, write a correct answers");
                        break;
                    }
            }
        }
        
    }

    class Program
    {
        static double Try()
        {
            double suma;
            bool indecate = double.TryParse(Console.ReadLine(), out suma);
            while (indecate == false || suma <= 0)
            {
                Console.WriteLine("Write correct exchange rate");
                indecate = double.TryParse(Console.ReadLine(), out suma);
            }
            return suma;
        }
        static void Main(string[] args)
        {

            //Вводимо  курс валют
            Console.WriteLine("Write dollar exchange rate");
            double _usd = Try();

            Console.WriteLine("Write euro exchange rate");
            double _eur = Try();

            //Конвертуємо
            
            string contin = "yes";
            while (contin == "yes")
            {
                Console.WriteLine("======================================");
                Converte convert = new Converte(_usd, _eur);
                convert.Convert();
                Console.WriteLine("Do you wanna continue? (yes or no)");
                contin = Console.ReadLine();
                while(contin != "yes" && contin != "no")
                {
                    Console.WriteLine("Write correct answer");
                }
            }
        }

            
        }

    }

