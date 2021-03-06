using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Camera_Caixa.Models;
using Trabalho_Camera_Caixa.Service;


namespace Trabalho_Camera_Caixa.Forms
{
    public partial class FrmPrincipal : Form
    {
        #region Variaveis 
        
        #region Video
        int hora = 3600;
        int meiaHora = 1800;
        string conteudo = "1";
        int valor1;
        int realTime1 = 1;
        #endregion

        #region Sintese de Voz
        private static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        int volume = 100;
        int velocidade = 4;
        string timeVerificado = string.Empty;
        #endregion

        #region Banco
        List<Tb_Produtos_Model> listaProdutos = new List<Tb_Produtos_Model>();
        List<Tb_Funcionario_Model> listaFuncionario = new List<Tb_Funcionario_Model>();
        List<Tb_itens_pedidos_Model> listaItens = new List<Tb_itens_pedidos_Model>();
        List<Registro_Model> listaRegistros = new List<Registro_Model>();
        #endregion
      
        #endregion

        #region Funções

        #region Video
        void EnterForm()
        {
            try
            {
                mediaPlayer1.uiMode = "none";
            }
            catch
            {

            }


        }
        void Start1()
        {

            valor1 = int.Parse(mediaPlayer1.currentMedia.name.Substring(22, 2)) * hora;
            if (mediaPlayer1.currentMedia.name.Substring(24, 2).Equals("30"))
            {
                valor1 += meiaHora;
            }

        }
        void Play1()
        {
            try
            {
                if (mediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPaused && mediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MediaPlayerList file = listBox1.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer1.URL = file.Path;
                        mediaPlayer1.Ctlcontrols.play();
                        mediaPlayer1.stretchToFit = true;
                        Start1();

                    }
                }
                else
                {
                    mediaPlayer1.Ctlcontrols.play();

                }
            }
            catch { }
        }
        void Pause1()
        {
            mediaPlayer1.Ctlcontrols.pause();
        }
        void Stop1()
        {
            try
            {
                mediaPlayer1.Ctlcontrols.stop();
                progressBar1.Value = 0;
                realTime1 = 1;
                lblTitulo1.Text = mediaPlayer1.currentMedia.name;
                lblTimeAtual1.Text = "00:00:00";
                lblTimeTotal1.Text = "00:00:00";
                lblRealTime1.Text = string.Empty;
                lblTitulo1.Text = string.Empty;
            }
            catch { }
        }
        void Next1()
        {
            try
            {
                int quant = listBox1.Items.Count;
                int index = listBox1.SelectedIndex;

                if (index < (quant - 1) && quant > 1)
                {
                    index++;
                    listBox1.SelectedIndex = index;
                    MediaPlayerList file = listBox1.SelectedItem as MediaPlayerList;
                    if (file != null)
                    {
                        mediaPlayer1.URL = file.Path;
                        mediaPlayer1.Ctlcontrols.play();
                        Start1();

                    }
                }
            }
            catch { }



        }
        void Prev1()
        {

            try
            {
                int quant = listBox1.Items.Count;
                int index = listBox1.SelectedIndex;
                if (index > 0 && quant > 1)
                {
                    index--;
                    listBox1.SelectedIndex = index;
                }
                MediaPlayerList file = listBox1.SelectedItem as MediaPlayerList;
                if (file != null)
                {
                    mediaPlayer1.URL = file.Path;
                    mediaPlayer1.Ctlcontrols.play();
                    Start1();

                }
            }
            catch { }

        }
        #endregion
   
        #region Sintese de Voz
        void Falar(string fala)
        {
            synthesizer.SpeakAsyncCancelAll();
            synthesizer.SpeakAsync(fala);
            synthesizer.Volume = volume;
            synthesizer.Rate = velocidade;
        }
        void PauseFala()
        {
            synthesizer.Pause();
        }
        void ResumeFala()
        {
            synthesizer.Resume();
        }
        void StopFala()
        {
            synthesizer.SpeakAsyncCancelAll();
        }

