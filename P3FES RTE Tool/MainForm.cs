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
        public static int personaSlot = 1;
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

        private void personaSlotInput_ValueChanged(object sender, EventArgs e)
        {
            personaSlot = (int)personaSlotInput.Value;
        }

        //Set Persona Bytes button
        private void personaSetButton_Click(object sender, EventArgs e)
        {
            byte[] personaBytes = Addresses.StringToByteArray(personaInput.Text);

            if(personaBytes != null)
            {
                Array.Reverse(personaBytes);

                bool result = Addresses.SetPersonaBytes(personaSlot, personaBytes);
                if (!result)
                    MessageBox.Show("Could not set persona bytes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please enter a valid hex string!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void personaGetButton_Click(object sender, EventArgs e)
        {
            byte[] personaBytes = Addresses.GetPersonaBytes(personaSlot);

            if (personaBytes != null)
            {
                Array.Reverse(personaBytes);
                personaInput.Text = Addresses.ByteArrayToString(personaBytes);
            }
            else
                MessageBox.Show("Could not get persona bytes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void skillSetButton_Click(object sender, EventArgs e)
        {
            byte[] skillBytes = Addresses.StringToByteArray(skillInput.Text);

            if(skillBytes != null)
            {
                Array.Reverse(skillBytes);

                bool result = Addresses.SetPersonaSkillBytes(personaSlot, (int)skillSlot.Value, skillBytes);
                if (!result)
                    MessageBox.Show("Could not set persona skill!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please enter a valid hex string!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void skillGetButton_Click(object sender, EventArgs e)
        {
            byte[] skillBytes = Addresses.GetPersonaSkillBytes(personaSlot, (int)skillSlot.Value);

            if (skillBytes != null)
            {
                Array.Reverse(skillBytes);
                skillInput.Text = Addresses.ByteArrayToString(skillBytes);
            }
            else
                MessageBox.Show("Could not get skill bytes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void levelGetButton_Click(object sender, EventArgs e)
        {
            levelInput.Value = Addresses.GetPersonaLevel(personaSlot);
        }

        private void levelSetButton_Click(object sender, EventArgs e)
        {
            bool result = Addresses.SetPersonaLevel(personaSlot, (int)levelInput.Value);
            if (!result)
                MessageBox.Show("Could not set persona level!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void stSetButton_Click(object sender, EventArgs e)
        {
            bool result = Addresses.SetPersonaStat(personaSlot, Addresses.PersonaStat.Strength, (int)stInput.Value);
            if (!result)
                MessageBox.Show("Could not set persona strength!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void stGetButton_Click(object sender, EventArgs e)
        {
            NumericUpDown inputControl = stInput;
            int value = Addresses.GetPersonaStat(personaSlot, Addresses.PersonaStat.Strength);

            if ( !(value < inputControl.Minimum) && !(value > inputControl.Maximum) )
                inputControl.Value = value;
            else
                MessageBox.Show("Could not get persona strength!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void maSetButton_Click(object sender, EventArgs e)
        {
            bool result = Addresses.SetPersonaStat(personaSlot, Addresses.PersonaStat.Magic, (int)maInput.Value);
            if (!result)
                MessageBox.Show("Could not set persona magic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void maGetButton_Click(object sender, EventArgs e)
        {
            NumericUpDown inputControl = maInput;
            int value = Addresses.GetPersonaStat(personaSlot, Addresses.PersonaStat.Magic);

            if ( !(value < inputControl.Minimum) && !(value > inputControl.Maximum) )
                inputControl.Value = value;
            else
                MessageBox.Show("Could not get persona magic!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void enSetButton_Click(object sender, EventArgs e)
        {
            bool result = Addresses.SetPersonaStat(personaSlot, Addresses.PersonaStat.Endurance, (int)enInput.Value);
            if (!result)
                MessageBox.Show("Could not set persona endurance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void enGetButton_Click(object sender, EventArgs e)
        {
            NumericUpDown inputControl = enInput;
            int value = Addresses.GetPersonaStat(personaSlot, Addresses.PersonaStat.Endurance);

            if (!(value < inputControl.Minimum) && !(value > inputControl.Maximum))
                inputControl.Value = value;
            else
                MessageBox.Show("Could not get persona endurance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void agSetButton_Click(object sender, EventArgs e)
        {
            bool result = Addresses.SetPersonaStat(personaSlot, Addresses.PersonaStat.Agility, (int)agInput.Value);
            if (!result)
                MessageBox.Show("Could not set persona agility!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void agGetButton_Click(object sender, EventArgs e)
        {
            NumericUpDown inputControl = agInput;
            int value = Addresses.GetPersonaStat(personaSlot, Addresses.PersonaStat.Agility);

            if (!(value < inputControl.Minimum) && !(value > inputControl.Maximum))
                inputControl.Value = value;
            else
                MessageBox.Show("Could not get persona agility!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void luSetButton_Click(object sender, EventArgs e)
        {
            bool result = Addresses.SetPersonaStat(personaSlot, Addresses.PersonaStat.Luck, (int)luInput.Value);
            if (!result)
                MessageBox.Show("Could not set persona luck!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void luGetButton_Click(object sender, EventArgs e)
        {
            NumericUpDown inputControl = luInput;
            int value = Addresses.GetPersonaStat(personaSlot, Addresses.PersonaStat.Luck);

            if (!(value < inputControl.Minimum) && !(value > inputControl.Maximum))
                inputControl.Value = value;
            else
                MessageBox.Show("Could not get persona luck!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
