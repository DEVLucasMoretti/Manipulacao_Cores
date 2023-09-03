using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManipulaçãoCores_aula47
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Color[] colors = { Color.Red, Color.Green, Color.Blue };
        private int currentIndex = 0;
        Color cor = Color.Black;
        public Form1()

        {
            InitializeComponent();
            // Inicializa o timer
            timer = new Timer();
            timer.Interval = 700; // Intervalo em milissegundos (1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Atualiza a cor das labels
            lblRgb.ForeColor = colors[currentIndex];
            lblrgb2.ForeColor = colors[(currentIndex + 1) % colors.Length];
            lblrgb3.ForeColor = colors[(currentIndex + 2) % colors.Length];
            currentIndex = (currentIndex + 1) % colors.Length;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           label1.ForeColor = Color.Red; label2.ForeColor = Color.Green; label3.ForeColor = Color.Blue;
            btnOk.BackColor = Color.RoyalBlue;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Exibir();
            trackBar1.Value = 0; trackBar2.Value = 0; trackBar3.Value = 0;
    
            label1.Text = trackBar1.Value.ToString(); label2.Text = trackBar2.Value.ToString(); label3.Text = trackBar3.Value.ToString();
            retangulo.BackColor = Color.Black;
        }
        private void Exibir()
        {
            retangulo.BackColor = cor;
            // cor = Color.FromArgb(0, 0, 0);
            cor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            Exibir();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
            Exibir();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            Exibir();
        }
        private void CorFixa(int a, int b, int c)
        {
            trackBar1.Value = a; trackBar2.Value = b; trackBar3.Value = c;
            label1.Text = trackBar1.Value.ToString(); label2.Text = trackBar2.Value.ToString(); label3.Text = trackBar3.Value.ToString();
            cor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            retangulo.BackColor = cor;
        }
        private void DigitarCor()
        {
            int a; int b; int c;  
    
            a = int.Parse(txtBox1.Text); 
            if(a >255 || a < 0){ MessageBox.Show("Algum valor está negativo ou está fora da escala (0-255). ");}
            b = int.Parse(txtBox2.Text);
            if (b > 255 || b < 0) { MessageBox.Show("Algum valor está negativo ou está fora da escala (0-255). "); }
            c = int.Parse(txtBox3.Text);
            if (c > 255 || c < 0) { MessageBox.Show("Algum valor está negativo ou está fora da escala (0-255). "); }

            if(a>-1 && b>-1 && c>-1 && a < 256  && b<256 && c < 236)
            {
                trackBar1.Value = a; trackBar2.Value = b; trackBar3.Value = c;
                label1.Text = trackBar1.Value.ToString(); label2.Text = trackBar2.Value.ToString(); label3.Text = trackBar3.Value.ToString();
                cor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                retangulo.BackColor = cor;
            }
        }
        private void amareloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(255,255,0);
        }
        private void amareloClaroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(255, 255, 0);
        }
        private void amareloLimãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(255, 250, 55);
        }
        private void douradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(255, 215, 0);
        }
        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(0, 0, 255);
        }
        private void ônixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(53, 56, 57);
        }
        private void azulCelesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(135, 206, 250);
        }
        private void índigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(75, 0, 130);
        }
        private void azulArdósiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(47, 79, 79);
        }
        private void brancoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(255, 255, 255);
        }
        private void cinzaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(128, 128, 128);
        }
        private void cinzaArdósiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(112, 128, 144);
        }
        private void laranjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(255, 165, 0);
        }
        private void laranjaEscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(255, 140, 0);
        }
        private void chocolateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(77, 50, 37);
        }
        private void mArromToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(165, 42, 42);
        }
        private void areiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(244, 164, 96);
        }
        private void begeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(245, 245, 220);
        }
        private void pretoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(0, 0, 0);
        }
        private void marfimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(244, 164, 96);
        }
        private void rosaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(255, 8, 161);
        }
        private void rosaChoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(255, 105, 180);
        }
        private void lilásEscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(200, 162, 200);
        }
        private void roxoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(128, 0, 128);
        }
        private void ametistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(153, 102, 204);
        }
        private void lavandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(149, 131, 182);
        }
        private void cianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(0, 255, 255);
        }
        private void verdeEscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(0, 100, 0);
        }
        private void verdeOlivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(128, 128, 0);
        }
        private void verdeMusgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(21, 43, 18);
        }
        private void cáquiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(240, 230, 140);
        }
        private void vermelhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CorFixa(255, 0, 0);
        }
        private void coralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(255, 127, 80);
        }
        private void vinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorFixa(100,0,0);
        }
    }
}
