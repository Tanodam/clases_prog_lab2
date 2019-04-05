using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        public short CantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;

        }
        public void Pintar(int gasto, out string dibujo)
        {
            Console.ForegroundColor = this.GetColor();

            dibujo = "";
            //Console.WriteLine("Nivel de tinta actual {0}", this.tinta);
            //Console.WriteLine("Usted solicito pintar {0} caracteres", gasto);
            if (this.tinta > 0)
            {
                for (int i = 0; this.tinta > 0 && i < gasto; i++)
                {
                    SetTinta(Convert.ToInt16(this.tinta - 1));
                    dibujo += "*";
                }
                Console.WriteLine("Usted esta pintando en {0}", this.GetColor());
                Console.WriteLine("PINTANDO..");
                Console.WriteLine(dibujo);
                Console.WriteLine("Pude pintar {0} caracteres", dibujo.Length);
                Console.WriteLine("Nivel de tinta despues de pintar {0}", this.tinta);
                Console.WriteLine("-------------");
            }
            else
            {
                Console.WriteLine("No se pudo pintar. Nivel de tinta insuficiente");
                this.Recargar();

            }
            Console.ResetColor(); //Restea los colores

        }
        private bool SetTinta(short tinta)
        {
            if (this.tinta + tinta < CantidadTintaMaxima || this.tinta + tinta > 0)
            {
                this.tinta = tinta;
                return true;
            }
            else
                return false;
        }
        public bool Recargar()
        {
            Console.WriteLine("\nRecargando tinta de color {0}", this.color);
            Console.WriteLine("Nivel de tinta actual {0}", this.tinta);
            if (SetTinta(CantidadTintaMaxima))
            {
                Console.WriteLine("Nivel de tinta despues de recargar {0}\n", this.tinta);
                return true;
            }
            else
                return false;
        }

    }
}
