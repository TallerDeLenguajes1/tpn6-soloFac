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

        static double CalculadoraSimple(double num1, double num2)
        {
            Console.WriteLine("Ingrese el numero de la opciion a realizar");
            int opc = 1;  //lo inicializo solo para que ingrese al while
            double result = 0;

            while (opc != 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1- Sumar");
                Console.WriteLine("2- Restar");
                Console.WriteLine("3- Multiplicar");
                Console.WriteLine("4- Dividir");
                Console.WriteLine("0- Salir");

                opc = Convert.ToInt32(Console.ReadLine());
                
                if (opc < 5 && opc > 0)
                {
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
                            result = num1 / num2;
                            break;

                        case 0:
                            opc = 0;
                            break;
                    }
                }

                if (opc > 0 && opc < 12)
                {
                    Console.WriteLine("\nEl resultado es: " + result);
                }

            }

            return result;
        }

        static void Calculadora()
        {
            Console.WriteLine("Ingrese el numero de la opciion a realizar");
            int opc = 1;  //lo inicializo solo para que ingrese al while
            double num1 = 0, num2 = 0;
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

                string strn1 = num1.ToString();
                string strn2 = num2.ToString();

                if (opc > 0 && opc < 12)
                {
                    Console.WriteLine("\nEl resultado es: " + result);
                    string sresult = result.ToString();
                    Console.WriteLine("\nLa suma de " + strn1 + " y de " + strn2 + " es igual a: " + sresult);
                }

                MaxMin(num1, num2);

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

            //------------ Resultado en formato de Texto -----------
            /*
            Calculadora();

            //------------- Recorrido ForEach ------------------

            foreach(char s in CadenasConcatenadas)
            {
                Console.WriteLine("La letra es " + s);
            }
            */

            //--------------------- Ocurrencia de una determinada palabra --------------------

            /*
            //Voy a tomar una palabra ingresada por el usuario para ver si esta contenida
            //Para evitar posibles inconvenientes conviento la cadena a minuscula
            cadena = "La ocurrencia de la, la, la";
            cadena = cadena.ToLower();
            //cadena = Console.ReadLine();

           
            string palabra = Console.ReadLine();

            int tam = palabra.Length;

            //Voy a ir extrayendo de la cadena desde la posicion inicial de la palabra hasta su longitud
            //y guardare el resto, es decir desde la ultima letra en adelante

            int conc = 0;
            while (cadena.Contains(palabra))
            {
                cadena = cadena.Substring(cadena.IndexOf(palabra) + tam);
                //cadena = cadena.Trim();
                Console.WriteLine("El valor de la cadena es: " + cadena);
                conc++;
            }

            Console.WriteLine("La cantidad de veces que aparece la palabra '" + palabra + "' es: " + conc);
            */

            //--------------------- Conversion a Minuscula y Mayuscula --------------------

            cadena = "La cadena de texto";

            cadena = cadena.ToUpper();
            Console.WriteLine(cadena);

            cadena = cadena.ToLower();
            Console.WriteLine(cadena);

            
            //--------------------- Comparar cadenas --------------------

            /*
            string cad = Console.ReadLine();

            if(String.Compare(cadena.ToLower(), cad.ToLower()) == 0)
            {
                Console.WriteLine("Son iguales?");
            }else if((String.Compare(cadena.ToLower(), cad.ToLower()) == 0) == false)
            {
                Console.WriteLine("No son iguales");
            }
            */



            //--------------------- Split --------------------

            cadena = "La-cadena-esta-separada-por-guiones";

            string[] ncadena = cadena.Split("-");

            foreach (string c in ncadena)
            {
                Console.WriteLine("Cadena separada: " + c);
            }

            //--------------------- Operar desde una cadena --------------------


            //Consultar

            cadena = "52 + 25";

            ncadena = cadena.Split("+");
            ncadena[0] = ncadena[0].Trim();
            ncadena[1] = ncadena[1].Trim();

            double result = CalculadoraSimple(Convert.ToDouble(ncadena[0]), Convert.ToDouble(ncadena[1]));

            Console.WriteLine("El resultado es: {0}", result);


        }

        static void ExpresionesRegulares()
        {

        }



    }
}
