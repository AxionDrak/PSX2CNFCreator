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

namespace PSTwo_CNF
{
    public partial class Form1 : Form
    {
        private static string _file = "SYSTEM.CNF";

        /// <summary>
        /// Criamos um novo objeto do tipo StreamWriter, passamos o nome do nosso arquivo.
        /// o true informa que deve continuar gravando no arquivo, isto quer dizer que ele não vai limpar e escrever tudo de novo.
        /// Se remover o true toda vez que for gravar uma informação nosso arquivo será limpado e as informações anteriores serão perdidas.
        /// </summary>
        //private static StreamWriter streamW = new StreamWriter(_file, true);

        public Form1()
        {
            InitializeComponent();
        }

        private void TsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Text = "PSX/2 CNF Creator 1.1";
            //this.Text = String.Format("PSX/2 CNF Creator {0}", AssemblyVersion);

            cbVMode.SelectedIndex = 1;
            cbHDD.SelectedIndex = 0;
            cbTCB.SelectedIndex = 3;
            cbEvent.SelectedIndex = 9;

            // Modo PSTwo
            labelVersion.Text = "Versão:";
            labelVMode.Text = "VMode:";
            labelHDD.Text = "HDDUNITPOWER:";
            txtStack.Visible = false;
            cbEvent.Visible = false;
            cbTCB.Visible = false;
            cbVMode.Visible = true;
            cbHDD.Visible = true;

            txtInfo.Text = "== PSX/2 CNF Creator ==" +
            "\r\n\r\nBem vindo(a)!" +
            "\r\n\r\nEste programa é uma pequena ferramenta para criar o arquivo SYSTEM.CNF, " +
            "usado principalmente para homebrews no disco." +
            "\r\n\r\nO uso é bastante simples." +
            "\r\n\r\nPrimeiro, escolha a plataforma alvo (em Sistema). Depois siga as instruções (nas Abas), conforme a plataforma escolhida.";

            txtPSOne.Text = "== PSOne ==" +
            "\r\n\r\n== SEÇÃO: Criar CNF ==" +
            //INFO
            "\r\n\r\nPara inicializar um CD-ROM PSX, você precisará de um arquivo na raiz do disco chamado 'SYSTEM.CNF'." +
            "\r\n\r\nÉ isso que o PSX procura na inicialização e o que ele precisa saber para configurar e executar corretamente." +
            "\r\n\r\nNos jogos de varejo, o arquivo PS-EXE geralmente é chamado de 'SLUS-123.4'." +
            //ELF
            "\r\n\r\n== ELF ==" +
            "\r\n\r\nArquivo principal, também conhecido como o arquivo a ser executado. Simplesmente digite o nome do arquivo ELF com nomes próprios, ou seja, nomes simples. Esse será o nome do arquivo ELF a ser carregado." +
            "\r\n\r\nNOTA 1: NÃO ADICIONE BOOT." +
            "\r\nO programa PSX/2 CNF Creator fará isso automaticamente para você!" +
            "\r\n\r\nNOTA 2: Para garantir a compatibilidade use o método 8+3, ou seja, " +
            "o nome do arquivo deve ter no máximo 8 caracteres e a extensão deve ter 3 caracteres. Ex.: SNES_EMU.ELF" +
            "\r\n\r\nNOTA 3: NÃO DEIXE ESPAÇOS EM BRANCO NO NOME DO ARQUIVO EXECUTÁVEL!" +
            //TCB
            "\r\n\r\n== TCB ==" +
            "\r\n\r\nEspecifique o número de tarefas. O padrão é 4." +
            //EVENTO
            "\r\n\r\n== EVENT ==" +
            "\r\n\r\nEspecifique o número de eventos. O padrão é 10." +
            //STACK
            "\r\n\r\n== STACK ==" +
            "\r\n\r\nO valor do ponteiro da pilha onde o arquivo especificado pelo BOOT é iniciado." +
            "O padrão é 8001FF00 (não coloque '0x' na frente do endereço)." +
            //EXTRAS
            "\r\n\r\n== OBSERVAÇÕES ==" +
            "\r\n\r\nO executável do PSOne precisa ter um comprimento múltiplo de 2048 bytes." +
            "\r\n\r\nVocê pode usar um programa chamado EXEFIXUP para corrigir os arquivos executáveis do PSOne no tamanho necessário." +
            "\r\n\r\nA maioria dos PS-EXE funcionará bem sem a necessidade de executar a ferramenta EXEFIXUP, no entanto, ao usar o LoadExec, ele deve ser múltiplo de 2048. " +
            "Caso contrário, o novo arquivo executável não será inicializado ou o antigo será bloqueado durante a execução do LoadExec." +
            "\r\n\r\nTCB e EVENT correspondem à multitarefa da CPU R3000A." +
            "\r\n\r\nPor exemplo, definir TCB como 8 significa que 8 tarefas podem ser executadas ao mesmo tempo, o que seria útil se você estivesse usando um cache I ou D. As mesmas regras se aplicam ao EVENT." +
            "\r\n\r\nSe SYSTEM.CNF for ignorado, o PSOne usará como padrão 4 tarefas, 16 eventos e 0x8001FF00 como ponto de entrada da pilha." +
            "\r\n\r\nO padrão também será usado pelo executável 'MAIN.PSX'. Se não conseguir encontrá-lo, nada será inicializado e o PSX travará.";

