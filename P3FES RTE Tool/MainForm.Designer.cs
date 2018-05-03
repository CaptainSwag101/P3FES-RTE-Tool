namespace P3FES_RTE_Tool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personaSlotInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.processAttachButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.personaSkillsOutput = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.getAllStatsButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.maxStatsButton = new System.Windows.Forms.Button();
            this.skillSearchButton = new System.Windows.Forms.Button();
            this.personaSearchButton = new System.Windows.Forms.Button();
            this.skillInput = new System.Windows.Forms.TextBox();
            this.skillSlot = new System.Windows.Forms.NumericUpDown();
            this.skillGetButton = new System.Windows.Forms.Button();
            this.skillSetButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.luInput = new System.Windows.Forms.NumericUpDown();
            this.luGetButton = new System.Windows.Forms.Button();
            this.luSetButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.agInput = new System.Windows.Forms.NumericUpDown();
            this.agGetButton = new System.Windows.Forms.Button();
            this.agSetButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.enInput = new System.Windows.Forms.NumericUpDown();
            this.enGetButton = new System.Windows.Forms.Button();
            this.enSetButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maInput = new System.Windows.Forms.NumericUpDown();
            this.maGetButton = new System.Windows.Forms.Button();
            this.maSetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stInput = new System.Windows.Forms.NumericUpDown();
            this.stGetButton = new System.Windows.Forms.Button();
            this.stSetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.levelInput = new System.Windows.Forms.NumericUpDown();
            this.levelGetButton = new System.Windows.Forms.Button();
            this.levelSetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.personaGetButton = new System.Windows.Forms.Button();
            this.personaSetButton = new System.Windows.Forms.Button();
            this.personaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaSlotInput)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personaSlotInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.processAttachButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // personaSlotInput
            // 
            this.personaSlotInput.Enabled = false;
            this.personaSlotInput.Location = new System.Drawing.Point(300, 29);
            this.personaSlotInput.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.personaSlotInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personaSlotInput.Name = "personaSlotInput";
            this.personaSlotInput.Size = new System.Drawing.Size(64, 20);
            this.personaSlotInput.TabIndex = 4;
            this.personaSlotInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personaSlotInput.ValueChanged += new System.EventHandler(this.personaSlotInput_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Persona Slot";
            // 
            // processAttachButton
            // 
            this.processAttachButton.Location = new System.Drawing.Point(6, 13);
            this.processAttachButton.Name = "processAttachButton";
            this.processAttachButton.Size = new System.Drawing.Size(285, 36);
            this.processAttachButton.TabIndex = 1;
            this.processAttachButton.Text = "Attach to PCSX2 Process";
            this.processAttachButton.UseVisualStyleBackColor = true;
            this.processAttachButton.Click += new System.EventHandler(this.processAttachButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(394, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(156, 17);
            this.toolStripStatusLabel1.Text = "Welcome to P3FES RTE Tool!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 325);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.personaSkillsOutput);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.getAllStatsButton);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.maxStatsButton);
            this.tabPage1.Controls.Add(this.skillSearchButton);
            this.tabPage1.Controls.Add(this.personaSearchButton);
            this.tabPage1.Controls.Add(this.skillInput);
            this.tabPage1.Controls.Add(this.skillSlot);
            this.tabPage1.Controls.Add(this.skillGetButton);
            this.tabPage1.Controls.Add(this.skillSetButton);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.luInput);
            this.tabPage1.Controls.Add(this.luGetButton);
            this.tabPage1.Controls.Add(this.luSetButton);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.agInput);
            this.tabPage1.Controls.Add(this.agGetButton);
            this.tabPage1.Controls.Add(this.agSetButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.enInput);
            this.tabPage1.Controls.Add(this.enGetButton);
            this.tabPage1.Controls.Add(this.enSetButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.maInput);
            this.tabPage1.Controls.Add(this.maGetButton);
            this.tabPage1.Controls.Add(this.maSetButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.stInput);
            this.tabPage1.Controls.Add(this.stGetButton);
            this.tabPage1.Controls.Add(this.stSetButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.levelInput);
            this.tabPage1.Controls.Add(this.levelGetButton);
            this.tabPage1.Controls.Add(this.levelSetButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.personaGetButton);
            this.tabPage1.Controls.Add(this.personaSetButton);
            this.tabPage1.Controls.Add(this.personaInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // personaSkillsOutput
            // 
            this.personaSkillsOutput.Location = new System.Drawing.Point(148, 213);
            this.personaSkillsOutput.Name = "personaSkillsOutput";
            this.personaSkillsOutput.Size = new System.Drawing.Size(207, 78);
            this.personaSkillsOutput.TabIndex = 82;
            this.personaSkillsOutput.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(145, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 13);
            this.label18.TabIndex = 81;
            this.label18.Text = "Persona Skills Output";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(74, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 80;
            this.label17.Text = "Get All Stats";
            // 
            // getAllStatsButton
            // 
            this.getAllStatsButton.Location = new System.Drawing.Point(77, 268);
            this.getAllStatsButton.Name = "getAllStatsButton";
            this.getAllStatsButton.Size = new System.Drawing.Size(65, 23);
            this.getAllStatsButton.TabIndex = 79;
            this.getAllStatsButton.Text = "Get Stats";
            this.getAllStatsButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "Max All Stats";
            // 
            // maxStatsButton
            // 
            this.maxStatsButton.Location = new System.Drawing.Point(77, 213);
            this.maxStatsButton.Name = "maxStatsButton";
            this.maxStatsButton.Size = new System.Drawing.Size(65, 23);
            this.maxStatsButton.TabIndex = 77;
            this.maxStatsButton.Text = "Set Stats";
            this.maxStatsButton.UseVisualStyleBackColor = true;
            // 
            // skillSearchButton
            // 
            this.skillSearchButton.Location = new System.Drawing.Point(290, 6);
            this.skillSearchButton.Name = "skillSearchButton";
            this.skillSearchButton.Size = new System.Drawing.Size(65, 94);
            this.skillSearchButton.TabIndex = 76;
            this.skillSearchButton.Text = "Search For Skill From List";
            this.skillSearchButton.UseVisualStyleBackColor = true;
            // 
            // personaSearchButton
            // 
            this.personaSearchButton.Location = new System.Drawing.Point(77, 3);
            this.personaSearchButton.Name = "personaSearchButton";
            this.personaSearchButton.Size = new System.Drawing.Size(65, 94);
            this.personaSearchButton.TabIndex = 75;
            this.personaSearchButton.Text = "Search For Persona From List";
            this.personaSearchButton.UseVisualStyleBackColor = true;
            // 
            // skillInput
            // 
            this.skillInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.skillInput.Location = new System.Drawing.Point(219, 19);
            this.skillInput.MaxLength = 4;
            this.skillInput.Name = "skillInput";
            this.skillInput.Size = new System.Drawing.Size(65, 20);
            this.skillInput.TabIndex = 74;
            this.skillInput.Text = "XXXX";
            // 
            // skillSlot
            // 
            this.skillSlot.Location = new System.Drawing.Point(148, 19);
            this.skillSlot.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.skillSlot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.skillSlot.Name = "skillSlot";
            this.skillSlot.Size = new System.Drawing.Size(65, 20);
            this.skillSlot.TabIndex = 73;
            this.skillSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // skillGetButton
            // 
            this.skillGetButton.Location = new System.Drawing.Point(148, 74);
            this.skillGetButton.Name = "skillGetButton";
            this.skillGetButton.Size = new System.Drawing.Size(136, 23);
            this.skillGetButton.TabIndex = 72;
            this.skillGetButton.Text = "Get Bytes";
            this.skillGetButton.UseVisualStyleBackColor = true;
            this.skillGetButton.Click += new System.EventHandler(this.skillGetButton_Click);
            // 
            // skillSetButton
            // 
            this.skillSetButton.Location = new System.Drawing.Point(148, 45);
            this.skillSetButton.Name = "skillSetButton";
            this.skillSetButton.Size = new System.Drawing.Size(136, 23);
            this.skillSetButton.TabIndex = 71;
            this.skillSetButton.Text = "Set Bytes";
            this.skillSetButton.UseVisualStyleBackColor = true;
            this.skillSetButton.Click += new System.EventHandler(this.skillSetButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Skill";
            // 
            // luInput
            // 
            this.luInput.Location = new System.Drawing.Point(8, 213);
            this.luInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.luInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.luInput.Name = "luInput";
            this.luInput.Size = new System.Drawing.Size(65, 20);
            this.luInput.TabIndex = 69;
            this.luInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // luGetButton
            // 
            this.luGetButton.Location = new System.Drawing.Point(8, 268);
            this.luGetButton.Name = "luGetButton";
            this.luGetButton.Size = new System.Drawing.Size(65, 23);
            this.luGetButton.TabIndex = 68;
            this.luGetButton.Text = "Get Bytes";
            this.luGetButton.UseVisualStyleBackColor = true;
            this.luGetButton.Click += new System.EventHandler(this.luGetButton_Click);
            // 
            // luSetButton
            // 
            this.luSetButton.Location = new System.Drawing.Point(8, 239);
            this.luSetButton.Name = "luSetButton";
            this.luSetButton.Size = new System.Drawing.Size(65, 23);
            this.luSetButton.TabIndex = 67;
            this.luSetButton.Text = "Set Bytes";
            this.luSetButton.UseVisualStyleBackColor = true;
            this.luSetButton.Click += new System.EventHandler(this.luSetButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Luck";
            // 
            // agInput
            // 
            this.agInput.Location = new System.Drawing.Point(290, 116);
            this.agInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.agInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.agInput.Name = "agInput";
            this.agInput.Size = new System.Drawing.Size(65, 20);
            this.agInput.TabIndex = 65;
            this.agInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agGetButton
            // 
            this.agGetButton.Location = new System.Drawing.Point(290, 171);
            this.agGetButton.Name = "agGetButton";
            this.agGetButton.Size = new System.Drawing.Size(65, 23);
            this.agGetButton.TabIndex = 64;
            this.agGetButton.Text = "Get Bytes";
            this.agGetButton.UseVisualStyleBackColor = true;
            this.agGetButton.Click += new System.EventHandler(this.agGetButton_Click);
            // 
            // agSetButton
            // 
            this.agSetButton.Location = new System.Drawing.Point(290, 142);
            this.agSetButton.Name = "agSetButton";
            this.agSetButton.Size = new System.Drawing.Size(65, 23);
            this.agSetButton.TabIndex = 63;
            this.agSetButton.Text = "Set Bytes";
            this.agSetButton.UseVisualStyleBackColor = true;
            this.agSetButton.Click += new System.EventHandler(this.agSetButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Agility";
            // 
            // enInput
            // 
            this.enInput.Location = new System.Drawing.Point(219, 116);
            this.enInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.enInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.enInput.Name = "enInput";
            this.enInput.Size = new System.Drawing.Size(65, 20);
            this.enInput.TabIndex = 61;
            this.enInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // enGetButton
            // 
            this.enGetButton.Location = new System.Drawing.Point(219, 171);
            this.enGetButton.Name = "enGetButton";
            this.enGetButton.Size = new System.Drawing.Size(65, 23);
            this.enGetButton.TabIndex = 60;
            this.enGetButton.Text = "Get Bytes";
            this.enGetButton.UseVisualStyleBackColor = true;
            this.enGetButton.Click += new System.EventHandler(this.enGetButton_Click);
            // 
            // enSetButton
            // 
            this.enSetButton.Location = new System.Drawing.Point(219, 142);
            this.enSetButton.Name = "enSetButton";
            this.enSetButton.Size = new System.Drawing.Size(65, 23);
            this.enSetButton.TabIndex = 59;
            this.enSetButton.Text = "Set Bytes";
            this.enSetButton.UseVisualStyleBackColor = true;
            this.enSetButton.Click += new System.EventHandler(this.enSetButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Endurance";
            // 
            // maInput
            // 
            this.maInput.Location = new System.Drawing.Point(148, 116);
            this.maInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.maInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maInput.Name = "maInput";
            this.maInput.Size = new System.Drawing.Size(65, 20);
            this.maInput.TabIndex = 57;
            this.maInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maGetButton
            // 
            this.maGetButton.Location = new System.Drawing.Point(148, 171);
            this.maGetButton.Name = "maGetButton";
            this.maGetButton.Size = new System.Drawing.Size(65, 23);
            this.maGetButton.TabIndex = 56;
            this.maGetButton.Text = "Get Bytes";
            this.maGetButton.UseVisualStyleBackColor = true;
            this.maGetButton.Click += new System.EventHandler(this.maGetButton_Click);
            // 
            // maSetButton
            // 
            this.maSetButton.Location = new System.Drawing.Point(148, 142);
            this.maSetButton.Name = "maSetButton";
            this.maSetButton.Size = new System.Drawing.Size(65, 23);
            this.maSetButton.TabIndex = 55;
            this.maSetButton.Text = "Set Bytes";
            this.maSetButton.UseVisualStyleBackColor = true;
            this.maSetButton.Click += new System.EventHandler(this.maSetButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Magic";
            // 
            // stInput
            // 
            this.stInput.Location = new System.Drawing.Point(77, 116);
            this.stInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.stInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stInput.Name = "stInput";
            this.stInput.Size = new System.Drawing.Size(65, 20);
            this.stInput.TabIndex = 53;
            this.stInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stGetButton
            // 
            this.stGetButton.Location = new System.Drawing.Point(77, 171);
            this.stGetButton.Name = "stGetButton";
            this.stGetButton.Size = new System.Drawing.Size(65, 23);
            this.stGetButton.TabIndex = 52;
            this.stGetButton.Text = "Get Bytes";
            this.stGetButton.UseVisualStyleBackColor = true;
            this.stGetButton.Click += new System.EventHandler(this.stGetButton_Click);
            // 
            // stSetButton
            // 
            this.stSetButton.Location = new System.Drawing.Point(77, 142);
            this.stSetButton.Name = "stSetButton";
            this.stSetButton.Size = new System.Drawing.Size(65, 23);
            this.stSetButton.TabIndex = 51;
            this.stSetButton.Text = "Set Bytes";
            this.stSetButton.UseVisualStyleBackColor = true;
            this.stSetButton.Click += new System.EventHandler(this.stSetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Strength";
            // 
            // levelInput
            // 
            this.levelInput.Location = new System.Drawing.Point(6, 116);
            this.levelInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.levelInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelInput.Name = "levelInput";
            this.levelInput.Size = new System.Drawing.Size(65, 20);
            this.levelInput.TabIndex = 49;
            this.levelInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // levelGetButton
            // 
            this.levelGetButton.Location = new System.Drawing.Point(6, 171);
            this.levelGetButton.Name = "levelGetButton";
            this.levelGetButton.Size = new System.Drawing.Size(65, 23);
            this.levelGetButton.TabIndex = 48;
            this.levelGetButton.Text = "Get Bytes";
            this.levelGetButton.UseVisualStyleBackColor = true;
            this.levelGetButton.Click += new System.EventHandler(this.levelGetButton_Click);
            // 
            // levelSetButton
            // 
            this.levelSetButton.Location = new System.Drawing.Point(6, 142);
            this.levelSetButton.Name = "levelSetButton";
            this.levelSetButton.Size = new System.Drawing.Size(65, 23);
            this.levelSetButton.TabIndex = 47;
            this.levelSetButton.Text = "Set Bytes";
            this.levelSetButton.UseVisualStyleBackColor = true;
            this.levelSetButton.Click += new System.EventHandler(this.levelSetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Level";
            // 
            // personaGetButton
            // 
            this.personaGetButton.Location = new System.Drawing.Point(6, 74);
            this.personaGetButton.Name = "personaGetButton";
            this.personaGetButton.Size = new System.Drawing.Size(65, 23);
            this.personaGetButton.TabIndex = 45;
            this.personaGetButton.Text = "Get Bytes";
            this.personaGetButton.UseVisualStyleBackColor = true;
            this.personaGetButton.Click += new System.EventHandler(this.personaGetButton_Click);
            // 
            // personaSetButton
            // 
            this.personaSetButton.Location = new System.Drawing.Point(6, 45);
            this.personaSetButton.Name = "personaSetButton";
            this.personaSetButton.Size = new System.Drawing.Size(65, 23);
            this.personaSetButton.TabIndex = 44;
            this.personaSetButton.Text = "Set Bytes";
            this.personaSetButton.UseVisualStyleBackColor = true;
            this.personaSetButton.Click += new System.EventHandler(this.personaSetButton_Click);
            // 
            // personaInput
            // 
            this.personaInput.Location = new System.Drawing.Point(6, 19);
            this.personaInput.MaxLength = 4;
            this.personaInput.Name = "personaInput";
            this.personaInput.Size = new System.Drawing.Size(65, 20);
            this.personaInput.TabIndex = 43;
            this.personaInput.Text = "XXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Persona";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(362, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Protag.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 434);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P3FES RTE Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaSlotInput)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button processAttachButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NumericUpDown personaSlotInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox personaSkillsOutput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button getAllStatsButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button maxStatsButton;
        private System.Windows.Forms.Button skillSearchButton;
        private System.Windows.Forms.Button personaSearchButton;
        private System.Windows.Forms.TextBox skillInput;
        private System.Windows.Forms.NumericUpDown skillSlot;
        private System.Windows.Forms.Button skillGetButton;
        private System.Windows.Forms.Button skillSetButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown luInput;
        private System.Windows.Forms.Button luGetButton;
        private System.Windows.Forms.Button luSetButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown agInput;
        private System.Windows.Forms.Button agGetButton;
        private System.Windows.Forms.Button agSetButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown enInput;
        private System.Windows.Forms.Button enGetButton;
        private System.Windows.Forms.Button enSetButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown maInput;
        private System.Windows.Forms.Button maGetButton;
        private System.Windows.Forms.Button maSetButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown stInput;
        private System.Windows.Forms.Button stGetButton;
        private System.Windows.Forms.Button stSetButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown levelInput;
        private System.Windows.Forms.Button levelGetButton;
        private System.Windows.Forms.Button levelSetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button personaGetButton;
        private System.Windows.Forms.Button personaSetButton;
        private System.Windows.Forms.TextBox personaInput;
        private System.Windows.Forms.Label label2;
    }
}

