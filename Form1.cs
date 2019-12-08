using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
// Extras
using PSX2_CNF_Creator;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace PSTwo_CNF
{
    public partial class Form1 : Form
    {
        private static string _file = "SYSTEM.CNF";

        FileInfo arquivo = new FileInfo(_file);

        /// <summary>
        /// Criamos um novo objeto do tipo StreamWriter, passamos o nome do nosso arquivo.
        /// o true informa que deve continuar gravando no arquivo, isto quer dizer que ele não vai limpar e escrever tudo de novo.
        /// Se remover o true toda vez que for gravar uma informação nosso arquivo será limpado e as informações anteriores serão perdidas.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the TsmiExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("PSX/2 CNF Creator {0}", Application.ProductVersion.Remove(5, 2));

            cbVMode.SelectedIndex = 1;
            cbHDD.SelectedIndex = 0;
            cbTCB.SelectedIndex = 3;
            cbEvent.SelectedIndex = 9;
            cbMiniOPL.SelectedIndex = 0;

            // Modo PSTwo
            labelVersion.Text = "Versão:";
            labelVMode.Text = "VMode:";
            labelHDD.Text = "HDDUNITPOWER:";
            txtStack.Visible = false;
            cbEvent.Visible = false;
            cbTCB.Visible = false;
            cbVMode.Visible = true;
            cbHDD.Visible = true;
            cbMiniOPL.Visible = false;
            cbMiniHDD.Visible = false;
        }

        /// <summary>
        /// Método que cria o arquivo SYSTEM.CNF caso ele não exista, Void por que não retorna nada.
        /// </summary>
        private static void verifyFile()
        {
            // Verifica se o arquivo existe, retorna true, neguei a condição, então se o arquivo não existir ele entra no IF.
            if (!File.Exists(_file))
            {
                // Cria um arquivo, no caso, cria o arquivo informado na variável _file.
                File.Create(_file);
            }
        }

        /// <summary>
        /// Método que limpa os formulários.
        /// </summary>
        private void clearForm()
        {
            txtCreateELF.Text = null;
            txtCreateVersion.Text = null;
            txtStack.Text = null;
            cbTCB.SelectedIndex = 3;
            cbEvent.SelectedIndex = 9;
            cbVMode.SelectedIndex = 1;
            cbHDD.SelectedIndex = 0;
            cbMiniOPL.SelectedIndex = 0;
            cbMiniHDD.SelectedIndex = 2;
        }

        /// <summary>
        /// Apaga o arquivo caso ele exista e cria um novo arquivo com os dados para PSOne.
        /// </summary>
        /// <param name="elf"></param>
        /// <param name="tcb"></param>
        /// <param name="eventone"></param>
        /// <param name="stack"></param>
        private void writePSOneData(String elf, String tcb, String eventone, String stack)
        {
            arquivo.Delete();

            // Regex
            string retstack = Regex.Replace(stack, @"[^A-Za-z0-9]+", string.Empty); // STACK
            string retelf = Regex.Replace(elf, @"[^A-Za-z0-9._]+", string.Empty); // ELF

            //Create new SafeFileDialog instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Salvar CNF",
                AddExtension = true,
                FileName = "SYSTEM.CNF",
                DefaultExt = "CNF",
                Filter = "Arquivo CNF (*.CNF)|*.CNF",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            //Display dialog and see if OK button was pressed
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Save file to file name specified to SafeFileDialog
                StreamWriter streamW = new StreamWriter(saveFileDialog1.FileName);

                //Chama nosso método que cria o arquivo caso ele não exista.
                verifyFile();

                //Através do objeto streamW acessamos o método WriteLine e passamos os textos que queremos gravar.
                streamW.WriteLine("BOOT = cdrom:" + "\\" + retelf.Replace(" ", "") + ";1" + "\r\n" + "TCB = " + tcb +
                    "\r\n" + "EVENT = " + eventone + "\r\n" + "STACK = " + retstack.Replace(" ", ""));

                //Sempre que terminarem de ler e gravar em um arquivo é necessário fecha-lo, isto evita mutios erros.
                streamW.Close();

                // Exibe uma mensagem informando que os dados foram gravados.
                MessageCheck(3);
            }
        }

        /// <summary>
        /// Apaga o arquivo caso ele exista e cria um novo arquivo com os dados para PSTwo.
        /// </summary>
        /// <param name="elf"></param>
        /// <param name="version"></param>
        /// <param name="region"></param>
        private void writeData(String elf, String version, String region, String hddunit)
        {
            arquivo.Delete();

            // Regex
            string retversion = Regex.Replace(version, @"[^A-Za-z0-9.]+", string.Empty); // VERSION
            string retelf = Regex.Replace(elf, @"[^A-Za-z0-9._]+", string.Empty); // ELF

            //Create new SafeFileDialog instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Salvar CNF",
                AddExtension = true,
                FileName = "SYSTEM.CNF",
                DefaultExt = "CNF",
                Filter = "Arquivo CNF (*.CNF)|*.CNF",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            //Display dialog and see if OK button was pressed
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Save file to file name specified to SafeFileDialog
                StreamWriter streamW = new StreamWriter(saveFileDialog1.FileName);
                
                //Chama nosso método que cria o arquivo caso ele não exista.
                verifyFile();

                //Através do objeto streamW acessamos o método WriteLine e passamos os textos que queremos gravar.
                if (hddunit == " ")
                {
                    streamW.WriteLine("BOOT2 = cdrom0:" + "\\" + retelf.Replace(" ", "") + ";1" + "\r\n" + 
                        "VER = " + retversion.Replace(" ", "") + "\r\n" + "VMODE = " + region);
                    streamW.Close();
                    // Exibe uma mensagem informando que os dados foram gravados.
                    MessageCheck(3);

                    // SDADS!@#11#$%¨&&*()907651#/*-+.__
                }
                else
                {
                    streamW.WriteLine("BOOT2 = cdrom0:" + "\\" + retelf.Replace(" ", "") + ";1" + "\r\n" + 
                        "VER = " + retversion.Replace(" ", "") + "\r\n" + "VMODE = " + region + "\r\n" + "HDDUNITPOWER = " + hddunit);
                    streamW.Close();
                    // Exibe uma mensagem informando que os dados foram gravados.
                    MessageCheck(3);
                }
            }
        }

        private void writeDataMiniOPL(String kelf, String version, String region, String hddunit)
        {
            arquivo.Delete();

            // Regex
            string retversion = Regex.Replace(version, @"[^A-Za-z0-9.]+", string.Empty); // VERSION

            //Create new SafeFileDialog instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Salvar CNF",
                AddExtension = true,
                FileName = "SYSTEM.CNF",
                DefaultExt = "CNF",
                Filter = "Arquivo CNF (*.CNF)|*.CNF",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            //Display dialog and see if OK button was pressed
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Save file to file name specified to SafeFileDialog
                StreamWriter streamW = new StreamWriter(saveFileDialog1.FileName);

                //Chama nosso método que cria o arquivo caso ele não exista.
                verifyFile();

                //Através do objeto streamW acessamos o método WriteLine e passamos os textos que queremos gravar.
                if (version != " ")
                {
                    streamW.WriteLine(kelf + "\r\n" + "VER = " + retversion.Replace(" ", "") + "\r\n" + "VMODE = " + region + "\r\n" + "HDDUNITPOWER = " + hddunit);

                    streamW.Close();
                    // Exibe uma mensagem informando que os dados foram gravados.
                    MessageCheck(3);
                }
            }
        }

        /// <summary>
        /// Limpa os dados do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        /// <summary>
        /// Acessamos nossa classe em seguida nosso método, como ele espera três String por parÂmetro, 
        /// passamos os textos armazenados em nossos campos, devem seguir a mesma ordem que estiver na classe
        /// elf, versão e vmode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveCNF_Click(object sender, EventArgs e)
        {
            string _patinfo;

            if(rbPSTwo.Checked && chkMiniOPL.Checked)
            {
                if (string.IsNullOrEmpty(txtCreateVersion.Text))
                {
                    MessageCheck(1);
                }
                else
                {
                    if (cbMiniOPL.SelectedIndex == 0)
                    {
                        _patinfo = "BOOT2 = PATINFO";
                        writeDataMiniOPL(_patinfo, txtCreateVersion.Text, cbVMode.Text, cbMiniHDD.Text);
                    }
                    else if(cbMiniOPL.SelectedIndex == 1)
                    {
                        _patinfo = "BOOT2 = pfs:/EXECUTE.KELF";
                        writeDataMiniOPL(_patinfo, txtCreateVersion.Text, cbVMode.Text, cbMiniHDD.Text);
                    }
                    else if(cbMiniOPL.SelectedIndex == 2)
                    {
                        _patinfo = "BOOT2 = NOBOOT";
                        writeDataMiniOPL(_patinfo, txtCreateVersion.Text, cbVMode.Text, cbMiniHDD.Text);
                    }
                    else
                    {
                        _patinfo = "IOPRP = PATINFO";
                        writeDataMiniOPL(_patinfo, txtCreateVersion.Text, cbVMode.Text, cbMiniHDD.Text);
                    }

                    //writeDataMiniOPL(cbMiniOPL.Text, txtCreateVersion.Text, cbVMode.Text, cbMiniHDD.Text);
                }
            }
            else if (rbPSTwo.Checked)
            {
                if (string.IsNullOrEmpty(txtCreateELF.Text) || string.IsNullOrEmpty(txtCreateVersion.Text))
                {
                    MessageCheck(1);
                }
                else if (cbHDD.SelectedIndex != 0)
                {
                    writeData(txtCreateELF.Text, txtCreateVersion.Text, cbVMode.Text, cbHDD.Text);
                }
                else
                {
                    writeData(txtCreateELF.Text, txtCreateVersion.Text, cbVMode.Text, " ");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCreateELF.Text) || string.IsNullOrEmpty(txtStack.Text))
                {
                    MessageCheck(1);
                }
                else
                {
                    writePSOneData(txtCreateELF.Text, cbTCB.Text, cbEvent.Text, txtStack.Text);
                }
            }
        }

        /// <summary>
        /// PSTwo Controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbPSTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPSTwo.Checked)
            {
                clearForm();
                // Labels
                labelVersion.Text = "Versão:";
                labelVMode.Text = "VMode:";
                labelHDD.Text = "HDDUNITPOWER:";
                // ComboBox and CheckBox
                cbTCB.Visible = false;
                cbEvent.Visible = false;
                cbVMode.Visible = true;
                cbHDD.Visible = true;
                cbHDD.Enabled = true;
                //chkMiniOPL.Checked = false;
                chkMiniOPL.Enabled = true;
                // TextBox
                txtCreateVersion.Visible = true;
                txtStack.Visible = false;                
            }
        }

        /// <summary>
        /// PSOne Controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbPSOne_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPSOne.Checked)
            {
                clearForm();
                // Labels
                labelVersion.Text = "TCB:";
                labelVMode.Text = "EVENT:";
                labelHDD.Text = "STACK:";
                // ComboBox and CheckBox
                cbTCB.Visible = true;
                cbEvent.Visible = true;
                cbVMode.Visible = false;
                cbHDD.Visible = false;
                cbHDD.Enabled = false;
                chkMiniOPL.Checked = false;
                chkMiniOPL.Enabled = false;
                // TextBox
                txtCreateVersion.Visible = false;
                txtStack.Visible = true;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the chkMiniOPL control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ChkMiniOPL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMiniOPL.Checked)
            {
                clearForm();
                // Labels
                labelELF.Text = "KELF:";
                // ComboBox and CheckBox
                cbMiniOPL.Visible = true;
                cbMiniHDD.Visible = true;
                cbHDD.Visible = false;
                // TextBox
                txtCreateELF.Visible = false;
            }
            else
            {
                clearForm();
                // Labels
                labelELF.Text = "ELF:";
                // ComboBox and CheckBox
                cbMiniOPL.Visible = false;
                cbMiniHDD.Visible = false;
                cbHDD.Visible = true;
                // TextBox
                txtCreateELF.Visible = true;
            }
        }

        /// <summary>
        /// Doações PayPal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiPayPal_Click(object sender, EventArgs e)
        {
            Process _Paypal = new Process
            {
                StartInfo = new ProcessStartInfo(@"https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JQCLDMB277N3N&source=url")
            };
            _Paypal.Start();
        }

        /// <summary>
        /// Tela About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            About _about = new About();
            _about.ShowDialog();
        }

        private void TsmiDummyFile_Click(object sender, EventArgs e)
        {
            frmDummyFile _frmDummy = new frmDummyFile();
            _frmDummy.ShowDialog();
        }

        private void TsmiHelp_Click(object sender, EventArgs e)
        {
            if (!File.Exists("psxhelp.chm"))
            {
                MessageCheck(2);
            }
            else
            {
                string _curDir = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString());
                Help.ShowHelp(this, "file://" + _curDir + "\\psxhelp.chm");
            }
        }

        public static int MessageCheck(int _numberCheck)
        {
            if(_numberCheck == 1)
            {
                MessageBox.Show("Os valores não podem estar vazios!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (_numberCheck == 2)
            {
                MessageBox.Show("O arquivo de ajuda não existe!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (_numberCheck == 3)
            {
                MessageBox.Show("Arquivo SYSTEM.CNF gravado com sucesso!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return _numberCheck;
        }
    }
}
