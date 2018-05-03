using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace P3FES_RTE_Tool
{
    class Addresses
    {
        private static Mem MemLib = MainForm.MemLib;

        public enum PersonaStat
        {
            Strength = 0x01,
            Magic = 0x02,
            Endurance = 0x03,
            Agility = 0x04,
            Luck = 0x05
        }

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
            catch
            {
                return null;
            }
        }

        //Convert a byte array (ex. 0x00, 0xFF) into a string (ex. 00FF)
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

        //Retrieve the starting address for a persona
        public static long GetPersonaAddress(int personaSlot)
        {
            long address = 0x20836BAE + ( (personaSlot-1)*0x34 );
            return address;
        }

        //Set the bytes of a persona stored in personaSlot
        public static bool SetPersonaBytes(int personaSlot, byte[] personaBytes)
        {
            if(personaBytes.Length == 2)
            {
                string address = "0x" + GetPersonaAddress(personaSlot).ToString("X");

                string byte0 = "0x" + personaBytes[0].ToString("X").PadLeft(2, '0');
                string byte1 = "0x" + personaBytes[1].ToString("X").PadLeft(2, '0');

                return MemLib.writeMemory(address, "bytes", byte0 + " " + byte1);
            }

            return false;
        }

        //Get the bytes of a persona stored in personaSlot
        public static byte[] GetPersonaBytes(int personaSlot)
        {
            long address = GetPersonaAddress(personaSlot);
            return MemLib.readBytes("0x" + address.ToString("X"), 2);
        }

        //Get the address of a persona skill at skillSlot in personaSlot
        public static long GetPersonaSkillAddress(int personaSlot, int skillSlot)
        {
            long address = (GetPersonaAddress(personaSlot) + 0x0A) + ( (skillSlot-1)*0x02 );
            return address;
        }

        //Set the bytes of a skill stored in skillSlot in personaSlot
        public static bool SetPersonaSkillBytes(int personaSlot, int skillSlot, byte[] skillBytes)
        {
            if(skillBytes.Length == 2)
            {
                string address = "0x" + GetPersonaSkillAddress(personaSlot, skillSlot).ToString("X");

                string byte0 = "0x" + skillBytes[0].ToString("X").PadLeft(2, '0');
                string byte1 = "0x" + skillBytes[1].ToString("X").PadLeft(2, '0');

                return MemLib.writeMemory(address, "bytes", byte0 + " " + byte1);
            }

            return false;
        }

        //Get the bytes of a skill stored in skillSlot in personaSlot
        public static byte[] GetPersonaSkillBytes(int personaSlot, int skillSlot)
        {
            long address = GetPersonaSkillAddress(personaSlot, skillSlot);
            return MemLib.readBytes("0x" + address.ToString("X"), 2);
        }

        //Get the address of a persona's level at personaSlot
        public static long GetPersonaLevelAddress(int personaSlot)
        {
            long address = (GetPersonaAddress(personaSlot) + 0x02);
            return address;
        }

        //Set the persona's level stored in personaSlot
        public static bool SetPersonaLevel(int personaSlot, int personaLevel)
        {
            long address = GetPersonaLevelAddress(personaSlot);
            return MemLib.writeMemory("0x" + address.ToString("X"), "int", personaLevel.ToString());
        }

        //Get the persona's level stored in personaSlot
        public static int GetPersonaLevel(int personaSlot)
        {
            long address = GetPersonaLevelAddress(personaSlot);
            return MemLib.readInt("0x" + address.ToString("X"));
        }

        //Get the address of a persona's stat at personaSlot
        public static long GetPersonaStatAddress(int personaSlot, PersonaStat personaStat)
        {
            long address = (GetPersonaAddress(personaSlot) + 0x19) + (long)personaStat;
            return address;
        }

        //Set the persona's stat stored in personaSlot
        public static bool SetPersonaStat(int personaSlot, PersonaStat personaStat, int statValue)
        {
            long address = GetPersonaStatAddress(personaSlot, personaStat);
            byte value = Convert.ToByte(statValue);

            return MemLib.writeMemory("0x" + address.ToString("X"), "byte", "0x" + value.ToString("X").PadLeft(2, '0'));
        }

        //Get the persona's stat stored in personaSlot
        public static int GetPersonaStat(int personaSlot, PersonaStat personaStat)
        {
            long address = GetPersonaStatAddress(personaSlot, personaStat);
            int value = MemLib.readByte("0x" + address.ToString("X"));
            return value;
        }
    }
}
