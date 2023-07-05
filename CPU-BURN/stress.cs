using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CPU_BURN
{
    internal class stress
    {
        private List<Thread> threads = new List<Thread>();
        public bool errors = false;
        public bool bench = false;
        public double ptos = 0;
        public double tmpptos = 0;

        void ique_bench()
        {
            int t = 1024;
            
            while (bench)
            {
                try
                {
                    t *= 1024;

                    if (t != 1048576) { stop_bench_whit_errors(); }

                    t /= 1024;

                    if (t != 1024) { stop_bench_whit_errors(); }

                    float primo = 1.333f;

                    for (float i = 1.0f; i < 2.0f; i+= 0.01f)
                    {
                        if (i / i == 1.0f)
                        {
                            primo = i;
                        }
                    }

                    ptos += 0.0005;
                }
                catch (Exception)
                {
                    stop_bench_whit_errors();
                }
            }
        }
        public void init_bench(int cores)
        {
            bench = true;

            if (cores <= 0) { bench = false; return; }

            for (int i = 0; i < cores+1; i++)
            {
                Thread t = new Thread(new ThreadStart(ique_bench));
                threads.Add(t);
            }

            try
            {
                foreach (Thread t in threads)
                {
                    t.Start();
                }
            }
            catch (Exception)
            {
                stop_bench_whit_errors();
            }
        }
        void stop_bench_whit_errors()
        {
            stop_bench();
            errors = true;
            ptos = 0;
            tmpptos = 0;
        }
        public void stop_bench()
        {
            bench = false;
            threads.Clear();
            ptos = 0;
            tmpptos = 0;
        }
        public double get_points()
        {
            double tmp = ptos - tmpptos;
            
            tmpptos = ptos;

            return Math.Round(tmp,3);
        }
    }
}
