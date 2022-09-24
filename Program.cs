using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = new string[5];
            int[] nota = new int[5];
            int promedio = 0;
            int alta = 0;
            int mayor = 0;
            int menor = 0;
            Console.WriteLine("Tarea 1");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite el nombre del estudiante");
                estudiantes[i] = Console.ReadLine();
                Console.WriteLine("Digite la nota de " + estudiantes[i]);
                nota[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                promedio = promedio + nota[i];
                if (alta < nota[i])
                {
                    alta = nota[i];
                }
            }
            promedio = promedio / 5;
            for (int i = 0; i < 5; i++)
            {
                if (promedio >= nota[i])
                {
                    menor = menor + 1;
                }
                else if (promedio < nota[i])
                { 
                    mayor = mayor + 1;
                }
            }
            Console.WriteLine("El promedio de los estudiantes es de "+promedio);
            Console.WriteLine("La nota más alta es de " + alta);
            Console.WriteLine("La cantidad de estudiantes que tuvieron una nota mayor al promeido fue de "+mayor+" y "+menor+" que no tuvieron una nota mayor al promedio");
            Console.WriteLine("Desea terminar?");
            Console.ReadLine();
        }
    }
}
