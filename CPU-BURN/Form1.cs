using Hardware.Info;
using System.Windows.Forms.VisualStyles;

namespace CPU_BURN
{
    public partial class Form1 : Form
    {
        stress STRESS = new stress();
        memorytest MEMTEST = new memorytest();

        static IHardwareInfo hardwareInfo = new HardwareInfo();
        List<double> benchData = new List<double>();

        float bench_running_time = 0;
        const float bench_max_time = 10;
        bool monocore = false;

        bool memtest_is_running = false;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            hardwareInfo.RefreshOperatingSystem();
            operatinSystem.Text = hardwareInfo.OperatingSystem.ToString();

            hardwareInfo.RefreshBIOSList();
            biosv.Text = hardwareInfo.BiosList[0].Version.ToString();

            hardwareInfo.RefreshMotherboardList();
            board.Text = hardwareInfo.MotherboardList[0].Manufacturer.ToString() + " - " + hardwareInfo.MotherboardList[0].Product.ToString();

            // Detect Memory size
            try
            {
                hardwareInfo.RefreshMemoryStatus();
                double RAM = Math.Round((hardwareInfo.MemoryStatus.TotalPhysical / 1073741824.0), 2);
                mem.Text = RAM.ToString() + " GB";

                trackBar1.Maximum = (int)Math.Round(RAM);
                trackBar1.Value = (int)Math.Round(RAM) - (int)Math.Round((hardwareInfo.MemoryStatus.AvailablePhysical / 1073741824.0));
                button3.Text = "MemTest(" + trackBar1.Value + "GB)";
            }
            catch (Exception) { mem.Text = "Not detected"; }

            // Detect Graphics adapter
            try
            {
                hardwareInfo.RefreshVideoControllerList();
                graphics.Text = hardwareInfo.VideoControllerList[0].Name.ToString();
            }
            catch (Exception) { graphics.Text = "Not detected"; }

            threads.Text = Environment.ProcessorCount.ToString();
        }

        private int get_core_count()
        {
            int core_count = 1;

            if (!monocore)
            {
                try { core_count = Convert.ToInt32(threads.Text); } catch { core_count = 16; }
            }

            return core_count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            if (timer1.Enabled)
            {
                int core_count = get_core_count();

                STRESS.init_bench(core_count);
                button1.ForeColor = Color.Red;
                button1.Text = "Stop stres test";
            }
            else
            {
                STRESS.stop_bench();
                button1.ForeColor = Color.White;
                button1.Text = "Run stres test";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            estresTest.Text = STRESS.get_points().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BenchTimer.Enabled = !BenchTimer.Enabled;

            if (BenchTimer.Enabled)
            {
                int core_count = get_core_count();

                STRESS.init_bench(core_count);
                //STRESS.init_bench(2);
                button2.ForeColor = Color.Red;
                button2.Text = "Stop bench";
            }
            else
            {
                STRESS.stop_bench();
                bench_running_time = 0;
                button2.ForeColor = Color.White;
                button2.Text = "Bench CPU";
                benchData.Clear();
            }
        }

        private void BenchTimer_Tick(object sender, EventArgs e)
        {
            if (bench_running_time <= bench_max_time)
            {
                bench_running_time += (float)(BenchTimer.Interval / 1000.0);

                int panel_value = (int)(170.0 * (bench_running_time / 10.0));
                if (panel_value > 170) { panel_value = 170; }
                panel1.Width = panel_value;

                benchData.Add(STRESS.get_points());

                double result = 0;

                foreach (double item in benchData)
                {
                    result += item;
                }

                result = result / benchData.Count;

                benchlabel.Text = Math.Round(result, 2).ToString();

            }
            else
            {
                STRESS.stop_bench();
                bench_running_time = 0;
                benchData.Clear();
                button2.ForeColor = Color.White;
                button2.Text = "Bench CPU";
                BenchTimer.Enabled = false;
            }

            if (STRESS.errors)
            {
                STRESS.stop_bench();
                bench_running_time = 0;
                benchData.Clear();
                button2.ForeColor = Color.White;
                button2.Text = "Bench CPU";
                BenchTimer.Enabled = false;

                MessageBox.Show("Erros detected, test stoped", "Erros");
            }
        }

        private void button_selected_mode(Button selected, Button deselected)
        {
            selected.ForeColor = Color.Gray;
            deselected.ForeColor = Color.White;
        }

        private void mucore_Click(object sender, EventArgs e)
        {
            button_selected_mode((Button)sender, mocore);
            monocore = false;
        }

        private void mocore_Click(object sender, EventArgs e)
        {
            button_selected_mode((Button)sender, mucore);
            monocore = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            button3.Text = "MemTest(" + trackBar1.Value + "GB)";
        }

        private void memtesttimer_Tick(object sender, EventArgs e)
        {
            allocatedMem.Text = Math.Round(MEMTEST.ocuped_memory, 3).ToString() + "GB";

            MEMTEST.is_allocated();

            if (!MEMTEST.comprobacion)
            {
                MEMTEST.stop_test();
                button3.ForeColor = Color.White;
            }

            if (!MEMTEST.allocated && MEMTEST.comprobacion)
            {
                button3.Text = "loading...";
            }
            else if (MEMTEST.allocated && MEMTEST.comprobacion)
            {
                button3.Text = "testing...";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!memtest_is_running)
            {
                MEMTEST.initMemoryTest(trackBar1.Value);
                memtesttimer.Enabled = true;
                button3.ForeColor = Color.Red;
                memtest_is_running = true;
            }
            else
            {
                MEMTEST.stop_test();
                button3.ForeColor = Color.White;
                memtest_is_running = false;
                button3.Text = "MemTest(" + trackBar1.Value + "GB)";
            }
        }
    }
}