using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicios
    {
        public double AreaTriangulo(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese el numero de la base:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese e numero de la altura: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area es: " + MultiplicacionEnteros(numero1, numero2));
            static string MultiplicacionEnteros(double numero1, double numero2)
            {
                return Convert.ToString(numero1 * numero2 / 2);
            }
            return 0.0;
        }

        public double SumaNumeros(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La suma es: " + SumaEnteros(numero1, numero2));
            static string SumaEnteros(double numero1, double numero2)
            {
                return Convert.ToString(numero1 + numero2);
            }
            return 0.0;
        }
        public double ElevadoCuadrado(double numero1)
        {
            Console.WriteLine("Ingrese el numero que desea elevar al cuadrado: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El resultado es: " + ElevacionEnteros(numero1));
            static string ElevacionEnteros(double numero1)
            {
                return Convert.ToString(numero1 *= numero1);
            }
            return 0.0;
        }
        public double ConvertidorEuro(double numero1)
        {
            Console.WriteLine("Ingrese el numero de Euros: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("EL resultado de Dolares es: " + ConversorEnteros(numero1));
            static string ConversorEnteros(double numero1)
            {
                return Convert.ToString(numero1 * 1.06);
            }
            return 0.0;
        }

        public double PerimetroCuadrado(double numero1)
        {
            Console.WriteLine("Ingrese la medida de un lado del cuadro: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El Area es: " + AreaEnteros(numero1));
            static string AreaEnteros(double numero1)
            {
                return Convert.ToString(numero1 *= numero1);
            }
            Console.WriteLine("El Perimetro es: " + PerimetroEnteros(numero1));
            static string PerimetroEnteros(double numero1)
            {
                return Convert.ToString(numero1 + numero1 + numero1 + numero1);
            }
            return 0.0;
        }

        public double VolumenCilindro(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese el numero de la Altura:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese e numero de la Radio: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area es: " + AreaCEnteros(numero1, numero2));
            static string AreaCEnteros(double numero1, double numero2)
            {
                return Convert.ToString((2 * Math.PI) * numero2 * numero1 + (2 * Math.PI) * (numero2 * numero2));
            }
            Console.WriteLine("El Volumen es: " + VolumenEnteros(numero1, numero2));
            static string VolumenEnteros(double numero1, double numero2)
            {
                return Convert.ToString(3.14 * (numero2 * numero2) * numero1);
            }
            return 0.0;
        }
        public double RadioCircunferencia(double numero1)
        {
            Console.WriteLine("Ingrese el numero del Diametro:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El radio es: " + CircunferenciaEnteros(numero1));
            static string CircunferenciaEnteros(double numero1)
            {
                return Convert.ToString(numero1 / 2);
            }
            Console.WriteLine("La longitud es: " + LongitudEnteros(numero1));
            static string LongitudEnteros(double numero1)
            {
                return Convert.ToString((2 * 3.14) * numero1);
            }
            Console.WriteLine("El area es: " + AreaCirEnteros(numero1));
            static string AreaCirEnteros(double numero1)
            {
                return Convert.ToString(Math.PI * (numero1 * numero1));
            }
            return 0.0;
        }
        public double PromedioNumeros(double numero1, double numero2, double numero3)
        {
            Console.WriteLine("Ingrese el primer numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            numero3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El Promedio es es: " + PromedioEnteros(numero1, numero2, numero3));
            static string PromedioEnteros(double numero1, double numero2, double numero3)
            {
                return Convert.ToString(numero1 + numero2 + numero3 / 3);
            }
            return 0.0;
        }
        public double NumeroPositivo(double numero1)
        {
            Console.WriteLine("Ingrese el numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            if (numero1 <= 0)
            {
                Console.WriteLine("Es un numero Negativo");
            }

            else if (numero1 >= 0)
            {
                Console.WriteLine("Es un numero Positivo");
            }
            return 0.0;
        }
        public double NumeroMayor(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese el primer numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:  ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            if (numero1 < numero2)
            {
                Console.WriteLine(numero1 + " Es menor que " + numero2);
            }

            else if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + " Es Mayor que " + numero2);
            }
            return 0.0;
        }
        public double MayoryMenor(double numero1, double numero2, double numero3)
        {
            Console.WriteLine("Ingrese el primer numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:  ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:  ");
            numero3 = Convert.ToDouble(Console.ReadLine());


            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es " + numero1);
            }

            else if (numero2 > numero3)
            {
                Console.WriteLine("El numero mayor es " + numero2);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + numero3);
            }
            if (numero1 < numero2)
            {
                Console.WriteLine("El numero menor es " + numero1);
            }

            else if (numero2 < numero3)
            {
                Console.WriteLine("El numero menor es " + numero2);
            }
            else
            {
                Console.WriteLine("El numero menor es " + numero3);
            }
            return 0.0;
        }
        public double RestaoSuma(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese el primer numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:  ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            if (numero1 < numero2)
            {
                Console.WriteLine("El resultado de la suma es " + (numero1 + numero2));
            }

            else if (numero1 > numero2)
            {
                Console.WriteLine("El resultado de la resta es " + (numero1 - numero2));
            }
            return 0.0;
        }
        public double CocienteDosNumeros(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese el primer numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:  ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            if (numero1 == 0)
            {
                Console.WriteLine("No se puede dividir entre Cero");
            }

            else if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir entre Cero");
            }
            else if (numero1 > 0)
            {
                Console.WriteLine("El cociente es: " + numero1 / numero2);
            }
            return 0.0;
        }
        public double MuloSuma(double numero1, double numero2)
        {
            Console.WriteLine("Ingrese el primer numero:  ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:  ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            if (numero1 < 0)
            {
                Console.WriteLine("El resultado de la suma es " + (numero1 + numero2));
            }

            else if (numero2 < 0)
            {
                Console.WriteLine("El resultado de la suma es " + (numero1 + numero2));
            }
            else if (numero1 > 0)
            {
                Console.WriteLine("El resultado de la multiplicacion es " + (numero1 * numero2));
            }
            else if (numero2 > 0)
            {
                Console.WriteLine("El resultado de la multiplicacion es " + (numero1 * numero2));
            }
            return 0.0;
        }
        public double AñoBisiesto(double numero1)
        {
            Console.WriteLine("Escriba el año: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            bool MultiploDe4 = (numero1 % 4 == 0);
            bool MultiploDe100 = (numero1 % 100 == 0);
            bool MultiploDe400 = (numero1 % 400 == 0);

            bool bisiesto = MultiploDe400 || (MultiploDe4 && !MultiploDe100);
            if (bisiesto)
            {
                Console.WriteLine("Es bisiesto");
                Console.WriteLine("  ");
            }
            else
            {
                Console.WriteLine("No es bisiesto");
                Console.WriteLine("  ");
            }
            return 0.0;
        }
        public double MultiplosTres(double numero1)
        {
            Console.WriteLine("Multiplos de 3");
            Console.WriteLine("  ");
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            return 0.0;
        }
        public double NumerosImpares(double numero1)
        {
            Console.WriteLine("Imprimir numeros impares del 1 al 100");
            Console.WriteLine("  ");
            for (int i = 1; i <= 100; i = i + 2)
            {

                Console.WriteLine(i);
            }
            return 0.0;
        }
        public double NumerosPares(double numero1)
        {
            Console.WriteLine("Imprimir numeros pares del 0 al 100");
            Console.WriteLine("  ");
            for (int i = 2; i <= 100; i = i + 2)
            {
                {
                    Console.WriteLine(i);
                }
            }
            return 0.0;
        }
        public double NumerosCuadrados(double numero1)
        {
            {
                Console.WriteLine(" Cuadrados del 1-30");
                Console.WriteLine("  ");

                Console.WriteLine("\n   ");

                for (numero1 = 1; numero1 <= 30; numero1++)
                {
                    Console.WriteLine(Math.Pow(numero1, 2));
                }
            }
            return 0.0;
        }
        public double SumaCienNum(double numero1)
        {
            {
                int i = 1, cuad = 0, n1 = 1, sum = 0;

                Console.WriteLine("Suma de los cuadrados de los 100 primeros numeros naturales");
                Console.WriteLine("  ");

                for (i = 1; i <= 100; i++)

                {

                    cuad = n1 * i;

                    cuad = cuad * i;

                    sum = sum + cuad;

                    Console.WriteLine("cuadrado de:\t" + i + "\tes\t" + cuad);

                }

                Console.WriteLine("la suma de los cuadrados es:\t" + sum);
            }
            return 0.0;
        }
        public double NumerosComprendidos(double numero1, double numero2, double numero3)
        {

            Console.WriteLine("Digite el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            for (numero3 = numero1 + 1; numero3 < numero2; numero3++)
            {
                Console.WriteLine("Los numeros comprendidos entre " + numero1 + " y " + numero2 + " son :");
                Console.WriteLine(numero3);
            }
            return 0.0;
        }
        public double SumaDigitos(double numero1)
        {
            int sum1, cant, valor;
            string linea;
            sum1 = 0;
            cant = 0;
            do
            {
                Console.WriteLine("Ingrese un valor (0 para finalizar) :");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != 0)
                {
                    sum1 = sum1 + valor;
                    cant++;
                }
                else
                {
                    Console.WriteLine("No se ingresan mas valores");
                }
            }
            while (valor != 0);
            Console.WriteLine("La suma total es :" + sum1);
            return 0.0;
        }
    }
}