namespace CPU_BURN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            operatinSystem = new Label();
            OS = new Label();
            threads = new Label();
            label3 = new Label();
            mem = new Label();
            label5 = new Label();
            board = new Label();
            label7 = new Label();
            biosv = new Label();
            label9 = new Label();
            estresTest = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            graphics = new Label();
            benchlabel = new Label();
            BenchTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            mucore = new Button();
            mocore = new Button();
            button3 = new Button();
            allocatedMem = new Label();
            trackBar1 = new TrackBar();
            memtesttimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 245);
            button1.Name = "button1";
            button1.Size = new Size(174, 54);
            button1.TabIndex = 0;
            button1.Text = "Run stres test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // operatinSystem
            // 
            operatinSystem.AutoSize = true;
            operatinSystem.ForeColor = Color.FromArgb(128, 255, 255);
            operatinSystem.Location = new Point(155, 14);
            operatinSystem.Name = "operatinSystem";
            operatinSystem.Size = new Size(38, 15);
            operatinSystem.TabIndex = 1;
            operatinSystem.Text = "label1";
            // 
            // OS
            // 
            OS.AutoSize = true;
            OS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OS.Location = new Point(12, 9);
            OS.Name = "OS";
            OS.Size = new Size(138, 21);
            OS.TabIndex = 1;
            OS.Text = "Operating System:";
            // 
            // threads
            // 
            threads.AutoSize = true;
            threads.ForeColor = Color.FromArgb(128, 255, 255);
            threads.Location = new Point(155, 46);
            threads.Name = "threads";
            threads.Size = new Size(38, 15);
            threads.TabIndex = 1;
            threads.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 1;
            label3.Text = "Processor threads:";
            // 
            // mem
            // 
            mem.AutoSize = true;
            mem.ForeColor = Color.FromArgb(128, 255, 255);
            mem.Location = new Point(155, 76);
            mem.Name = "mem";
            mem.Size = new Size(38, 15);
            mem.TabIndex = 1;
            mem.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 71);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 1;
            label5.Text = "Memory size:";
            // 
            // board
            // 
            board.AutoSize = true;
            board.ForeColor = Color.FromArgb(128, 255, 255);
            board.Location = new Point(155, 107);
            board.Name = "board";
            board.Size = new Size(38, 15);
            board.TabIndex = 1;
            board.Text = "label1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 102);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 1;
            label7.Text = "Main Board:";
            // 
            // biosv
            // 
            biosv.AutoSize = true;
            biosv.ForeColor = Color.FromArgb(128, 255, 255);
            biosv.Location = new Point(155, 139);
            biosv.Name = "biosv";
            biosv.Size = new Size(38, 15);
            biosv.TabIndex = 1;
            biosv.Text = "label1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 133);
            label9.Name = "label9";
            label9.Size = new Size(97, 21);
            label9.TabIndex = 1;
            label9.Text = "Bios version:";
            // 
            // estresTest
            // 
            estresTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            estresTest.AutoSize = true;
            estresTest.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            estresTest.ForeColor = Color.FromArgb(128, 255, 255);
            estresTest.Location = new Point(192, 253);
            estresTest.Name = "estresTest";
            estresTest.Size = new Size(83, 37);
            estresTest.TabIndex = 1;
            estresTest.Text = "0.000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 1;
            label2.Text = "Graphics adapter:";
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 305);
            button2.Name = "button2";
            button2.Size = new Size(174, 54);
            button2.TabIndex = 0;
            button2.Text = "Bench CPU";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // graphics
            // 
            graphics.AutoSize = true;
            graphics.ForeColor = Color.FromArgb(128, 255, 255);
            graphics.Location = new Point(155, 170);
            graphics.Name = "graphics";
            graphics.Size = new Size(38, 15);
            graphics.TabIndex = 1;
            graphics.Text = "label1";
            // 
            // benchlabel
            // 
            benchlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            benchlabel.AutoSize = true;
            benchlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            benchlabel.ForeColor = Color.FromArgb(128, 255, 255);
            benchlabel.Location = new Point(192, 314);
            benchlabel.Name = "benchlabel";
            benchlabel.Size = new Size(83, 37);
            benchlabel.TabIndex = 1;
            benchlabel.Text = "0.000";
            // 
            // BenchTimer
            // 
            BenchTimer.Interval = 300;
            BenchTimer.Tick += BenchTimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Location = new Point(14, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 2);
            panel1.TabIndex = 2;
            panel1.Click += button2_Click;
            // 
            // mucore
            // 
            mucore.FlatStyle = FlatStyle.Flat;
            mucore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mucore.ForeColor = Color.Gray;
            mucore.Location = new Point(12, 203);
            mucore.Name = "mucore";
            mucore.Size = new Size(87, 36);
            mucore.TabIndex = 0;
            mucore.Text = "Multi-core";
            mucore.UseVisualStyleBackColor = true;
            mucore.Click += mucore_Click;
            // 
            // mocore
            // 
            mocore.FlatStyle = FlatStyle.Flat;
            mocore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            mocore.ForeColor = Color.White;
            mocore.Location = new Point(98, 203);
            mocore.Name = "mocore";
            mocore.Size = new Size(88, 36);
            mocore.TabIndex = 0;
            mocore.Text = "Mono core";
            mocore.UseVisualStyleBackColor = true;
            mocore.Click += mocore_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 365);
            button3.Name = "button3";
            button3.Size = new Size(174, 54);
            button3.TabIndex = 0;
            button3.Text = "MemTest(0GB)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // allocatedMem
            // 
            allocatedMem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            allocatedMem.AutoSize = true;
            allocatedMem.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            allocatedMem.ForeColor = Color.FromArgb(128, 255, 255);
            allocatedMem.Location = new Point(192, 371);
            allocatedMem.Name = "allocatedMem";
            allocatedMem.Size = new Size(124, 37);
            allocatedMem.TabIndex = 1;
            allocatedMem.Text = "0.000 GB";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(192, 203);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(165, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // memtesttimer
            // 
            memtesttimer.Interval = 500;
            memtesttimer.Tick += memtesttimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 0, 23);
            ClientSize = new Size(369, 450);
            Controls.Add(trackBar1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(allocatedMem);
            Controls.Add(benchlabel);
            Controls.Add(estresTest);
            Controls.Add(label9);
            Controls.Add(graphics);
            Controls.Add(biosv);
            Controls.Add(label7);
            Controls.Add(board);
            Controls.Add(label5);
            Controls.Add(mem);
            Controls.Add(label3);
            Controls.Add(threads);
            Controls.Add(OS);
            Controls.Add(operatinSystem);
            Controls.Add(button2);
            Controls.Add(mocore);
            Controls.Add(mucore);
            Controls.Add(button3);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(385, 489);
            MinimumSize = new Size(385, 489);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label operatinSystem;
        private Label OS;
        private Label threads;
        private Label label3;
        private Label mem;
        private Label label5;
        private Label board;
        private Label label7;
        private Label biosv;
        private Label label9;
        private Label estresTest;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Label graphics;
        private Label benchlabel;
        private System.Windows.Forms.Timer BenchTimer;
        private Panel panel1;
        private Button mucore;
        private Button mocore;
        private Button button3;
        private Label allocatedMem;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer memtesttimer;
    }
}