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

        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;

        }
        public bool Pintar(int gasto, out string dibujo)
        {

            if (gasto < this.tinta)
            {
                for (int i = 0; i < gasto; i++)
                {
                    if (i != 0)
                    {
                        str += "**";
                    }
                    Console.WriteLine(str);
                    return true;
            }
        }
        public bool Recargar()
        {
            SetTinta(CantidadTintaMaxima);
            return;
        }
        private void SetTinta(short tinta)
        {
            if (this.tinta + tinta < CantidadTintaMaxima || this.tinta + tinta > 0)
            {


            }

        }
    }
}
