using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yathzee_class;

namespace Yathzee
{
    public partial class Form2 : Form
    {
        public Random aleatoire = new Random();
        public Joueur j1;
        public Joueur j2;
        public int nbEssai;
        public int tour = 0; // Quand tour pair alors j1 joue 
        public List<Des> des_possible = new List<Des>();
        Des d1 = new Des(1);
        Des d2 = new Des(2);
        Des d3 = new Des(3);
        Des d4 = new Des(4);
        Des d5 = new Des(5);
        Des d6 = new Des(6);

        public Form2(Joueur joueur1, Joueur joueur2)
        {
            InitializeComponent();
            lbl_joueur1.Text = joueur1.Nom;
            lbl_joueur2.Text = joueur2.Nom;
            this.j1 = joueur1;
            this.j2 = joueur2;
            this.tour = tour;
            this.nbEssai =0;
            this.des_possible = des_possible;
            this.des_possible.Add(d1);
            this.des_possible.Add(d2);
            this.des_possible.Add(d3);
            this.des_possible.Add(d4);
            this.des_possible.Add(d5);
            this.des_possible.Add(d6);


        }

        private void label_selected_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            switch (label.Name)
            {

                // Pour le joueur 1 
                case "ones_p1":
                    //
                    break;
                case "twos_p1":
                    //
                    break;
                case "threes_p1":
                    //
                    break;
                case "fours_p1":
                    //
                    break;
                case "fives_p1":
                    //
                    break;
                case "sixes_p1":
                    //
                    break;
                case "sum_p1":
                    //
                    break;
                case "bonus_p1":
                    //
                    break;
                case "threeOf_p1":
                    //
                    break;
                case "fourOf_p1":
                    //
                    break;
                case "fullHouse_p1":
                    //
                    break;
                case "small_p1":
                    //
                    break;
                case "large_p1":
                    //
                    break;
                case "chance_p1":
                    //
                    break;
                case "yathzee_p1":
                    //
                    break;

                // Pour le joueur 2 

                case "ones_p2":
                    //
                    break;
                case "twos_p2":
                    //
                    break;
                case "threes_p2":
                    //
                    break;
                case "fours_p2":
                    //
                    break;
                case "fives_p2":
                    //
                    break;
                case "sixes_p2":
                    //
                    break;
                case "sum_p2":
                    //
                    break;
                case "bonus_p2":
                    //
                    break;
                case "threeOf_p2":
                    //
                    break;
                case "fourOf_p2":
                    //
                    break;
                case "fullHouse_p2":
                    //
                    break;
                case "small_p2":
                    //
                    break;
                case "large_p2":
                    //
                    break;
                case "chance_p2":
                    //
                    break;
                case "yathzee_p2":
                    //
                    break;

                default:
                    break;

            }
        }

