using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Teplomer
    {
        private Timer timer;
        private static Random randomizer = new Random();
        public delegate void PrehriatieHendler(int teplota);
        public event PrehriatieHendler Prehriatie;

        public Teplomer()
        {
            timer = new Timer(randomizer.Next(2000, 10000));
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            //timer.Elapsed -= Timer_Elapsed;
            if (Prehriatie != null)
            {
                Prehriatie(100);
            }
        }
    }
}
