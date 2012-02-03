using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Timers;
using System.Windows.Threading;
using System.Text;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Declarations
        public static int Base = 0;
        public static Process Tibia = null;
        public int vls;
        public int hp;
        public int mp;
        public int xp;
        public int ml;
        public int lvl;
        public int cap;
        public int xpos;
        public int ypos;
        public int zpos;
        public int xpup;
        public int xpcalc;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();


        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);



        // XOR Address
        UInt32 Pxor = 0x3ABF8C;
        // EXP Address
        UInt32 XpAdr = 0x3ABF98;
        UInt32 XpAdrL = 0x3ABF98 + 0x400000;
        // Mana Address
        UInt32 MpAdr = 0x3ABFE0;
        UInt32 MpAdrL = 0x3ABFE0  + 0x400000;
        // Health Address
        UInt32 HpAdr = 0x541000;
        UInt32 HpAdrL = 0x541000 + 0x400000;
        // Cap Address
        UInt32 CapAdr = 0x578E94;
        UInt32 CapAdrL = 0x578E94 + 0x400000;
        // Level Address
        UInt32 LvlAdr = 0x3ABFC8;
        UInt32 LvlAdrL = 0x3ABFC8 + 0x400000;
        // Magic Address
        UInt32 MlAdr = 0x3ABFD0;
        UInt32 MlAdrL = 0x3ABFD0 + 0x400000;
        // Name Address
        UInt32 NameAdr = 0x3ADF0B;
        UInt32 NameAdrL = 0x3ADF0B + 0x400000;
        // F1 Address
        UInt32 F1Adr = 0x3B3748;
        UInt32 F1AdrL = 0x3B3748 + 0x400000;
        // F2 Address
        UInt32 F2Adr = 0x3B3848;
        UInt32 F2AdrL = 0x3B3848 + 0x400000;

        //XPos Address
        UInt32 XAdr = 0x578ea8;
        UInt32 XAdrL = 0x578ea8 + 0x400000;
        //YPos Address
        UInt32 YAdr = 0x578eac;
        UInt32 YAdrL = 0x578eac + 0x400000;
        //ZPos Address
        UInt32 ZAdr = 0x578eb0;
        UInt32 ZAdrL = 0x578eb0 + 0x400000;





        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        //Read bytes from address
        public static byte[] ReadBytes(IntPtr Handle, Int64 Address, uint BytesToRead)
        {
            IntPtr ptrBytesRead;
            byte[] buffer = new byte[BytesToRead];
            ReadProcessMemory(Handle, new IntPtr(Address), buffer, BytesToRead, out ptrBytesRead);

            return buffer;
        }

        //Convert the result
        public static int ReadInt32(IntPtr Handle, long Address)
        {
            return BitConverter.ToInt32(ReadBytes(Handle, Address, 4), 0);
        }

        
        //Convert the result
        /*
        public static int ReadStr(IntPtr Handle, long Address)
        {
            return ASCIIEncoding.Default.GetString(ReadBytes(Handle, Address, 32));
        }
         */




        public void updateClients()
        {
            /* Ignore   
            //Get process and base
            Process[] TibiaProcess = Process.GetProcessesByName("Tibia");
            Tibia = TibiaProcess[0];
            Base = Tibia.MainModule.BaseAddress.ToInt32();

            foreach (Process pro in Process.GetProcessesByName("Tibia"))
            {

                Tibia = pro;
                Base = Tibia.MainModule.BaseAddress.ToInt32();
                int text1 = ReadInt32(Tibia.Handle, (XpAdr - 0x400000) + Base);
                listBox1.Items.Add(Convert.ToString(ReadInt32(Tibia.Handle, (XpAdr - 0x400000) + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
                listBox1.Items.Add(Convert.ToString(ReadInt32(Tibia.Handle, XpAdr + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
                listBox1.Items.Add(pro.Id);

            };
             * */


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            updateClients();
        }

        public void readX()
        {
            Process[] TibiaProcess = Process.GetProcessesByName("Tibia");
            Tibia = TibiaProcess[0];
            Base = Tibia.MainModule.BaseAddress.ToInt32();

            MessageBox.Show(Convert.ToString(ReadInt32(Tibia.Handle, (XpAdr) + Base)/* ^ ReadInt32(Tibia.Handle, Pxor + Base) */));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            readX();
        }

        public void setLabel()
        {
            Process[] TibiaProcess = Process.GetProcessesByName("Tibia");
            Tibia = TibiaProcess[0];
            Base = Tibia.MainModule.BaseAddress.ToInt32();



            /*
        public int hp;
        public int mp;
        public int xp;
        public int ml;
        public int lvl;
        public int cap;
             */


            xp = (Convert.ToInt32(ReadInt32(Tibia.Handle, (XpAdr) + Base)/* ^ ReadInt32(Tibia.Handle, Pxor + Base) */));
            hp = (Convert.ToInt32(ReadInt32(Tibia.Handle, (HpAdr) + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
            mp = (Convert.ToInt32(ReadInt32(Tibia.Handle, (MpAdr) + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
            lvl = (Convert.ToInt32(ReadInt32(Tibia.Handle, (LvlAdr) + Base)/* ^ ReadInt32(Tibia.Handle, Pxor + Base) */));
            cap = (Convert.ToInt32(ReadInt32(Tibia.Handle, (CapAdr) + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
            ml = (Convert.ToInt32(ReadInt32(Tibia.Handle, (MlAdr) + Base)/* ^ ReadInt32(Tibia.Handle, Pxor + Base) */));
            xpos = (Convert.ToInt32(ReadInt32(Tibia.Handle, (XAdr) + Base)/* ^ ReadInt32(Tibia.Handle, Pxor + Base) */));
            ypos = (Convert.ToInt32(ReadInt32(Tibia.Handle, (YAdr) + Base)/* ^ ReadInt32(Tibia.Handle, Pxor + Base) */));
            zpos = (Convert.ToInt32(ReadInt32(Tibia.Handle, (ZAdr) + Base)/* ^ ReadInt32(Tibia.Handle, Pxor + Base) */));

            exp1.Content = "Exp: " + xp;
            hp1.Content = "Hp: " + hp;
            mp1.Content = "Mp: " + mp;
            lvl1.Content = "Level: " + lvl;
            cap1.Content = "Cap: " + cap / 100;
            ml1.Content = "Ml: " + ml;
            posi.Content = "Pos: " + xpos + ", " + ypos + ", " + zpos;
            xpcalc = (50 * lvl * lvl * lvl - 150 * lvl * lvl + 400 * lvl) / 3;
            xpup = xpcalc - xp;
            tolvl.Content = "To " + (lvl+1) + ": " + xpup;
                        
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            setLabel();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
