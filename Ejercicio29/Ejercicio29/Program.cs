using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo aldosivi = new Equipo(2, "Aldosivi");
            Jugador mesi = new Jugador(123, "Lio", 2, 5);
            Jugador deMaria = new Jugador(333, "Fideo", 3, 8);
            Jugador iguain = new Jugador(444, "Pipa", -1, 7);
            Jugador dogbau = new Jugador(444, "Pepo",158, 87);
            bool a;
            aldosivi += mesi;
            aldosivi += deMaria;
            aldosivi += iguain;
            aldosivi += dogbau;

            mesi.MostrarDatos();
            deMaria.MostrarDatos();
            iguain.MostrarDatos();
            dogbau.MostrarDatos();


            Console.ReadKey();
        }
    }
}
