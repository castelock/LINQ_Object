using System;
using System.Linq;

namespace LINQ_Object
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The options for this program are: {0} 1- Operator Select. {0} " +
                "2- Operator SelectMany. {0} ", Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            String option = Console.ReadLine();

            Employee employee = new Employee();
            switch (option)
            {
                case "1":
                    // Query using Select()
                    employee.runSelect();
                    break;
                case "2":
                    // Query using SelectMany()
                    employee.runSelectMany();
                    break;
                case "3":

                    var origenDatos = new[] { 1, 5, 2, 8, 7, 9, 4 };

                    var desviación = from elemento in origenDatos
                                     let media = origenDatos.Average()
                                     select Math.Pow(elemento - media, 2);

                    foreach (var item in desviación)
                        Console.WriteLine(item);

                    break;
                case "4":
                    var origenDatos2 = new[] { 1, 5, 2, 8, 4, 7 };
                    var numerosMedianos = from n in origenDatos2
                                          where n < 6
                                          select n into n2
                                          where n2 > 2
                                          select n2;
                    foreach (var item in numerosMedianos)
                        Console.WriteLine(item);

                    break;
                case "5":
                    string[][] palabras = new string[][]
                    {
                        new string[] { "En", "un", "lugar" },
                        new string[] { "de", "La", "Mancha" },
                        new string[] { "de", "cuyo", "nombre" }
                    };

                    var palabras1 = palabras.Select(p => p);
                    foreach (var p in palabras1)
                        Console.WriteLine("palabras 1: " + p);
                    foreach (var p in palabras1)
                        foreach (var p2 in p)
                            Console.WriteLine("palabras 1bis: " + p2);

                    var palabras2 = palabras.SelectMany(p => p);
                    foreach (var p in palabras2)
                        Console.WriteLine("palabras 2: " + p);

                    break;
                case "6":
                    string[] animales = new string[] { "Canguro", " Castor", "Araña",
    "Serpiente", " Tiburón", "Cebra", "Caballo", "Medusa" };

                    var consultaPredicado = from a in animales
                                            where MiPredicado(a)
                                            select a;

                    foreach (string s in consultaPredicado)
                        Console.WriteLine(s);

                    static bool MiPredicado(string a)
                    {
                        if (a.StartsWith('C') && a.Length > 5)
                            return true;
                        else
                            return false;
                    }

                    break;
                case "7":
                    string[] animales2 = new string[] { "Canguro", " Castor", "Araña",
    "Serpiente", " Tiburón", "Cebra", "Caballo", "Medusa" };

                    var filtroIndice = animales2.Where((a, indice) => indice % 2 == 0);

                    foreach (string s in filtroIndice)
                        Console.WriteLine(s);

                    break;
                case "8":
                    string[] nombres = new string[] { "Pedro", "María",
                                  "Pedro", "María", "Luis" };

                    var nombresUnicos = (from n in nombres
                                         select n).Distinct();

                    foreach (var nombre in nombresUnicos)
                        Console.WriteLine(nombre);

                    break;
                case "9":
                    var celdas = new[]
                    {
                        new { columna = 'A', fila = 3 },
                        new { columna = 'C', fila = 2 },
                        new { columna = 'A', fila = 4 },
                        new { columna = 'B', fila = 1 }
                    };
                    var celdasOrden1 = from c in celdas
                                       orderby c.columna, c.fila descending
                                       select c;
                    foreach (var c in celdasOrden1)
                        Console.WriteLine(c);

                    break;
                case "10":
                    string[] palabras3 = new string[] { "Capa", "Caña", "Cama" };

                    var palabrasOrdenadas = palabras3.OrderBy(w => w, StringComparer.Ordinal);

                    Console.WriteLine(string.Join(" ", palabrasOrdenadas));
                    break;
                default:
                    Console.WriteLine("The option is not valid.");
                    break;
            }
                        
        }
    }
}
