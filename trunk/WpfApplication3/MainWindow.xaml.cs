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

        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);



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

        static void read()
        {

            //Get process and base
            Process[] TibiaProcess = Process.GetProcessesByName("Tibia");
            Tibia = TibiaProcess[0];
            Base = Tibia.MainModule.BaseAddress.ToInt32();

            //Addresses to Read


            UInt32 PlayerIdWithOutXpAddress = 0x541000;
            UInt32 PlayerIdWithXpAddress = 0x541000 + 0x400000;
            UInt32 Pxor = 0x3ABF8C;

            //Using - if address is with XP Base address
            int text1 = ReadInt32(Tibia.Handle, (PlayerIdWithXpAddress - 0x400000) + Base);

            MessageBox.Show(Convert.ToString(ReadInt32(Tibia.Handle, (PlayerIdWithXpAddress - 0x400000) + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));

            //Using - Address without XP Base address
            MessageBox.Show(Convert.ToString(ReadInt32(Tibia.Handle, PlayerIdWithOutXpAddress + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
        }

        public void updateClients()
        {
            //Get process and base
            Process[] TibiaProcess = Process.GetProcessesByName("Tibia");
            Tibia = TibiaProcess[0];
            Base = Tibia.MainModule.BaseAddress.ToInt32();

            foreach (Process pro in Process.GetProcessesByName("Tibia"))
            {

                Tibia = pro;
                Base = Tibia.MainModule.BaseAddress.ToInt32();
                UInt32 PlayerExpWithOutXpAddress = 0x541000;
                UInt32 PlayerExpWithXpAddress = 0x541000 + 0x400000;
                UInt32 Pxor = 0x3ABF8C;
                int text1 = ReadInt32(Tibia.Handle, (PlayerExpWithXpAddress - 0x400000) + Base);
                listBox1.Items.Add(Convert.ToString(ReadInt32(Tibia.Handle, (PlayerExpWithXpAddress - 0x400000) + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
                listBox1.Items.Add(Convert.ToString(ReadInt32(Tibia.Handle, PlayerExpWithOutXpAddress + Base) ^ ReadInt32(Tibia.Handle, Pxor + Base)));
                listBox1.Items.Add(pro.Id);

            };

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            updateClients();
        }

    }
}
