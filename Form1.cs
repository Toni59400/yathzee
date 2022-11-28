using yathzee_class;
namespace Yathzee
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jouer_Click(object sender, EventArgs e)
        {
            if (joueur2_input.Text != "" && joueur1_input.Text != "")
            {
                txt_j1.Text = "";
                txt_j2.Text = "";
                Joueur joueur1 = new Joueur(joueur1_input.Text);
                Joueur joueur2 = new Joueur(joueur2_input.Text);
                Form2 ecranJeu = new Form2(joueur1, joueur2);
                ecranJeu.ShowDialog();

            }
            else
            {
                if (joueur2_input.Text == "")
                {
                    txt_j2.Text = "Veuillez renseigner ce champ.";
                } else
                {
                    txt_j2.Text = "";
                }

                if (joueur1_input.Text == "")
                {
                    txt_j1.Text = "Veuillez renseigner ce champ.";
                } else
                {
                    txt_j1.Text = "";
                }
            }
        }

        
    }
}