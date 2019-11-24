namespace PSX2_CNF_Creator
{
    partial class frmDummyFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSizeGigaByte = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnDummy = new System.Windows.Forms.Button();
            this.cbSizeMegaByte = new System.Windows.Forms.ComboBox();
            this.labelDummyFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho:";
            // 
            // cbSizeGigaByte
            // 
            this.cbSizeGigaByte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSizeGigaByte.FormattingEnabled = true;
            this.cbSizeGigaByte.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSizeGigaByte.Location = new System.Drawing.Point(15, 71);
            this.cbSizeGigaByte.Name = "cbSizeGigaByte";
            this.cbSizeGigaByte.Size = new System.Drawing.Size(60, 21);
            this.cbSizeGigaByte.TabIndex = 1;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.cbType.Location = new System.Drawing.Point(81, 71);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(60, 21);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.CbType_SelectedIndexChanged);
            // 
            // btnDummy
            // 
            this.btnDummy.Location = new System.Drawing.Point(148, 70);
            this.btnDummy.Name = "btnDummy";
            this.btnDummy.Size = new System.Drawing.Size(75, 24);
            this.btnDummy.TabIndex = 3;
            this.btnDummy.Text = "Criar...";
            this.btnDummy.UseVisualStyleBackColor = true;
            this.btnDummy.Click += new System.EventHandler(this.BtnDummy_Click);
            // 
            // cbSizeMegaByte
            // 
            this.cbSizeMegaByte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSizeMegaByte.FormattingEnabled = true;
            this.cbSizeMegaByte.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.cbSizeMegaByte.Location = new System.Drawing.Point(15, 71);
            this.cbSizeMegaByte.Name = "cbSizeMegaByte";
            this.cbSizeMegaByte.Size = new System.Drawing.Size(60, 21);
            this.cbSizeMegaByte.TabIndex = 4;
            // 
            // labelDummyFile
            // 
            this.labelDummyFile.AutoSize = true;
            this.labelDummyFile.Location = new System.Drawing.Point(12, 9);
            this.labelDummyFile.Name = "labelDummyFile";
            this.labelDummyFile.Size = new System.Drawing.Size(16, 13);
            this.labelDummyFile.TabIndex = 5;
            this.labelDummyFile.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // frmDummyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 106);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDummyFile);
            this.Controls.Add(this.cbSizeMegaByte);
            this.Controls.Add(this.btnDummy);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbSizeGigaByte);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDummyFile";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DummyFile";
            this.Load += new System.EventHandler(this.FrmDummyFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSizeGigaByte;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnDummy;
        private System.Windows.Forms.ComboBox cbSizeMegaByte;
        private System.Windows.Forms.Label labelDummyFile;
        private System.Windows.Forms.Label label3;
    }
}