namespace PSTwo_CNF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDummyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPayPal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMiniHDD = new System.Windows.Forms.ComboBox();
            this.cbMiniOPL = new System.Windows.Forms.ComboBox();
            this.chkMiniOPL = new System.Windows.Forms.CheckBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.cbTCB = new System.Windows.Forms.ComboBox();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.cbHDD = new System.Windows.Forms.ComboBox();
            this.labelHDD = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbVMode = new System.Windows.Forms.ComboBox();
            this.txtCreateVersion = new System.Windows.Forms.TextBox();
            this.txtCreateELF = new System.Windows.Forms.TextBox();
            this.btnSaveCNF = new System.Windows.Forms.Button();
            this.labelVMode = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelELF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPSTwo = new System.Windows.Forms.RadioButton();
            this.rbPSOne = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(93, 22);
            this.tsmiExit.Text = "Sair";
            this.tsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDummyFile});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // tsmiDummyFile
            // 
            this.tsmiDummyFile.Image = global::PSX2_CNF_Creator.Properties.Resources.trash;
            this.tsmiDummyFile.Name = "tsmiDummyFile";
            this.tsmiDummyFile.Size = new System.Drawing.Size(163, 22);
            this.tsmiDummyFile.Text = "Criar DummyFile";
            this.tsmiDummyFile.Click += new System.EventHandler(this.TsmiDummyFile_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp,
            this.toolStripMenuItem2,
            this.tsmiPayPal,
            this.toolStripMenuItem1,
            this.tsmiAbout});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Image = global::PSX2_CNF_Creator.Properties.Resources.question;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(216, 22);
            this.tsmiHelp.Text = "Exibir Ajuda";
            this.tsmiHelp.Click += new System.EventHandler(this.TsmiHelp_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmiPayPal
            // 
            this.tsmiPayPal.Image = global::PSX2_CNF_Creator.Properties.Resources.paypal;
            this.tsmiPayPal.Name = "tsmiPayPal";
            this.tsmiPayPal.Size = new System.Drawing.Size(216, 22);
            this.tsmiPayPal.Text = "Doações (PayPal)";
            this.tsmiPayPal.Click += new System.EventHandler(this.TsmiPayPal_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(216, 22);
            this.tsmiAbout.Text = "Sobre o PSX/2 CNF Creator";
            this.tsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(300, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "Axion Drak © 2019";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMiniHDD);
            this.groupBox2.Controls.Add(this.cbMiniOPL);
            this.groupBox2.Controls.Add(this.chkMiniOPL);
            this.groupBox2.Controls.Add(this.cbEvent);
            this.groupBox2.Controls.Add(this.cbTCB);
            this.groupBox2.Controls.Add(this.txtStack);
            this.groupBox2.Controls.Add(this.cbHDD);
            this.groupBox2.Controls.Add(this.labelHDD);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.cbVMode);
            this.groupBox2.Controls.Add(this.txtCreateVersion);
            this.groupBox2.Controls.Add(this.txtCreateELF);
            this.groupBox2.Controls.Add(this.btnSaveCNF);
            this.groupBox2.Controls.Add(this.labelVMode);
            this.groupBox2.Controls.Add(this.labelVersion);
            this.groupBox2.Controls.Add(this.labelELF);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 186);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criar CNF";
            // 
            // cbMiniHDD
            // 
            this.cbMiniHDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMiniHDD.FormattingEnabled = true;
            this.cbMiniHDD.Items.AddRange(new object[] {
            "HDD",
            "NIC",
            "NICHDD"});
            this.cbMiniHDD.Location = new System.Drawing.Point(113, 127);
            this.cbMiniHDD.Name = "cbMiniHDD";
            this.cbMiniHDD.Size = new System.Drawing.Size(157, 21);
            this.cbMiniHDD.TabIndex = 18;
            // 
            // cbMiniOPL
            // 
            this.cbMiniOPL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMiniOPL.FormattingEnabled = true;
            this.cbMiniOPL.Items.AddRange(new object[] {
            "BOOT2 = PATINFO",
            "BOOT2 = pfs:/EXECUTE.KELF",
            "BOOT2 = NOBOOT",
            "IOPRP = PATINFO"});
            this.cbMiniOPL.Location = new System.Drawing.Point(55, 26);
            this.cbMiniOPL.Name = "cbMiniOPL";
            this.cbMiniOPL.Size = new System.Drawing.Size(215, 21);
            this.cbMiniOPL.TabIndex = 17;
            // 
            // chkMiniOPL
            // 
            this.chkMiniOPL.AutoSize = true;
            this.chkMiniOPL.Location = new System.Drawing.Point(171, 0);
            this.chkMiniOPL.Name = "chkMiniOPL";
            this.chkMiniOPL.Size = new System.Drawing.Size(99, 17);
            this.chkMiniOPL.TabIndex = 16;
            this.chkMiniOPL.Text = "Modo OPL Mini";
            this.chkMiniOPL.UseVisualStyleBackColor = true;
            this.chkMiniOPL.CheckedChanged += new System.EventHandler(this.ChkMiniOPL_CheckedChanged);
            // 
            // cbEvent
            // 
            this.cbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbEvent.Location = new System.Drawing.Point(55, 94);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(215, 21);
            this.cbEvent.TabIndex = 15;
            // 
            // cbTCB
            // 
            this.cbTCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTCB.FormattingEnabled = true;
            this.cbTCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbTCB.Location = new System.Drawing.Point(55, 60);
            this.cbTCB.Name = "cbTCB";
            this.cbTCB.Size = new System.Drawing.Size(215, 21);
            this.cbTCB.TabIndex = 14;
            // 
            // txtStack
            // 
            this.txtStack.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStack.Location = new System.Drawing.Point(55, 127);
            this.txtStack.Name = "txtStack";
            this.txtStack.Size = new System.Drawing.Size(215, 20);
            this.txtStack.TabIndex = 12;
            // 
            // cbHDD
            // 
            this.cbHDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHDD.FormattingEnabled = true;
            this.cbHDD.Items.AddRange(new object[] {
            "NENHUM",
            "HDD",
            "NIC",
            "NICHDD"});
            this.cbHDD.Location = new System.Drawing.Point(113, 127);
            this.cbHDD.Name = "cbHDD";
            this.cbHDD.Size = new System.Drawing.Size(157, 21);
            this.cbHDD.TabIndex = 10;
            // 
            // labelHDD
            // 
            this.labelHDD.AutoSize = true;
            this.labelHDD.Location = new System.Drawing.Point(6, 130);
            this.labelHDD.Name = "labelHDD";
            this.labelHDD.Size = new System.Drawing.Size(101, 13);
            this.labelHDD.TabIndex = 9;
            this.labelHDD.Text = "HDDUNITPOWER:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // cbVMode
            // 
            this.cbVMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVMode.FormattingEnabled = true;
            this.cbVMode.Items.AddRange(new object[] {
            "PAL",
            "NTSC",
            "PAL/NTSC"});
            this.cbVMode.Location = new System.Drawing.Point(56, 94);
            this.cbVMode.Name = "cbVMode";
            this.cbVMode.Size = new System.Drawing.Size(214, 21);
            this.cbVMode.TabIndex = 6;
            // 
            // txtCreateVersion
            // 
            this.txtCreateVersion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreateVersion.Location = new System.Drawing.Point(55, 60);
            this.txtCreateVersion.Name = "txtCreateVersion";
            this.txtCreateVersion.Size = new System.Drawing.Size(215, 20);
            this.txtCreateVersion.TabIndex = 5;
            // 
            // txtCreateELF
            // 
            this.txtCreateELF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCreateELF.Location = new System.Drawing.Point(55, 26);
            this.txtCreateELF.Name = "txtCreateELF";
            this.txtCreateELF.Size = new System.Drawing.Size(215, 20);
            this.txtCreateELF.TabIndex = 4;
            // 
            // btnSaveCNF
            // 
            this.btnSaveCNF.Location = new System.Drawing.Point(195, 154);
            this.btnSaveCNF.Name = "btnSaveCNF";
            this.btnSaveCNF.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCNF.TabIndex = 3;
            this.btnSaveCNF.Text = "Salvar CNF";
            this.btnSaveCNF.UseVisualStyleBackColor = true;
            this.btnSaveCNF.Click += new System.EventHandler(this.BtnSaveCNF_Click);
            // 
            // labelVMode
            // 
            this.labelVMode.AutoSize = true;
            this.labelVMode.Location = new System.Drawing.Point(6, 97);
            this.labelVMode.Name = "labelVMode";
            this.labelVMode.Size = new System.Drawing.Size(44, 13);
            this.labelVMode.TabIndex = 2;
            this.labelVMode.Text = "VMode:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(6, 63);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(43, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Versão:";
            // 
            // labelELF
            // 
            this.labelELF.AutoSize = true;
            this.labelELF.Location = new System.Drawing.Point(6, 29);
            this.labelELF.Name = "labelELF";
            this.labelELF.Size = new System.Drawing.Size(29, 13);
            this.labelELF.TabIndex = 0;
            this.labelELF.Text = "ELF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPSTwo);
            this.groupBox1.Controls.Add(this.rbPSOne);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema";
            // 
            // rbPSTwo
            // 
            this.rbPSTwo.AutoSize = true;
            this.rbPSTwo.Checked = true;
            this.rbPSTwo.Location = new System.Drawing.Point(155, 19);
            this.rbPSTwo.Name = "rbPSTwo";
            this.rbPSTwo.Size = new System.Drawing.Size(60, 17);
            this.rbPSTwo.TabIndex = 1;
            this.rbPSTwo.TabStop = true;
            this.rbPSTwo.Text = "PSTwo";
            this.rbPSTwo.UseVisualStyleBackColor = true;
            this.rbPSTwo.CheckedChanged += new System.EventHandler(this.RbPSTwo_CheckedChanged);
            // 
            // rbPSOne
            // 
            this.rbPSOne.AutoSize = true;
            this.rbPSOne.Location = new System.Drawing.Point(72, 19);
            this.rbPSOne.Name = "rbPSOne";
            this.rbPSOne.Size = new System.Drawing.Size(59, 17);
            this.rbPSOne.TabIndex = 0;
            this.rbPSOne.Text = "PSOne";
            this.rbPSOne.UseVisualStyleBackColor = true;
            this.rbPSOne.CheckedChanged += new System.EventHandler(this.RbPSOne_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "CNF";
            this.saveFileDialog1.Filter = "Arquivo CNF (*.CNF)|*.cnf";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Salvar CNF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 333);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(316, 333);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSX/2 CNF Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelVMode;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelELF;
        private System.Windows.Forms.Button btnSaveCNF;
        private System.Windows.Forms.ComboBox cbVMode;
        private System.Windows.Forms.TextBox txtCreateVersion;
        private System.Windows.Forms.TextBox txtCreateELF;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbHDD;
        private System.Windows.Forms.Label labelHDD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPSTwo;
        private System.Windows.Forms.RadioButton rbPSOne;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.ComboBox cbTCB;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayPal;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDummyFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.CheckBox chkMiniOPL;
        private System.Windows.Forms.ComboBox cbMiniOPL;
        private System.Windows.Forms.ComboBox cbMiniHDD;
    }
}

