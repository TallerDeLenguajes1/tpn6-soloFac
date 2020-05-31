using System;
using System.Runtime;

namespace TPNro6
{
    class Program
    {

        static void Main(string[] args)
        {
            //Calculadora();

            Strings();
        }


        /*
        static void Invertir()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Probando visual studio");


            Console.WriteLine("Ingrese un numero, sera invertido: \n");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El numero es: " + num);

            int numinv = 0, cont = 0;

            if (num > 0)
            {
                while(num > 0)
                {
                    numinv = num % 10 + numinv * 10;
                    num /= 10;
                    cont++;
                }
            }

            Console.WriteLine("El numero invertido es: " + numinv);
            
        }
        */




        static double Calculadora(double num1, double num2)
        {
            Console.WriteLine("Ingrese el numero de la opciion a realizar");
            int opc = 1;  //lo inicializo solo para que ingrese al while
            double result = 0;

            while(opc != 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1- Sumar");
                Console.WriteLine("2- Restar");
                Console.WriteLine("3- Multiplicar");
                Console.WriteLine("4- Dividir");
                Console.WriteLine("5- Valor Absoluto");
                Console.WriteLine("6- Cuadrado");
                Console.WriteLine("7- Raiz Cuadrada");
                Console.WriteLine("8- Seno");
                Console.WriteLine("9- Coseno");
                Console.WriteLine("10- Parte Entera");
                Console.WriteLine("0- Salir");

                opc = Convert.ToInt32(Console.ReadLine());

                if (opc < 5 && opc > 0)
                {
                    Console.WriteLine("\nIngrese el num1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nIngrese el num1: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }else if (opc != 0 && opc > 5 && opc < 12)
                {
                    Console.WriteLine("\nIngrese el num: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }

                switch (opc)
                {
                    case 1:
                        result = num1 + num2;
                        break;

                    case 2:
                        result = num1 - num2;
                        break;

                    case 3:
                        result = num1 * num2;
                        break;

                    case 4:
                        result = num1/num2;
                        break;

                    case 5:
                        result = Math.Abs(num1);
                        break;

                    case 6:
                        result = Math.Pow(10, 2);
                        break;

                    case 7:
                        result = Math.Sqrt(num1);
                        break;

                    case 8:
                        result = Math.Sin(num1);
                        break;

                    case 9:
                        result = Math.Cos(num1);
                        break;

                    case 10:
                        result = (int)num1;
                        break;

                    case 0:
                        opc = 0;
                        break;
                }

                if (opc > 0 && opc < 12)
                {
                    Console.WriteLine("\nEl resultado es: " + result);
                }

                MaxMin(num1, num2);

                return result;

            }
        }

        static void MaxMin(double num1, double num2)
        {
            Console.WriteLine("Ingrese dos numeros: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El maximo es: " + num1);
                Console.WriteLine("El minimo es: " + num2);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("El maximo es: " + num2);
                Console.WriteLine("El minimo es: " + num1);
            }
        }

        static void Strings()
        {
            string cadena = "Probando la funcion Substring";

            int StartIndex = 20;
            int length = 9;

            //------------ Extraer algunos caracteres -----------

            string PalabExtraida = cadena.Substring(StartIndex, length);

            Console.WriteLine("La palabra extraida es: " + PalabExtraida);

            //------------ Longitud de la cadena -----------

            Console.WriteLine("La longitud de la cadena es: " + cadena.Length);

            ///------------ Concatenar cadenas -----------

            string cadena2 = ", si funciono";

            string CadenasConcatenadas = cadena + cadena2;

            Console.WriteLine(CadenasConcatenadas);

            //------------   -----------
        }





    }
}
