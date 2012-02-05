#region using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// My added namespaces
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
// End

#endregion

//The namespace of our project.
namespace TibiaInfo
{
    //The class, MainWindow.
    public partial class MainWindow : Form
    {
        #region declarations
        /* These two variables are very important to reading memory. You've probably seen the word "BasedAddress" a 
         * lot if you've been trying to program recently, and the variable "Base" is what will store this address
         * as an integer. In order to obtain the BaseAddress we will use a variable to store information on the
         * Tibia Client, making it a little easier to do. The buffer will make it easier to add memory reading
         * functions to our program later. It's not neccessary but is nice to have. */
        public static int Base = 0;
        public static Process Tibia = null;
        byte[] buffer;

        /* These are the integer variables which will store our characters information, such as health, mana,
         * experience, magic level, level, capacity, coordinates, and exp to level. */
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

        /* In these we will store some information in a string format, such as our name, first quest in the quest log. */
        public string name;
        public string quest;

        #endregion

        #region addresses
        /* Here comes a list of our addresses which we will read. Note that I posted each address twice, once just an
         * address, and once the address + 0x400000. If you're using Windows XP or have ASLR disabled for some miscallanious
         * reason, you should use the address with L on the end. For instance for the Exp Address, use XpAdrL, not XpAdr.
         * You'll also then need to remove the other ASLR related material from this, we'll get to that in a while though. */

        // XOR Address
        UInt32 Pxor = 0x3ABF8C;
        // EXP Address
        UInt32 XpAdr = 0x3ABF98;
        UInt32 XpAdrL = 0x3ABF98 + 0x400000;
        // Mana Address
        UInt32 MpAdr = 0x3ABFE0;
        UInt32 MpAdrL = 0x3ABFE0 + 0x400000;
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
        UInt32 NameAdr = 0x3b5d98;
        UInt32 NameAdrL = 0x3b5d98 + 0x400000;
        //XPos Address
        UInt32 XAdr = 0x578ea8;
        UInt32 XAdrL = 0x578ea8 + 0x400000;
        //YPos Address
        UInt32 YAdr = 0x578eac;
        UInt32 YAdrL = 0x578eac + 0x400000;
        //ZPos Address
        UInt32 ZAdr = 0x578eb0;
        UInt32 ZAdrL = 0x578eb0 + 0x400000;
        //First Quest Address
        UInt32 QstAdr = 0x3AD0D5;
        UInt32 QstAdrL = 0x3AD0D5 + 0x400000;
        //Battle List Start Address
        UInt32 BAdr = 0x541008;
        UInt32 BAdrL = 0x541008 + 0x400000;

        #endregion

        #region import functions
        // Import WindowsAPI Function to read process memory without using unmanaged code directly.
        [DllImport("kernel32.dll")]
        public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
            [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);
        #endregion

        #region formload shit
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* The formload event is where we want to select a client to use. If we don't do it here we'll have to
             * do it every time we want to do it every time we want to read any memory. For that reason, we'll do
             * this now.*/
            // Get a list of processes, store them in an array named "TibiaProcess", only include processes called Tibia.
            Process[] TibiaProcess = Process.GetProcessesByName("Tibia");
            // Declare that the client we're using is the one which comes first in the array. 
            Tibia = TibiaProcess[0];
            // Declare that the Base Address is the Base Address of the process this client uses.
            Base = Tibia.MainModule.BaseAddress.ToInt32();
            // Display the name of the character on the client which the bot is attached to.
            MessageBox.Show(ReadString(Tibia.Handle, BAdr + Base));
        }
        #endregion

        #region using imported functions

        /* Read bytes from address - This is a function, effectively, which takes X, Y, and Z input, and uses it to get A output.
         * It will take an window handle, in form of an IntPtr, an address, in form of a 64 bit Int, and BytesToRead, in form of a tiny int. */
        public static byte[] ReadBytes(IntPtr Handle, Int64 Address, uint BytesToRead)
        {
            IntPtr ptrBytesRead;
            // Declare a buffer, this is the no mans land in which the information travels to get from the memory address to our programs memory.
            byte[] buffer = new byte[BytesToRead];
            // Call to the windows function to get the information.
            ReadProcessMemory(Handle, new IntPtr(Address), buffer, BytesToRead, out ptrBytesRead);

            // The result of this function will be the contents of buffer. Any information which was stored at the memory address passed in, is now in the buffer.
            return buffer;
        }

        // This should convert the contents of "buffer" - or any other byte variable - to a usable Int32.
        public static int ReadInt32(IntPtr Handle, long Address)
        {
            return BitConverter.ToInt32(ReadBytes(Handle, Address, 4), 0);
        }

        // This should convert the contents of "buffer" - or any other byte variable - to a usable String.
        public static string ReadString(IntPtr Handle, long Address)
        {
            return System.Text.ASCIIEncoding.Default.GetString(ReadBytes(Handle, Address, 32));
        }

        #endregion

        #region walker

        #region adding
        private void addwpt()
        {
            listBox1.Items.Add(Convert.ToString(ReadInt32(Tibia.Handle, XAdr + Base) + ", " + ReadInt32(Tibia.Handle, YAdr + Base) + ", " + ReadInt32(Tibia.Handle, ZAdr + Base)));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addwpt();
        }

        #endregion

        #region removing
        private void removeButton_Click(object sender, EventArgs e)
        {
            int zero = new int();
            zero = -1;
            if (listBox1.SelectedIndex != zero)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex + 1);
            }
            else
            {
                MessageBox.Show("Please select a waypoint to remove.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("All waypoints removed.");
        }
        #endregion

        #region writing to file
        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter fs = new StreamWriter(fileName.Text, false);
            foreach (string itm in listBox1.Items)
            {
                fs.WriteLine(itm);
            }
            MessageBox.Show(null, "Wrote " + (listBox1.Items.Count) + " lines to " + fileName.Text + ".", "Saved Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fs.Close();
        }
        #endregion

        #region reading from file

        private void loadButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader read = new StreamReader(fileName.Text);
            while ((line = read.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                counter++;
            }
            read.Close();
        }
        #endregion

        #endregion

        #region statusbar updater
        
        private void statusBarTimer_Tick(object sender, EventArgs e)
        {
            statusLevel.Text = Convert.ToString(ReadInt32(Tibia.Handle, LvlAdr));
            statusExp.Text = Convert.ToString(ReadInt32(Tibia.Handle, XpAdr));
            statusHp.Text = Convert.ToString(ReadInt32(Tibia.Handle, HpAdr));
            statusMp.Text = Convert.ToString(ReadInt32(Tibia.Handle, MpAdr));
            statusToLevel.Text = "TBM" ;
        }

        #endregion
    }
}