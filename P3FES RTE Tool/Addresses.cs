using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace P3FES_RTE_Tool
{
    class Addresses
    {
        private static Mem MemLib = MainForm.MemLib;
        public const long baseAddress = 0x20836BAE;
        private static decimal personaSlot = MainForm.personaSlot;

        //Convert a string (ex. 00FF) into a byte array (ex. 0x00, 0xFF)
        public static byte[] StringToByteArray(string hex)
        {
            try
            {
                return Enumerable.Range(0, hex.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                    .ToArray();
            }
            catch(Exception e)
            {
                MessageBox.Show("Please enter a valid hex string!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public static string ByteArrayToString(byte[] array)
        {
            string bytesStr = "";

            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                    bytesStr = bytesStr + array[i].ToString("X").PadLeft(2, '0');
            }
            else
                bytesStr = "XXXX";

            return bytesStr;
        }

        public static long GetPersonaAddress(int personaSlot)
        {
            long address = baseAddress + ( (personaSlot-1)*52 );
            return address;
        }

        public static bool SetPersonaBytes(int personaSlot, byte[] personaBytes)
        {
            if(personaBytes.Length == 2)
            {
                string address = "0x" + GetPersonaAddress(personaSlot).ToString("X");

                string byte0 = "0x" + personaBytes[0].ToString("X").PadLeft(2, '0');
                string byte1 = "0x" + personaBytes[1].ToString("X").PadLeft(2, '0');

                MemLib.writeMemory(address, "bytes", byte0 + " " + byte1);

                return true;
            }

            return false;
        }

        public static byte[] GetPersonaBytes(int personaSlot)
        {
            return MemLib.readBytes("0x" + GetPersonaAddress(personaSlot).ToString("X"), 2);
        }
    }
}