            txtUse.Text = "== PSTwo ==" +
            "\r\n\r\n== SEÇÃO: Criar CNF ==" +
            // ELF
            "\r\n\r\n== ELF ==" +
            "\r\n\r\nArquivo principal, também conhecido como o arquivo a ser executado. Simplesmente digite o nome do arquivo ELF com nomes próprios, ou seja, nomes simples. Esse será o nome do arquivo ELF a ser carregado." +
            "\r\n\r\nNOTA 1: NÃO ADICIONE BOOT2." +
            "\r\nO programa PSX/2 CNF Creator fará isso automaticamente para você!" +
            "\r\n\r\nNOTA 2: Para garantir a compatibilidade use o método 8+3, ou seja, " +
            "o nome do arquivo deve ter no máximo 8 caracteres e a extensão deve ter 3 caracteres. Ex.: SNES_EMU.ELF" +
            "\r\n\r\nNOTA 3: NÃO DEIXE ESPAÇOS EM BRANCO NO NOME DO ARQUIVO EXECUTÁVEL!" +
            // VERSÃO
            "\r\n\r\n== VERSÃO ==" +
            "\r\n\r\nIsso mostra a versão do jogo ou programa." +
            "\r\nÉ geralmente um número, não importa muito. Se você não tiver certeza, basta escrever 1.00" +
            "\r\nVocê também pode usar letras e números. Ex.: B.12" +
            // VMODE
            "\r\n\r\n== VMODE ==" +
            "\r\n\r\nVocê tem apenas 3 opções:" +
            "\r\n\r\nPAL = sistema de cores em uso na Europa e Brasil" +
            "\r\nNTSC = sistema de cores em uso nos Estados Unidos e também compatível com as TV's no Brasil (recomendado)" +
            "\r\nPAL/NTSC = habilita o uso de ambos os sistemas de cores" +
            "\r\n\r\nNormalmente a opção NTSC funcionará em 99% dos casos" +
            // HDDUNITPOWER
            "\r\n\r\n== HDDUNITPOWER ==" +
            "\r\n\r\nVocê tem 4 opções:" +
            "\r\n\r\nNENHUM = desligar ambos" +
            "\r\nHDD = não desligar o HDD" +
            "\r\nNIC = não desligar a rede" +
            "\r\nNICHDD = não desligar ambos" +
            "\r\n\r\nBasicamente, a opção HDDUNITPOWER diz ao *HDD OSD* o que fazer antes de executar o título (geralmente em CD)." +
            "\r\n\r\nAs versões mais antigas do OSD ou sem HDD ignoram o que eles não conhecem no SYSTEM.CNF." +
            // SALVAR CNF
            "\r\n\r\n== SALVAR CNF ==" +
            "\r\n\r\nApós configurar as opções desejadas, clique em 'Salvar CNF' e pronto. " +
            "O arquivo SYSTEM.CNF será criado dentro do diretório do programa." +
            "\r\n\r\nNOTA: O programa também adciona automaticamente a linha 4 ou 5, conforme a necessidade, no SYSTEM.CNF (linha vazia).";
        }

        /*
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }*/

        /// <summary>
        /// Método que cria o arquivo SYSTEM.CNF caso ele não exista, Void por que não retorna nada.
        /// </summary>
        private static void verifyFile()
        {
            //StreamWriter streamW = new StreamWriter(_file, true);
            // Verifica se o arquivo existe, retorna true, neguei a condição, então se o arquivo não existir ele entra no IF.
            //if (!File.Exists(_file))
            if (!File.Exists(_file))
            {
                // Cria um arquivo, no caso, cria o arquivo informado na variável _file.
                File.Create(_file);
            }
            /*
            else
            {
                MessageBox.Show("Arquivo SYSTEM.CNF já existe!\r\nO arquivo será sobrescrito!", "AVISO!");
                // Apaga o arquivo, caso ele já exista.
                //File.Delete(_file);
            }*/
        }

        /// <summary>
        /// Método que limpa os formulários.
        /// </summary>
        public void clearForm()
        {
            txtCreateELF.Text = null;
            txtCreateVersion.Text = null;
            txtStack.Text = null;
            cbTCB.SelectedIndex = 3;
            cbEvent.SelectedIndex = 9;
            cbVMode.SelectedIndex = 1;
            cbHDD.SelectedIndex = 0;
        }