        private void btn_jouer_Click(object sender, EventArgs e)
        {
            if(this.tour % 2 == 0 && this.nbEssai < 4) // joueur 1 joue
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!(j1.des[i].selected))
                    {
                        int nouveau_des = aleatoire.Next(1, 7);
                        Des des_alea = new Des(nouveau_des);
                        j1.des[i] = des_alea;
                        switch (i)
                        {
                            case 0:
                                d1j1.Image = Image.FromFile(j1.des[i].img_source);
                                break;
                            case 1:
                                d2j1.Image = Image.FromFile(j1.des[i].img_source);
                                break;
                            case 2:
                                d3j1.Image = Image.FromFile(j1.des[i].img_source);
                                break;
                            case 3:
                                d4j1.Image = Image.FromFile(j1.des[i].img_source);
                                break;
                            case 4:
                                d5j1.Image = Image.FromFile(j1.des[i].img_source);
                                break;
                            default:
                                break;
                        }
                    }
             
                }
                this.nbEssai += 1;
                if (this.nbEssai == 100)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        j1.des[i].suspend();
                    }
                    d1j1.Image = Image.FromFile(j1.des[0].img_source);
                    d2j1.Image = Image.FromFile(j1.des[1].img_source);
                    d3j1.Image = Image.FromFile(j1.des[2].img_source);
                    d4j1.Image = Image.FromFile(j1.des[3].img_source);
                    d5j1.Image = Image.FromFile(j1.des[4].img_source);
                    this.nbEssai = 0;
                    this.tour += 1;
                }
                j1.remplirScoreTour();
                this.remplir_tableau(1);
            } else // joueur 2
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!j2.des[i].selected)
                    {
                        int nouveau_des = aleatoire.Next(1, 7);
                        Des des_alea2 = new Des(nouveau_des);
                        j2.des[i] = des_alea2;
                        switch (i)
                        {
                            case 0:
                                d1j2.Image = Image.FromFile(j2.des[i].img_source);
                                break;
                            case 1:
                                d2j2.Image = Image.FromFile(j2.des[i].img_source);
                                break;
                            case 2:
                                d3j2.Image = Image.FromFile(j2.des[i].img_source);
                                break;
                            case 3:
                                d4j2.Image = Image.FromFile(j2.des[i].img_source);
                                break;
                            case 4:
                                d5j2.Image = Image.FromFile(j2.des[i].img_source);
                                break;
                            default:
                                break;
                        }
                    }

                }
                this.nbEssai += 1;
                if (this.nbEssai == 4)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        j2.des[i].suspend();
                    }
                    d1j2.Image = Image.FromFile(j2.des[0].img_source);
                    d2j2.Image = Image.FromFile(j2.des[1].img_source);
                    d3j2.Image = Image.FromFile(j2.des[2].img_source);
                    d4j2.Image = Image.FromFile(j2.des[3].img_source);
                    d5j2.Image = Image.FromFile(j2.des[4].img_source);
                    this.nbEssai = 0;
                    this.tour += 1;
                }
                j2.remplirScoreTour();
                test.Text = j2.des[0].value.ToString() + j2.des[1].value.ToString() + j2.des[2].value.ToString() + j2.des[3].value.ToString() + j2.des[4].value.ToString();
                this.remplir_tableau(2);
            }
        }

        private void j1_img_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            switch (image.Name)
            {
                case "d1j1":
                    if (!j1.des[0].selected)
                    {
                        j1.des[0].select();
                    }
                    else
                    {
                        j1.des[0].unselect();
                    }
                    d1j1.Image = Image.FromFile(j1.des[0].img_source);
                    break;
                case "d2j1":
                    if (!j1.des[1].selected)
                    {
                        j1.des[1].select();
                    }
                    else
                    {
                        j1.des[1].unselect();
                    }
                    d2j1.Image = Image.FromFile(j1.des[1].img_source);
                    break;
                case "d3j1":
                    if (!j1.des[2].selected)
                    {
                        j1.des[2].select();
                    }
                    else
                    {
                        j1.des[2].unselect();
                    }
                    d3j1.Image = Image.FromFile(j1.des[2].img_source);
                    break;
                case "d4j1":
                    if (!j1.des[3].selected)
                    {
                        j1.des[3].select();
                    }
                    else
                    {
                        j1.des[3].unselect();
                    }
                    d4j1.Image = Image.FromFile(j1.des[3].img_source);
                    break;
                case "d5j1":
                    if (!j1.des[4].selected)
                    {
                        j1.des[4].select();
                    }
                    else
                    {
                        j1.des[4].unselect();
                    }
                    d5j1.Image = Image.FromFile(j1.des[4].img_source);
                    break;
                default:
                    break;
            }
        }

        private void remplir_tableau(int joueur)
        {
            if (joueur == 1)
            {
                ones_p1.Text = j1.scoreTour["Ones"].ToString();
                twos_p1.Text = j1.scoreTour["Twos"].ToString();
                threes_p1.Text = j1.scoreTour["Threes"].ToString();
                fours_p1.Text = j1.scoreTour["Fours"].ToString();
                fives_p1.Text = j1.scoreTour["Fives"].ToString();
                sixes_p1.Text = j1.scoreTour["Sixes"].ToString();
                sum_p1.Text = j1.scoreTour["Sum"].ToString();
                bonus_p1.Text = j1.scoreTour["Bonus"].ToString();
                threeOf_p1.Text = j1.scoreTour["ThreesOfKind"].ToString();
                fourOf_p1.Text = j1.scoreTour["FourOfKind"].ToString();
                fullHouse_p1.Text = j1.scoreTour["FullHouse"].ToString();
                small_p1.Text = j1.scoreTour["SmallStraight"].ToString();
                large_p1.Text = j1.scoreTour["LargeStraight"].ToString();
                chance_p1.Text = j1.scoreTour["Chance"].ToString();
                yathzee_p1.Text = j1.scoreTour["Yathzee"].ToString();
            } else {
                ones_p2.Text = j2.scoreTour["Ones"].ToString();
                twos_p2.Text = j2.scoreTour["Twos"].ToString();
                threes_p2.Text = j2.scoreTour["Threes"].ToString();
                fours_p2.Text = j2.scoreTour["Fours"].ToString();
                fives_p2.Text = j2.scoreTour["Fives"].ToString();
                sixes_p2.Text = j2.scoreTour["Sixes"].ToString();
                sum_p2.Text = j2.scoreTour["Sum"].ToString();
                bonus_p2.Text = j2.scoreTour["Bonus"].ToString();
                threeOf_p2.Text = j2.scoreTour["ThreesOfKind"].ToString();
                fourOf_p2.Text = j2.scoreTour["FourOfKind"].ToString();
                fullHouse_p2.Text = j2.scoreTour["FullHouse"].ToString();
                small_p2.Text = j2.scoreTour["SmallStraight"].ToString();
                large_p2.Text = j2.scoreTour["LargeStraight"].ToString();
                chance_p2.Text = j2.scoreTour["Chance"].ToString();
                yathzee_p2.Text = j2.scoreTour["Yathzee"].ToString();
            }
        }

        private void j2_img_Click(object sender, EventArgs e)
        {
            PictureBox image = sender as PictureBox;
            switch (image.Name)
            {
                case "d1j2":
                    if (!j2.des[0].selected)
                    {
                        j2.des[0].select();
                    }
                    else
                    {
                        j2.des[0].unselect();
                    }
                    d1j2.Image = Image.FromFile(j2.des[0].img_source);
                    break;
                case "d2j2":
                    if (!j2.des[1].selected)
                    {
                        j2.des[1].select();
                    }
                    else
                    {
                        j2.des[1].unselect();
                    }
                    d2j2.Image = Image.FromFile(j2.des[1].img_source);
                    break;
                case "d3j2":
                    if (!j2.des[2].selected)
                    {
                        j2.des[2].select();
                    }
                    else
                    {
                        j2.des[2].unselect();
                    }
                    d3j2.Image = Image.FromFile(j2.des[2].img_source);
                    break;
                case "d4j2":
                    if (!j2.des[3].selected)
                    {
                        j2.des[3].select();
                    }
                    else
                    {
                        j2.des[3].unselect();
                    }
                    d4j2.Image = Image.FromFile(j2.des[3].img_source);
                    break;
                case "d5j2":
                    if (!j2.des[4].selected)
                    {
                        j2.des[4].select();
                    }
                    else
                    {
                        j2.des[4].unselect();
                    }
                    d5j2.Image = Image.FromFile(j2.des[4].img_source);
                    break;
                default:
                    break;
            }
        }
    }
}
