using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mayor_y_Menor
{
    class Program { 
    static void Main(string[] args)
    {
            /*Programa para Ordenar 5 numeros ingresados por el usuario de mayor a menor */
            Console.WriteLine("Bienvenido al Programa");
            int valido = 0;
            do
            {
                try {
                    int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;
                    List<int> Lista = new List<int>();
                    do {
                        Console.WriteLine("Ingrese el Primer valor: ");
                        n1 = int.Parse(Console.ReadLine());
                        if (n1 < 0) {
                            Console.WriteLine("El numero no debe ser negativo");
                        }
                    } while (n1 < 0);
                    Lista.Add(n1);
                    do {
                        Console.WriteLine("Ingrese el Segundo valor: ");
                        n2 = int.Parse(Console.ReadLine());
                        if (n2 < 0)
                        {
                            Console.WriteLine("El numero no debe ser negativo");
                        }
                    } while (n2 < 0);
                    Lista.Add(n2);
                    do {
                        Console.WriteLine("Ingrese el Tercer valor: ");
                        n3 = int.Parse(Console.ReadLine());
                        if (n3 < 0)
                        {
                            Console.WriteLine("El numero no debe ser negativo");
                        }
                    } while (n3 < 0);
                    Lista.Add(n3);
                    do {
                        Console.WriteLine("Ingrese el Cuarto valor: ");
                        n4 = int.Parse(Console.ReadLine());
                        if (n4 < 0)
                        {
                            Console.WriteLine("El numero no debe ser negativo");
                        }
                    } while (n4 < 0);
                    Lista.Add(n4);
                    do {
                        Console.WriteLine("Ingrese el Quinto valor: ");
                        n5 = int.Parse(Console.ReadLine());
                        if (n5 < 0)
                        {
                            Console.WriteLine("El numero no debe ser negativo");
                        }
                    } while (n5 < 0);
                    Lista.Add(n5);

                    int[] A = Lista.ToArray();
                    Array.Sort(A);
                    foreach (int value in A)
                    {
                        Console.Write(value);
                        Console.Write(' ');
                    }
                    Console.ReadLine();
                }
                catch (Exception) {
                    valido = 1;
                    Console.WriteLine("\n La entrarda debe ser numerica\n");
                }
            } while (valido == 1);
                    }
                    }
    }
    
