using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSX2_CNF_Creator
{
    public partial class frmDummyFile : Form
    {
        private static string _file = "DUMMY_";

        public frmDummyFile()
        {
            InitializeComponent();
        }

        private void FrmDummyFile_Load(object sender, EventArgs e)
        {
            cbSizeMegaByte.SelectedIndex = 0;
            cbSizeGigaByte.SelectedIndex = 0;
            cbType.SelectedIndex = 0;

            labelDummyFile.Text = "Escolha o tamanho do \r\narquivo Dummy à ser criado.";
        }

        private void BtnDummy_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                if (cbSizeMegaByte.SelectedIndex == 0)
                {
                    DummyFileMegaByte(100000);
                }
                else if (cbSizeMegaByte.SelectedIndex == 1)
                {
                    DummyFileMegaByte(200000);
                }
                else if (cbSizeMegaByte.SelectedIndex == 2)
                {
                    DummyFileMegaByte(300000);
                }
                else if (cbSizeMegaByte.SelectedIndex == 3)
                {
                    DummyFileMegaByte(400000);
                }
                else
                {
                    DummyFileMegaByte(500000);
                }
            }
            else
            {
                if (cbSizeGigaByte.SelectedIndex == 0)
                {
                    DummyFileGigaByte(1024);
                }
                else if (cbSizeGigaByte.SelectedIndex == 1)
                {
                    DummyFileGigaByte(2048);
                }
                else if (cbSizeGigaByte.SelectedIndex == 2)
                {
                    DummyFileGigaByte(3072);
                }
                else if (cbSizeGigaByte.SelectedIndex == 3)
                {
                    DummyFileGigaByte(4096);
                }
                else
                {
                    DummyFileGigaByte(5120);
                }
            }
        }

        private long DummyFileGigaByte(long _dummySize)
        {
            //Create new SafeFileDialog instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Salvar DummyFile";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "DUMMY_";
            saveFileDialog1.Filter = "Arquivo Dummy (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            FileInfo arquivo = new FileInfo(_file + _dummySize);
            arquivo.Delete();

            FileStream fs = new FileStream(saveFileDialog1.FileName + _dummySize, FileMode.CreateNew);

            //Display dialog and see if OK button was pressed
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fs.Seek(_dummySize * 1024 * 1024, SeekOrigin.Begin);
                fs.WriteByte(0);
                fs.Close();
            }
            //arquivo.Replace(_file + _dummySize, "teste");
            return _dummySize;
        }

        private int DummyFileMegaByte(int _dummySize)
        {
            //Create new SafeFileDialog instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Salvar DummyFile";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "DUMMY_";
            saveFileDialog1.Filter = "Arquivo Dummy (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            FileInfo arquivo = new FileInfo(_file + _dummySize);
            arquivo.Delete();

            FileStream fs = new FileStream(saveFileDialog1.FileName + _dummySize, FileMode.CreateNew);

            //Display dialog and see if OK button was pressed
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fs.Seek(_dummySize * 1024, SeekOrigin.Begin);
                fs.WriteByte(0);
                fs.Close();
            }
            return _dummySize;
        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                cbSizeMegaByte.Visible = true;
                cbSizeGigaByte.Visible = false;
            }
            else
            {
                cbSizeMegaByte.Visible = false;
                cbSizeGigaByte.Visible = true;
            }
        }
    }
}
