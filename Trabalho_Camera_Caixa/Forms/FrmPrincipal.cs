using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int velocidade = 3;
        string timeVerificado = string.Empty;
        #endregion

        #region Banco
        List<Tb_registro_Model> listaRegistros = new List<Tb_registro_Model>();
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
                int x = int.Parse(txtNumeroCamera.Text);
                conteudo = x.ToString().Substring(0, 1);
            }
            catch { }

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

                        //função de igual 1 
                        if (int.Parse(conteudo) == 1)
                        {
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 2).Equals(conteudo[1] + "_"))
                            {
                                arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                            }
                        }
                        else
                        {
                            //função de 1 digito
                            if (Path.GetFileNameWithoutExtension(fi.FullName).Substring(7, 1).Equals(conteudo))
                            {
                                arquivos1.Add(new MediaPlayerList() { FileName = Path.GetFileNameWithoutExtension(fi.FullName).Substring(5, 3) + " " + Path.GetFileNameWithoutExtension(fi.FullName).Substring(22, 2) + ":" + Path.GetFileNameWithoutExtension(fi.FullName).Substring(24, 2), Path = fi.FullName });
                            }
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
        private void timerVoz_Tick(object sender, EventArgs e)
        {
            //if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    foreach (var a in listaRegistros)
            //    {
            //        if (lblTimeAtual1.Text.Equals(a.hora))
            //        {
            //            //StopFala();
            //            Falar(a.nome);
            //        }
            //    }
              
            //}

        }




        #endregion

        #region Banco
        private void btnBanco_Click(object sender, EventArgs e)
        {
            var lista = Banco.Tb_registro.RetornoCompleto();
            listaRegistros = new List<Tb_registro_Model>();
            foreach (var item in lista)
            {
                if (item.data.Equals(dateTimePicker1.Text))
                {
                    listaRegistros.Add(item);
                }
            }
            if (listaRegistros.Count>0)
            {
                MessageBox.Show($"Lista carregada, tem {listaRegistros.Count} registros para esta data.","Informação", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Nehum registro para esta data.", "Informação", MessageBoxButtons.OK);
            }
        }

        #endregion

        #endregion

        private void lblTimeAtual1_TextChanged(object sender, EventArgs e)
        {

            if (mediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                foreach (var a in listaRegistros)
                {
                    if (lblTimeAtual1.Text.Equals(a.hora))
                    {
                        //StopFala();
                        Falar(a.nome);
                    }
                }

            }
        }
    }
}
