using Hardware.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CPU_BURN
{
    internal class memorytest
    {
        IHardwareInfo hardwareInfo = new HardwareInfo();
        List<string> chunk = new List<string>();
        string buffer = "";
        int bufferSize = 1024 * 150;

        public bool allocated = false;
        public bool comprobacion = false;
        public bool errors = false;
        public double ocuped_memory = 0;
        int GBS = 0;
        public void initMemoryTest(int gbs)
        {
            Thread t = new Thread(() => memory_test_task(gbs));
            comprobacion = true;
            allocated = false;
            errors = false;
            GBS = gbs;
            t.Start();

        }
        string random_str(int largo)
        {
            var n = new Random();

            string str_bufer = "";

            for (int i = 0; i < largo; i++)
            {
                str_bufer += Convert.ToChar(n.Next(0, 254));
            }

            for (int i = 0; i < 10; i++)
            {
                str_bufer += str_bufer;
            }

            return str_bufer;
        }
        public void stop_test() 
        {
            allocated = true;
            comprobacion = false;
            ocuped_memory = 0;
            errors = false;
            buffer = "";
            chunk.Clear();
        }
        void stop_test_whit_errors()
        {
            allocated = true;
            comprobacion = false;
            ocuped_memory = 0;
            buffer = "";
            chunk.Clear();
            errors = true;
        }
        public void is_allocated()
        {
            hardwareInfo.RefreshMemoryStatus();
            double tRAM = Math.Round((hardwareInfo.MemoryStatus.TotalPhysical / 1073741824.0), 3);
            double aRAM = Math.Round((hardwareInfo.MemoryStatus.AvailablePhysical / 1073741824.0), 3);

            ocuped_memory = (tRAM - aRAM);

            if ((int)ocuped_memory >= GBS)
            {
                allocated = true;
            }
        }
        void memory_test_task(int gbs)
        {
            buffer = random_str(bufferSize);

            while (!allocated)
            {
                chunk.Add(buffer);
            }

            while (comprobacion)
            {
                string newstr = random_str(bufferSize);

                for (int x = 0; x < chunk.Count; x++)
                {
                    if (chunk[x] != buffer)
                    {
                        stop_test_whit_errors();
                        return;
                    }
                    else
                    {
                        chunk[x] = newstr;
                    }                
                }

                buffer = newstr;

            }

        }
    }
}
