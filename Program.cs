using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    public class Miscelanea
    {
        public static void Main()
        {
            double numero1 = 0.0;
            double numero2 = 0.0;
            double numero3 = 0.0;
            double numero4 = 0.0;

            Menus.MenuPrincipal();
            String Opciones = null;
            Opciones = Console.ReadLine().ToString();
            Console.Clear();


            switch (Opciones)
            {
                case "1":
                Menu1:
                    Menus.MenuOperadores();
                    String s1 = null;
                    s1 = Console.ReadLine().ToString();
                    Console.Clear();

                    try
                    {
                        Ejercicios operadores = new Ejercicios();
                        switch (s1)
                        {
                            case "1":
                                operadores.AreaTriangulo(numero1, numero2);
                                Menus.Volver();
                                break;

                            case "2":
                                operadores.SumaNumeros(numero1, numero2);
                                Menus.Volver();
                                break;

                            case "3":
                                operadores.ElevadoCuadrado(numero1);
                                Menus.Volver();
                                break;

                            case "4":
                                operadores.ConvertidorEuro(numero1);
                                Menus.Volver();
                                break;

                            case "5":
                                operadores.PerimetroCuadrado(numero1);
                                Menus.Volver();
                                break;

                            case "6":
                                operadores.VolumenCilindro(numero1, numero2);
                                Menus.Volver();
                                break;

                            case "7":
                                operadores.RadioCircunferencia(numero1);
                                Menus.Volver();
                                break;

                            case "8":
                                operadores.PromedioNumeros(numero1, numero2, numero3);
                                Menus.Volver();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("   ");
                        Console.WriteLine("Caracter incorrecto \nIngrese un valor NUMERICO");
                        Console.WriteLine("   ");
                    }
                    goto Menu1;

                    break;


                case "2":
                Menu2:
                    Menus.MenuCondicionales();
                    String s2 = null;
                    s2 = Console.ReadLine().ToString();
                    Console.Clear();

                    try
                    {
                        Ejercicios condicionales = new Ejercicios();
                        switch (s2)
                        {
                            case "1":
                                condicionales.NumeroPositivo(numero1);
                                Menus.Volver();
                                break;

                            case "2":
                                condicionales.NumeroMayor(numero1, numero2);
                                Menus.Volver();
                                break;

                            case "3":
                                condicionales.MayoryMenor(numero1, numero2, numero3);
                                Menus.Volver();

                                break;

                            case "4":
                                condicionales.RestaoSuma(numero1, numero2);
                                Menus.Volver();
                                break;

                            case "5":
                                condicionales.CocienteDosNumeros(numero1, numero2);
                                Menus.Volver();

                                break;

                            case "6":
                                condicionales.MuloSuma(numero1, numero2);
                                Menus.Volver();
                                break;

                            case "7":
                                condicionales.AñoBisiesto(numero1);
                                Menus.Volver();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("   ");
                        Console.WriteLine("Caracter incorrecto \nIngrese un valor NUMERICO");
                        Console.WriteLine("   ");
                    }
                    goto Menu2;
                    break;


                case "3":
                Menu3:
                    Menus.MenuCiclos();
                    String s3 = null;
                    s3 = Console.ReadLine().ToString();
                    Console.Clear();

                    try
                    {
                        Ejercicios ciclos = new Ejercicios();
                        switch (s3)
                        {
                            case "1":
                                ciclos.MultiplosTres(numero1);
                                Menus.Volver();
                                break;

                            case "2":
                                ciclos.NumerosImpares(numero1);
                                Menus.Volver();
                                break;

                            case "3":
                                ciclos.NumerosPares(numero1);
                                Menus.Volver();
                                break;

                            case "4":
                                ciclos.NumerosCuadrados(numero1);
                                Menus.Volver();
                                break;

                            case "5":
                                ciclos.SumaCienNum(numero1);
                                Menus.Volver();
                                break;

                            case "6":
                                ciclos.NumerosComprendidos(numero1, numero2, numero3);
                                Menus.Volver();
                                break;

                            case "7":
                                ciclos.SumaDigitos(numero1);
                                Menus.Volver();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("   ");
                        Console.WriteLine("Caracter incorrecto \nIngrese un valor NUMERICO");
                        Console.WriteLine("   ");
                    }
                    goto Menu3;
                    break;
            }
        }
    }
}