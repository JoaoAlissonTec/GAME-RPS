namespace RPSGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private String op_user = "", op_pc = "";
        int numAleatorio = 0, pontos = 0, recorde = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void Jogar()
        {
            if(op_user == "Pedra")
            {
                if (numAleatorio == 0)
                {
                    op_pc = "Pedra";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nEmpate");
                }
                else if (numAleatorio == 1)
                {
                    op_pc = "Papel";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nVocê perdeu");
                    pontos = 0;
                    lbl_points.Text = Convert.ToString(pontos);
                }
                else
                {
                    op_pc = "Tesoura";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nVocê ganhou");
                    pontos++;
                    lbl_points.Text = Convert.ToString(pontos);
                    if(recorde < pontos)
                    {
                        recorde = pontos;
                        lbl_bestpoints.Text = Convert.ToString(recorde);
                    }
                }
            }
            else if(op_user == "Papel")
            {
                if (numAleatorio == 0)
                {
                    op_pc = "Pedra";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nVocê ganhou");
                    pontos++;
                    lbl_points.Text = Convert.ToString(pontos);
                    if (recorde < pontos)
                    {
                        recorde = pontos;
                        lbl_bestpoints.Text = Convert.ToString(recorde);
                    }
                }
                else if (numAleatorio == 1)
                {
                    op_pc = "Papel";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nEmpate");
                }
                else
                {
                    op_pc = "Tesoura";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nVocê perdeu");
                    pontos = 0;
                    lbl_points.Text = Convert.ToString(pontos);
                }
            }
            else
            {
                if (numAleatorio == 0)
                {
                    op_pc = "Pedra";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nVocê perdeu");
                    pontos = 0;
                    lbl_points.Text = Convert.ToString(pontos);
                }
                else if (numAleatorio == 1)
                {
                    op_pc = "Papel";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nVocê ganhou");
                    pontos++;
                    lbl_points.Text = Convert.ToString(pontos);
                    if (recorde < pontos)
                    {
                        recorde = pontos;
                        lbl_bestpoints.Text = Convert.ToString(recorde);
                    }
                }
                else
                {
                    op_pc = "Tesoura";
                    MessageBox.Show("Você: " + op_user + "\nPC: " + op_pc + "\nEmpate");
                }
            }
        }
        private void btn_pedra_Click(object sender, EventArgs e)
        {
            numAleatorio = random.Next(3);
            op_user = "Pedra";
            Jogar();
        }

        private void btn_papel_Click(object sender, EventArgs e)
        {
            numAleatorio = random.Next(3);
            op_user = "Papel";
            Jogar();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_tesoura_Click(object sender, EventArgs e)
        {
            numAleatorio = random.Next(3);
            op_user = "Tesoura";
            Jogar();
        }
    }
}