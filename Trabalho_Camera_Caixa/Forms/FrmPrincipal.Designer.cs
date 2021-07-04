
namespace Trabalho_Camera_Caixa.Forms
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.mediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAddCaixas = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnPause1 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblRealTime1 = new System.Windows.Forms.Label();
            this.btnAvX1 = new System.Windows.Forms.Button();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeAtual1 = new System.Windows.Forms.Label();
            this.btnRetroX1 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnPrev1 = new System.Windows.Forms.Button();
            this.lblTimeTotal1 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtNumeroCamera = new System.Windows.Forms.TextBox();
            this.lblNumeroCamera = new System.Windows.Forms.Label();
            this.timerVoz = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBanco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaPlayer1
            // 
            this.mediaPlayer1.Enabled = true;
            this.mediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.mediaPlayer1.Name = "mediaPlayer1";
            this.mediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer1.OcxState")));
            this.mediaPlayer1.Size = new System.Drawing.Size(1285, 644);
            this.mediaPlayer1.TabIndex = 124;
            // 
            // btnAddCaixas
            // 
            this.btnAddCaixas.BackColor = System.Drawing.Color.White;
            this.btnAddCaixas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCaixas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCaixas.Location = new System.Drawing.Point(129, 659);
            this.btnAddCaixas.Name = "btnAddCaixas";
            this.btnAddCaixas.Size = new System.Drawing.Size(104, 26);
            this.btnAddCaixas.TabIndex = 144;
            this.btnAddCaixas.Text = "Carregar Video";
            this.btnAddCaixas.UseVisualStyleBackColor = false;
            this.btnAddCaixas.Click += new System.EventHandler(this.btnAddCaixas_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(-1, 627);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 142;
            this.lbl1.Text = "label1";
            this.lbl1.Visible = false;
            // 
            // btnPause1
            // 
            this.btnPause1.BackColor = System.Drawing.Color.White;
            this.btnPause1.FlatAppearance.BorderSize = 0;
            this.btnPause1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause1.Location = new System.Drawing.Point(792, 659);
            this.btnPause1.Name = "btnPause1";
            this.btnPause1.Size = new System.Drawing.Size(72, 22);
            this.btnPause1.TabIndex = 141;
            this.btnPause1.Text = "Pause";
            this.btnPause1.UseVisualStyleBackColor = false;
            this.btnPause1.Click += new System.EventHandler(this.btnPause1_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.BackColor = System.Drawing.Color.White;
            this.btnStop1.FlatAppearance.BorderSize = 0;
            this.btnStop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop1.Location = new System.Drawing.Point(870, 659);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(72, 22);
            this.btnStop1.TabIndex = 140;
            this.btnStop1.Text = "Stop";
            this.btnStop1.UseVisualStyleBackColor = false;
            this.btnStop1.Visible = false;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 640);
            this.progressBar1.MarqueeAnimationSpeed = 9000000;
            this.progressBar1.Maximum = 1800;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1285, 13);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 135;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.MouseLeave += new System.EventHandler(this.progressBar1_MouseLeave);
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseMove);
            // 
            // lblRealTime1
            // 
            this.lblRealTime1.AutoSize = true;
            this.lblRealTime1.ForeColor = System.Drawing.Color.White;
            this.lblRealTime1.Location = new System.Drawing.Point(1105, 664);
            this.lblRealTime1.Name = "lblRealTime1";
            this.lblRealTime1.Size = new System.Drawing.Size(21, 13);
            this.lblRealTime1.TabIndex = 134;
            this.lblRealTime1.Text = "1 x";
            // 
            // btnAvX1
            // 
            this.btnAvX1.BackColor = System.Drawing.Color.White;
            this.btnAvX1.FlatAppearance.BorderSize = 0;
            this.btnAvX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvX1.Location = new System.Drawing.Point(1026, 659);
            this.btnAvX1.Name = "btnAvX1";
            this.btnAvX1.Size = new System.Drawing.Size(29, 22);
            this.btnAvX1.TabIndex = 133;
            this.btnAvX1.Text = ">>";
            this.btnAvX1.UseVisualStyleBackColor = false;
            this.btnAvX1.Click += new System.EventHandler(this.btnAvX1_Click);
            // 
            // btnPlay1
            // 
            this.btnPlay1.BackColor = System.Drawing.Color.White;
            this.btnPlay1.FlatAppearance.BorderSize = 0;
            this.btnPlay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay1.Location = new System.Drawing.Point(714, 659);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(72, 22);
            this.btnPlay1.TabIndex = 139;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = false;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1209, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 136;
            this.label1.Text = "/";
            // 
            // lblTimeAtual1
            // 
            this.lblTimeAtual1.AutoSize = true;
            this.lblTimeAtual1.ForeColor = System.Drawing.Color.White;
            this.lblTimeAtual1.Location = new System.Drawing.Point(1154, 662);
            this.lblTimeAtual1.Name = "lblTimeAtual1";
            this.lblTimeAtual1.Size = new System.Drawing.Size(49, 13);
            this.lblTimeAtual1.TabIndex = 130;
            this.lblTimeAtual1.Text = "00:00:00";
            // 
            // btnRetroX1
            // 
            this.btnRetroX1.BackColor = System.Drawing.Color.White;
            this.btnRetroX1.FlatAppearance.BorderSize = 0;
            this.btnRetroX1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetroX1.Location = new System.Drawing.Point(991, 659);
            this.btnRetroX1.Name = "btnRetroX1";
            this.btnRetroX1.Size = new System.Drawing.Size(29, 22);
            this.btnRetroX1.TabIndex = 132;
            this.btnRetroX1.Text = "<<";
            this.btnRetroX1.UseVisualStyleBackColor = false;
            this.btnRetroX1.Click += new System.EventHandler(this.btnRetroX1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.Color.White;
            this.btnNext1.FlatAppearance.BorderSize = 0;
            this.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext1.Location = new System.Drawing.Point(1061, 659);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(29, 22);
            this.btnNext1.TabIndex = 138;
            this.btnNext1.Text = ">>|";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // btnPrev1
            // 
            this.btnPrev1.BackColor = System.Drawing.Color.White;
            this.btnPrev1.FlatAppearance.BorderSize = 0;
            this.btnPrev1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev1.Location = new System.Drawing.Point(956, 659);
            this.btnPrev1.Name = "btnPrev1";
            this.btnPrev1.Size = new System.Drawing.Size(29, 22);
            this.btnPrev1.TabIndex = 137;
            this.btnPrev1.Text = "|<<";
            this.btnPrev1.UseVisualStyleBackColor = false;
            this.btnPrev1.Click += new System.EventHandler(this.btnPrev1_Click);
            // 
            // lblTimeTotal1
            // 
            this.lblTimeTotal1.AutoSize = true;
            this.lblTimeTotal1.ForeColor = System.Drawing.Color.White;
            this.lblTimeTotal1.Location = new System.Drawing.Point(1227, 662);
            this.lblTimeTotal1.Name = "lblTimeTotal1";
            this.lblTimeTotal1.Size = new System.Drawing.Size(49, 13);
            this.lblTimeTotal1.TabIndex = 131;
            this.lblTimeTotal1.Text = "00:00:00";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.ForeColor = System.Drawing.Color.White;
            this.lblTitulo1.Location = new System.Drawing.Point(1, 693);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo1.TabIndex = 129;
            this.lblTitulo1.Text = "Titulo";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1306, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 693);
            this.listBox1.TabIndex = 145;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtNumeroCamera
            // 
            this.txtNumeroCamera.Location = new System.Drawing.Point(85, 661);
            this.txtNumeroCamera.Name = "txtNumeroCamera";
            this.txtNumeroCamera.Size = new System.Drawing.Size(38, 20);
            this.txtNumeroCamera.TabIndex = 146;
            this.txtNumeroCamera.Text = "1";
            // 
            // lblNumeroCamera
            // 
            this.lblNumeroCamera.AutoSize = true;
            this.lblNumeroCamera.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroCamera.ForeColor = System.Drawing.Color.White;
            this.lblNumeroCamera.Location = new System.Drawing.Point(17, 664);
            this.lblNumeroCamera.Name = "lblNumeroCamera";
            this.lblNumeroCamera.Size = new System.Drawing.Size(61, 13);
            this.lblNumeroCamera.TabIndex = 147;
            this.lblNumeroCamera.Text = "Camera 1-4\r\n";
            // 
            // timerVoz
            // 
            this.timerVoz.Enabled = true;
            this.timerVoz.Interval = 1000;
            this.timerVoz.Tick += new System.EventHandler(this.timerVoz_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 149;
            this.label2.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 661);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker1.TabIndex = 150;
            // 
            // btnBanco
            // 
            this.btnBanco.BackColor = System.Drawing.Color.White;
            this.btnBanco.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanco.ForeColor = System.Drawing.Color.Black;
            this.btnBanco.Location = new System.Drawing.Point(447, 659);
            this.btnBanco.Name = "btnBanco";
            this.btnBanco.Size = new System.Drawing.Size(110, 26);
            this.btnBanco.TabIndex = 151;
            this.btnBanco.Text = "Carregar Registros";
            this.btnBanco.UseVisualStyleBackColor = false;
            this.btnBanco.Click += new System.EventHandler(this.btnBanco_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.btnBanco);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumeroCamera);
            this.Controls.Add(this.txtNumeroCamera);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddCaixas);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnPause1);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblRealTime1);
            this.Controls.Add(this.btnAvX1);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeAtual1);
            this.Controls.Add(this.btnRetroX1);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.btnPrev1);
            this.Controls.Add(this.lblTimeTotal1);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.mediaPlayer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer1;
        private System.Windows.Forms.Button btnAddCaixas;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnPause1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblRealTime1;
        private System.Windows.Forms.Button btnAvX1;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeAtual1;
        private System.Windows.Forms.Button btnRetroX1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnPrev1;
        private System.Windows.Forms.Label lblTimeTotal1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtNumeroCamera;
        private System.Windows.Forms.Label lblNumeroCamera;
        private System.Windows.Forms.Timer timerVoz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBanco;
    }
}