        /// <summary>
        /// Apaga o arquivo caso ele exista e cria um novo arquivo com os dados para PSOne.
        /// </summary>
        /// <param name="elf"></param>
        /// <param name="tcb"></param>
        /// <param name="eventone"></param>
        /// <param name="stack"></param>
        public static void writePSOneData(String elf, String tcb, String eventone, String stack)
        {
            FileInfo arquivo = new FileInfo(_file);
            arquivo.Delete();
            StreamWriter streamW = new StreamWriter(_file, true);

            //Chama nosso método que cria o arquivo caso ele não exista.
            verifyFile();

            //Através do objeto streamW acessamos o método WriteLine e passamos os textos que queremos gravar.
            streamW.WriteLine("BOOT = cdrom:" + "\\" + elf.Replace(" ", "") + ";1" + "\r\n" + "TCB = " + tcb + "\r\n" + "EVENT = " + eventone + "\r\n" + "STACK = " + stack.Replace(" ",""));
            // Exibe uma mensagem informando que os dados foram gravados.
            MessageBox.Show("Arquivo SYSTEM.CNF gravado com sucesso!", "AVISO!");

            //streamW.WriteLine("BOOT2 = cdrom0:" + "\\" + elf + ";1" + "\r\n" + "VER = " + version + "\r\n" + "VMODE = " + region + "\r\n" + "HDDUNITPOWER = " + hddunit);
            //Sempre que terminarem de ler e gravar em um arquivo é necessário fecha-lo, isto evita mutios erros.
            streamW.Close();
        }

        /// <summary>
        /// Apaga o arquivo caso ele exista e cria um novo arquivo com os dados para PSTwo.
        /// </summary>
        /// <param name="elf"></param>
        /// <param name="version"></param>
        /// <param name="region"></param>
        public static void writeData(String elf, String version, String region, String hddunit)
        {
            FileInfo arquivo = new FileInfo(_file);
            arquivo.Delete();
            //StreamWriter streamW = new StreamWriter(_file, true);

            //Create new SafeFileDialog instance
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Salvar CNF";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "SYSTEM.CNF";
            saveFileDialog1.DefaultExt = "CNF";
            saveFileDialog1.Filter = "Arquivo CNF (*.CNF)|*.CNF";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            //Display dialog and see if OK button was pressed
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Save file to file name specified to SafeFileDialog
                //StreamWriter writer = new StreamWriter(sfd.FileName);
                StreamWriter streamW = new StreamWriter(saveFileDialog1.FileName);

                //Chama nosso método que cria o arquivo caso ele não exista.
                verifyFile();

                /*Através do objeto streamW acessamos o método WriteLine e passamos os textos que queremos gravar.
                 * 
                 */
                if (hddunit == " ")
                {
                    streamW.WriteLine("BOOT2 = cdrom0:" + "\\" + elf.Replace(" ", "") + ";1" + "\r\n" + "VER = " + version.Replace(" ", "") + "\r\n" + "VMODE = " + region);
                    streamW.Close();
                    // Exibe uma mensagem informando que os dados foram gravados.
                    MessageBox.Show("Arquivo SYSTEM.CNF gravado com sucesso!", "AVISO!");
                }
                else
                {
                    streamW.WriteLine("BOOT2 = cdrom0:" + "\\" + elf.Replace(" ", "") + ";1" + "\r\n" + "VER = " + version.Replace(" ", "") + "\r\n" + "VMODE = " + region + "\r\n" + "HDDUNITPOWER = " + hddunit);
                    streamW.Close();
                    // Exibe uma mensagem informando que os dados foram gravados.
                    MessageBox.Show("Arquivo SYSTEM.CNF gravado com sucesso!", "AVISO!");
                }
                
                //streamW.Close();
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
            if (rbPSTwo.Checked)
            {
                if (txtCreateELF.Text == string.Empty || txtCreateVersion.Text == string.Empty)
                {
                    MessageBox.Show("Os valores não podem estar vazios!", "AVISO!");
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
            else if (rbPSOne.Checked)
            {
                if (txtCreateELF.Text == string.Empty || txtStack.Text == string.Empty)
                {
                    MessageBox.Show("Os valores não podem estar vazios!", "AVISO!");
                }
                else
                {
                    writePSOneData(txtCreateELF.Text, cbTCB.Text, cbEvent.Text, txtStack.Text);
                }
            }
        }

        /// <summary>
        /// RadioButton PSTwo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbPSTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPSTwo.Checked == true)
            {
                clearForm();

                labelVersion.Text = "Versão:";
                labelVMode.Text = "VMode:";
                labelHDD.Text = "HDDUNITPOWER:";

                cbTCB.Visible = false;
                cbEvent.Visible = false;
                txtStack.Visible = false;

                txtCreateVersion.Visible = true;
                cbVMode.Visible = true;
                cbHDD.Visible = true;
            }
        }

        /// <summary>
        /// RadioButton PSOne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbPSOne_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPSOne.Checked == true)
            {
                clearForm();
                labelVersion.Text = "TCB:";
                labelVMode.Text = "EVENT:";
                labelHDD.Text = "STACK:";

                cbTCB.Visible = true;
                cbEvent.Visible = true;
                txtStack.Visible = true;

                txtCreateVersion.Visible = false;
                cbVMode.Visible = false;
                cbHDD.Visible = false;
            }
        }

        /// <summary>
        /// Doações PayPal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiPayPal_Click(object sender, EventArgs e)
        {
            Process _Paypal = new Process();
            _Paypal.StartInfo = new ProcessStartInfo(@"https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=JQCLDMB277N3N&source=url");
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
    }
}
