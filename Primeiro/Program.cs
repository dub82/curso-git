using System;
using System.Globalization;
using System.Collections.Generic;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("How many employees will be registered? ");
             int employeeQuantity = int.Parse(Console.ReadLine());
             List<Employee> listEmployees = new List<Employee>();
             for (int i = 1; i <= employeeQuantity; i++)
             {

                 Console.WriteLine("Employee #" + i + ": ");
                 Console.Write("Id: ");
                 int id = int.Parse(Console.ReadLine());
                 Console.Write("Name: ");
                 string name = Console.ReadLine();
                 Console.Write("Salary: ");
                 double salary = double.Parse(Console.ReadLine());
                 listEmployees.Add(new Employee(id, name, salary));
                 Console.WriteLine();
             }
             Console.WriteLine("Enter the employee id that will gave salary increase: ");
             int idFind = int.Parse(Console.ReadLine());
             Employee emp = listEmployees.Find(x => x.Id == idFind);
             if (emp != null)
             {
                 Console.WriteLine("Enter the percentage: ");
                 double percentageIncrease = double.Parse(Console.ReadLine());
                 emp.increaseSalary(percentageIncrease);
             }
             else
             {
                 Console.WriteLine("This id does not exist!");
             }

             Console.WriteLine();
             Console.WriteLine("Updated list of employees: ");
             foreach (Employee obj in listEmployees)
             {
                 Console.WriteLine(obj);
             }

             */

            string[] linha = Console.ReadLine().Split(' ');
            int linhas = int.Parse(linha[0]);
            int colunas = int.Parse(linha[1]);
            int[,] mat = new int [linhas, colunas];
            for( int i = 0; i < linhas; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for( int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }

            }

            int numeroEscolhido = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                
                for( int j = 0; j < colunas; j++)
                {
                    int valor = mat[i, j];
                    if(valor == numeroEscolhido)
                    {
                        Console.WriteLine("Position: " + i + ", " + j + ":");
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }

                        if (j < colunas - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }

                        if (i < linhas - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }

                       
                }
            }














        }
    }
}