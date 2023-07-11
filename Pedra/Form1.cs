namespace Pedra
{
    public partial class Form1 : Form
    {
        static int pontos = 0;
        static int pontosb = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public static string bot()
        {
            Random rnd = new Random();
            int alea = rnd.Next(3);
            string bot;
            if (alea == 0)
            {
                bot = "Pedra";
            }

            else if (alea == 1)
            {
                bot = "Papel";

            }

            else
            {
                bot = "Tesoura";
            }

            return bot;
        }



        int jogo(string a, string b)
        {
            string j;


            if (a == b)
            {
                j = "e";
                return 0;
            }
            else if (a == "Tesoura" && b == "Papel")
            {
                j = "v";
                return 1;
            }
            else if (a == "Pedra" && b == "Tesoura")
            {
                j = "v";
                return 1;
            }
            else if (a == "Papel" && b == "Pedra")
            {
                j = "v";
                return 1;
            }
            else
            {
                j = "d";
                return 2;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tesoura;
            label1.Text = tesoura.Text;
            string escolha = bot();

            if (escolha == "Pedra")
            {
                pictureBox2.Image = Properties.Resources.pedra;
            }

            else if (escolha == "Tesoura")
            {
                pictureBox2.Image = Properties.Resources.tesoura;
            }

            else
            {
                pictureBox2.Image = Properties.Resources.papel;
            }

            label3.Text = escolha;
            int resul = jogo(label1.Text, escolha);
            if (resul == 0)
            {
                mostra.Text = "Empate";
            }

            else if (resul == 1)
            {
                mostra.Text = "Vitoria";
                pontos++;
                string g = label7.Text;
                int h = Int32.Parse(g);
                h++;
                label7.Text = h.ToString();

            }

            else
            {
                mostra.Text = "Derrota";
                pontosb++;
                string g = label7.Text;
                int h = Int32.Parse(g);
                h++;
                label7.Text = h.ToString();
            }


            if (pontos > 1)
            {
                label5.Text = pontos + " Pontos";
            }
            else
            {
                label5.Text = pontos + " Ponto";
            }

            if (pontosb > 1)
            {
                label6.Text = pontosb + " Pontos";
            }
            else
            {
                label6.Text = pontosb + " Ponto";
            }
        }

        private void pedra_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pedra;
            label1.Text = pedra.Text;
            string escolha = bot();
            label3.Text = escolha;

            if (escolha == "Pedra")
            {
                pictureBox2.Image = Properties.Resources.pedra;
            }

            else if (escolha == "Tesoura")
            {
                pictureBox2.Image = Properties.Resources.tesoura;
            }

            else
            {
                pictureBox2.Image = Properties.Resources.papel;
            }

            int resul = jogo(label1.Text, escolha);
            if (resul == 0)
            {
                mostra.Text = "Empate";
            }

            else if (resul == 1)
            {
                mostra.Text = "Vitoria";
                pontos++;
                string g = label7.Text;
                int h = Int32.Parse(g);
                h++;
                label7.Text = h.ToString();

            }

            else
            {
                mostra.Text = "Derrota";
                pontosb++;
                string g = label7.Text;
                int h = Int32.Parse(g);
                h++;
                label7.Text = h.ToString();

            }


            if (pontos > 1)
            {
                label5.Text = pontos + " Pontos";
            }
            else
            {
                label5.Text = pontos + " Ponto";
            }

            if (pontosb > 1)
            {
                label6.Text = pontosb + " Pontos";
            }
            else
            {
                label6.Text = pontosb + " Ponto";
            }
        }

        private void papel_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.papel;
            label1.Text = papel.Text;
            string escolha = bot();

            if (escolha == "Pedra")
            {
                pictureBox2.Image = Properties.Resources.pedra;
            }

            else if (escolha == "Tesoura")
            {
                pictureBox2.Image = Properties.Resources.tesoura;
            }

            else
            {
                pictureBox2.Image = Properties.Resources.papel;
            }

            label3.Text = escolha;
            int resul = jogo(label1.Text, escolha);
            if (resul == 0)
            {
                mostra.Text = "Empate";
            }

            else if (resul == 1)
            {
                mostra.Text = "Vitoria";
                pontos++;
                string g = label7.Text;
                int h = Int32.Parse(g);
                h++;
                label7.Text = h.ToString();

            }

            else
            {
                mostra.Text = "Derrota";
                pontosb++;
                string g = label7.Text;
                int h = Int32.Parse(g);
                h++;
                label7.Text = h.ToString();

            }


            if (pontos > 1)
            {
                label5.Text = pontos + " Pontos";
            }
            else
            {
                label5.Text = pontos + " Ponto";
            }

            if (pontosb > 1)
            {
                label6.Text = pontosb + " Pontos";
            }
            else
            {
                label6.Text = pontosb + " Ponto";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}