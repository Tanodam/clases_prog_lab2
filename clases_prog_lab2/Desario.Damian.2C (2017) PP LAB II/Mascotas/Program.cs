using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genero un nuevo grupo
            Grupo grupo = new Grupo("Animals", TipoManada.Mixta);
            //Genero animales
            Perro p1 = new Perro("Pipo", "Salchicha", 7, true);
            Perro p2 = new Perro("Tincho", "Cruza", 9, false);
            Perro p3 = new Perro("Lola", "Callejera");
            Gato g1 = new Gato("Michi", "Siames");
            Gato g2 = new Gato("Michi", "Bau");
            //Agrego los bichos
            grupo = grupo + p1;
            grupo = grupo + p2;
            grupo = grupo + p3;
            grupo = grupo + g1;
            grupo = grupo + g2;
            //Imprimo los datos
            Console.WriteLine(grupo.ToString());
            Console.ReadKey();




        }
    }
}
