using System;
using System.Runtime.Serialization;
using System.Xml;
using test;

namespace fgfgfg
{

    public class Program
    {

        
        static void Main()
        {

            Alunos Lucas = new Alunos()
            {
                nome = "Lucas",
                prova1 = 10,
                prova2 = 10,
                Trabalho = 10,

            };


            Console.WriteLine(Math.Round(MediaCalculator(Lucas.prova2, Lucas.prova1, Lucas.Trabalho), 2));

        }
        public static double MediaCalculator(double prova1, double prova2, double Trabalho)
            {
            double MediaResultado = (prova1*2.5 + prova2*2.5 + Trabalho*2) / 3 ;

            return MediaResultado;
            }
                  
    }
}