        string RetornoTime(string txt)
        {
            string retorno = txt;
            DateTime time = DateTime.Parse("01/01/2000" + " " + txt);
            int valor = Convert.ToInt32(nUDTime.Value);
            retorno = time.AddSeconds(valor).ToLongTimeString();
            return retorno;
        }
        #endregion

        #region Banco
        #endregion

        #endregion

        #region Eventos
        public FrmPrincipal()
        {
            InitializeComponent();
            EnterForm();
        }
     
        #region Video
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            Play1();
        }

        private void btnPause1_Click(object sender, EventArgs e)
        {
            Pause1();
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            Stop1();
        }

        private void btnPrev1_Click(object sender, EventArgs e)
        {
            Prev1();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            Next1();
        }

        private void btnAvX1_Click(object sender, EventArgs e)
        {
            if (realTime1 < 128)
            {
                realTime1 *= 2;
            }
        }

        private void btnRetroX1_Click(object sender, EventArgs e)
        {
            if (realTime1 > 1)
            {
                realTime1 /= 2;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            #region Tela1
            try
            {

                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    #region FuncaoAvanco

                    if (realTime1 > 1)
                    {
                        lblRealTime1.Visible = true;
                    }
                    else
                    {
                        lblRealTime1.Visible = false;
                    }
                    if (realTime1 == 2)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.2f;
                    }
                    if (realTime1 == 4)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.4f;
                    }
                    if (realTime1 == 8)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 0.8f;
                    }
                    if (realTime1 == 16)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 1.6f;
                    }
                    if (realTime1 == 32)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 3.2f;
                    }
                    if (realTime1 == 64)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 6.4f;
                    }
                    if (realTime1 == 128)
                    {
                        mediaPlayer1.Ctlcontrols.currentPosition += 12.8f;
                    }
                    #endregion

                    lblTitulo1.Text = mediaPlayer1.currentMedia.name;
                    lblTimeAtual1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer1.Ctlcontrols.currentPosition + valor1) / 3600, (((int)mediaPlayer1.Ctlcontrols.currentPosition + valor1) / 60) % 60, ((int)mediaPlayer1.Ctlcontrols.currentPosition + valor1) % 60);
                    lblTimeTotal1.Text = string.Format("{0:00}:{1:00}:{2:00}", ((int)mediaPlayer1.currentMedia.duration + valor1) / 3600, (((int)mediaPlayer1.currentMedia.duration + valor1) / 60) % 60, ((int)mediaPlayer1.currentMedia.duration + valor1) % 60);
                    lblRealTime1.Text = realTime1.ToString() + "x";
                    progressBar1.Value = (int)mediaPlayer1.Ctlcontrols.currentPosition;

                    if (progressBar1.Value > 1798)
                    {
                        Next1();
                    }

                }
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    realTime1 = 1;
                    lblTitulo1.Text = mediaPlayer1.currentMedia.name;
                    lblTimeAtual1.Text = "00:00:00";
                    lblTimeTotal1.Text = "00:00:00";
                    lblRealTime1.Text = string.Empty;
                    lblTitulo1.Text = string.Empty;
                    progressBar1.Value = 0;

                }
                if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsUndefined)
                {
                    realTime1 = 1;
                    lblTitulo1.Text = mediaPlayer1.currentMedia.name;
                    lblTimeAtual1.Text = "00:00:00";
                    lblTimeTotal1.Text = "00:00:00";
                    lblRealTime1.Text = string.Empty;
                    progressBar1.Value = 0;
                    lblTitulo1.Text = string.Empty;

                }
                //fullScreem
                if (!mediaPlayer1.fullScreen)
                {
                    mediaPlayer1.uiMode = "none";
                }
            }
            catch { }
            #endregion
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - progressBar1.Bounds.X);
            // Calculate the factor for converting the position (progbarWidth/100) //
            float calcFactor = progressBar1.Width / (float)progressBar1.Maximum;
            // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
            float relativeMouse = absoluteMouse / calcFactor;

            // Set the calculated relative value to the progressbar //



            if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Value = Convert.ToInt32(relativeMouse);
                mediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
            }
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            float absoluteMouse = (PointToClient(MousePosition).X - progressBar1.Bounds.X);
            // Calculate the factor for converting the position (progbarWidth/100) //
            float calcFactor = progressBar1.Width / (float)progressBar1.Maximum;
            // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
            float relativeMouse = absoluteMouse / calcFactor;

            // Set the calculated relative value to the progressbar //
            if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbl1.Visible = true;
                lbl1.Text = string.Format("{0:00}:{1:00}:{2:00}", (valor1 + (int)relativeMouse) / 3600, ((valor1 + (int)relativeMouse) / 60) % 60, (valor1 + (int)relativeMouse) % 60); ;
                lbl1.Location = new Point(PointToClient(MousePosition).X, lbl1.Location.Y);
            }
        }

        private void progressBar1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.Visible = false;
        }

        private void btnAddCaixas_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    List<MediaPlayerList> arquivos1 = new List<MediaPlayerList>();
                    string[] files = Directory.GetFiles(folder.SelectedPath);

                    foreach (string nomeString in files)
                    {
                        FileInfo fi = new FileInfo(nomeString);
                        if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(8, 1).Equals("_"))
                        {
                            arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                        }
                        
                        
                        
                    }
                    if (arquivos1.Count>0)
                    {
                        listBox1.DataSource = arquivos1;
                        listBox1.ValueMember = "Path";
                        listBox1.DisplayMember = "FileName";
                        MessageBox.Show("Videos Carregados", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  
                   
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Sintese de Voz
        private void lblTimeAtual1_TextChanged(object sender, EventArgs e)
        {

            if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                foreach (var a in listaRegistros)
                {
                    if (RetornoTime(lblTimeAtual1.Text).Equals(a.hora)&&a.funcionario.Equals(comboBox1.SelectedValue.ToString()))
                    {
                        StopFala();
                        Falar(a.nome);
                    }
                }

            }
        }
        private void nUDVoz_ValueChanged(object sender, EventArgs e)
        {
            velocidade = Convert.ToInt32(nUDVoz.Value);
        }
        #endregion

        #region Banco
        private void btnBanco_Click(object sender, EventArgs e)
        {
            try
            {
                listaFuncionario = new List<Tb_Funcionario_Model>();
                listaFuncionario = Banco.Tb_Funcionario.RetornoCompletoHabilitado();
                comboBox1.DataSource = listaFuncionario;
                comboBox1.DisplayMember = "Nome";
                comboBox1.ValueMember = "Codigo";

                listaProdutos = Banco.Tb_Produtos.RetornoCompleto();
                var dia = DateTime.Parse(dateTimePicker1.Text).ToOADate();
                listaItens = Banco.Tb_itens_pedidos.RetornoCompletoData(dia);
                listaRegistros = new List<Registro_Model>();

                foreach (var item in listaItens)
                {
                    bool add = true;
                    Registro_Model r = new Registro_Model();
                    try
                    {
                        var produto = listaProdutos[listaProdutos.FindIndex(x => x.Codigo.Equals(item.codigo))];

                        if (produto.nome_camera.Length > 0)
                        {
                            r = new Registro_Model(item.codigo, produto.nome_camera, item.Hora, item.Codigo_funcionario);
                        }
                    }
                    catch
                    {
                        add = false;
                    }

                    if (add)
                    {
                        listaRegistros.Add(r);
                    }


                }



                if (listaRegistros.Count > 0)
                {
                    MessageBox.Show($"Lista carregada, tem {listaRegistros.Count} registros para esta data.", "Informação", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Nehum registro para esta data.", "Informação", MessageBoxButtons.OK);
                }

            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
           
        }

        private void rbRede_CheckedChanged(object sender, EventArgs e)
        {
            if (Banco.conexao.State == ConnectionState.Open)
            {
                Banco.conexao.Close();
               
            }
            Banco.conexao.ConnectionString = Banco.caminhoRede;

        }
        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (Banco.conexao.State == ConnectionState.Open)
            {
                Banco.conexao.Close();

            }
            Banco.conexao.ConnectionString = Banco.caminhoLocal;
        }



        #endregion

        #endregion

       
    }
}
