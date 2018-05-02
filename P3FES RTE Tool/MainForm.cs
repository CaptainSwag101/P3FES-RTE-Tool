using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace P3FES_RTE_Tool
{
    public partial class MainForm : Form
    {
        public static decimal personaSlot = 1;
        public static Mem MemLib = new Mem();
        private static int gameProcId;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void processAttachButton_Click(object sender, EventArgs e)
        {
            gameProcId = MemLib.getProcIDFromName("pcsx2");
            if (gameProcId > 0)
            {
                MemLib.OpenProcess(gameProcId.ToString());
                MessageBox.Show("Successfully attached to PCSX2!\nProc. ID: " + gameProcId.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                personaSlotInput.Enabled = true;
                tabControl1.Enabled = true;
            }
            else
                MessageBox.Show("PCSX2 Proccess ID is invalid!\nProc. ID: " + gameProcId.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void processDetachButton_Click(object sender, EventArgs e)
        {
            MemLib.closeProcess();
            MessageBox.Show("Successfully detached from PCSX2!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void personaSlotInput_ValueChanged(object sender, EventArgs e)
        {
            personaSlot = personaSlotInput.Value;
        }

        //Set Persona Bytes button
        private void personaSetButton_Click(object sender, EventArgs e)
        {
            byte[] personaBytes = Addresses.StringToByteArray(personaInput.Text);

            if(personaBytes != null)
            {
                Array.Reverse(personaBytes);
                Addresses.SetPersonaBytes((int)personaSlot, personaBytes);
            }
        }

        private void personaGetButton_Click(object sender, EventArgs e)
        {
            byte[] personaBytes = Addresses.GetPersonaBytes((int)personaSlot);

            if (personaBytes != null)
            {
                Array.Reverse(personaBytes);
                personaInput.Text = Addresses.ByteArrayToString(personaBytes);
            }
            else
                MessageBox.Show("Could not retrieve persona bytes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
