using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****Calculadora de promedio universitario*****");

            //Solicitando al estudiante que ingrese las notas de primer computo
            Console.WriteLine("\nIngrese las notas de primer computo");
            Console.WriteLine("\n Ingrese la notas del Laboratorio 1:");
            double Lab1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Ingrese la nota del parcial 1:");
            double Parc1 = Convert.ToDouble(Console.ReadLine());


            //Solicitando al estudiante que ingrese las notas de segundo computo
            Console.WriteLine("\nIngrese las notas de segundo computo");
            Console.WriteLine("\n Ingrese la nota del Laboratorio 2:");
            double Lab2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Ingrese la nota del parcial 2:");
            double Parc2 = Convert.ToDouble(Console.ReadLine());



            //Solicitando al estudiante que ingrese las notas de tercer computo
            Console.WriteLine("\nIngrese las notas de primer computo");
            Console.WriteLine("\n Ingrese la notas del Laboratorio 3:");
            double Lab3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Ingrese la nota del parcial 3:");
            double Parc3 = Convert.ToDouble(Console.ReadLine());

            //Calcular el promedio
            double PromedioLab = (Lab1 + Lab2 + Lab3) * 0.6;
            double PromedioParc = (Parc1 + Parc2 + + Parc3 ) * 0.40;
            double Notafinal = (PromedioLab / 3) + (PromedioParc / 3);


            Console.WriteLine("\nSu nota final fue: " + Math.Round(Notafinal, 1));

            //Comparacion de la nota final
            if (Notafinal >= 7)
            {
                Console.WriteLine("\n Usted paso la materia con excdelente nota. \n");
            }

             else if (Notafinal >= 6)
            {
                Console.WriteLine("\n Usted paso la materia con nota baja. \n");
            }

             else  
            {
                Console.WriteLine("\n Usted saco una nota menor que 6, reprobo la materia.\n");
            }

            Console.ReadKey();

        }
    }
}