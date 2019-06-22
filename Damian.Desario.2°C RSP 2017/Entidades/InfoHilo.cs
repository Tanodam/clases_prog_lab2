using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.Threading;

namespace Entidades
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;

        private void Ejecutar()
        {
            Thread.Sleep(randomizer.Next(1000, 5000));
            this.callback.RespuestaHilo(this.id);
        }
        static InfoHilo()
        {
            randomizer = new Random();
        }
        public InfoHilo(int id, IRespuesta<int> callback)
        {
            hilo = new Thread(Ejecutar);
            this.id = id;
            this.callback = callback;
            hilo.Start();
        }
    }
}
