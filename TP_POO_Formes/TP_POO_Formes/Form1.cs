using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using TP_POO_Formes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librairie;
using librairie.DessinationForme;

namespace TP_POO_Formes
{
    public partial class Form1 : Form
    {
        private List<Forme> LesForme;
        private List<string> Reponce;
        private SQL Conn;
        private int numQuestion;
        private int BonneReponce;
        private List<Forme> FormeRandom;
        static Random random;
        public Form1()
        {
            InitializeComponent();
            LesForme = new List<Forme>();
            Conn = new SQL();
            chargerFormes();

            //Initialisation des evenement pour la capture de la sourie sur les 3 Panel.
            P_Carre_pos.MouseMove += new MouseEventHandler(panel1_MouseMove);
            P_Carre_pos.MouseClick += new MouseEventHandler(panel1_MouseClick);
            P_Cercle_pos.MouseMove += new MouseEventHandler(panel1_MouseMove);
            P_Cercle_pos.MouseClick += new MouseEventHandler(panel1_MouseClick);
            P_Rectangle_pos.MouseMove += new MouseEventHandler(panel1_MouseMove);
            P_Rectangle_pos.MouseClick += new MouseEventHandler(panel1_MouseClick);

        }
        //Charger les forme dans la bdd et les range dans la liste de Formes.
        private void chargerFormes()
        {
            LesForme.AddRange(Conn.GetAllCarre());
            LesForme.AddRange(Conn.GetAllCercle());
            LesForme.AddRange(Conn.GetAllRectangle());
            ActualisationDgv();
        }
        private void ActualisationDgv()
        {
            TrieParId Trie = new TrieParId();
            LesForme.Sort(Trie);
            Dgv_P_dessiner.DataSource = null;
            Dgv_P_dessiner.DataSource = LesForme;
            Dgv_P_dessiner.Refresh();
        }
        private void Dgv_P_dessiner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                foreach (Forme uneforme in LesForme)
                {
                    if (uneforme.Id == Convert.ToInt32(Dgv_P_dessiner.Rows[e.RowIndex].Cells[0].Value))
                    {
                        switch (uneforme.Type)
                        {
                            case "Carre":
                                DessinateurCarre dc = new DessinateurCarre();
                                dc.dessiner(uneforme, this.Tableau);
                                break;
                            case "Cercle":
                                DessinateurCercle dc2 = new DessinateurCercle();
                                dc2.dessiner(uneforme, this.Tableau);
                                break;
                            case "Rectangle":
                                DessinateurRectangle dc3 = new DessinateurRectangle();
                                dc3.dessiner(uneforme, this.Tableau);
                                break;
                        }
                        break;

                    }
                }
            }
        }
        private void BT_Add_carre_Click(object sender, EventArgs e)
        {
            if (Tb_Cote_carre.Text != "" && Tb_X_carre.Text != "" && Tb_Y_carre.Text != "")
            {
                Forme Carre = new Carre(Convert.ToInt32(Tb_Cote_carre.Text), Convert.ToInt32(Tb_X_carre.Text), Convert.ToInt32(Tb_Y_carre.Text));
                Tb_Cote_carre.Text = "";
                Tb_X_carre.Text = "";
                Tb_Y_carre.Text = "";
                LesForme.Add(Carre);
                Carre f1 = (Carre)LesForme[LesForme.Count - 1];
                Conn.AddCarre(LesForme[LesForme.Count - 1].Id, f1.getC(), LesForme[LesForme.Count - 1].getposi().getX(), LesForme[LesForme.Count - 1].getposi().getY());
                ActualisationDgv();
            }
            else
                MessageBox.Show("Un champ n'a pas etais saisie");

        }

        private void Bt_Add_Cercle_Click(object sender, EventArgs e)
        {
            if (Tb_Rayon_Cercle.Text != "" && Tb_X_Cercle.Text != "" && Tb_Y_Cercle.Text != "")
            {
                Forme cercle = new Cercle(Convert.ToInt32(Tb_Rayon_Cercle.Text), Convert.ToInt32(Tb_X_Cercle.Text), Convert.ToInt32(Tb_Y_Cercle.Text));
                Tb_Rayon_Cercle.Text = "";
                Tb_X_Cercle.Text = "";
                Tb_Y_Cercle.Text = "";
                LesForme.Add(cercle);
                Cercle f1 = (Cercle)LesForme[LesForme.Count - 1];
                Conn.AddCercle(LesForme[LesForme.Count - 1].Id, f1.getR(), LesForme[LesForme.Count - 1].getposi().getX(), LesForme[LesForme.Count - 1].getposi().getY());
                ActualisationDgv();
            }
            else
                MessageBox.Show("Un champ n'a pas etais saisie");
        }

        private void Bt_Add_Rectangle_Click(object sender, EventArgs e)
        {
            if (Tb_larg_Rectangle.Text != "" && Tb_long_Rectangle.Text != "" && Tb_X_Rectangle.Text != "" && Tb_Y_Rectangle.Text != "")
            { 
                Forme Rectangle = new librairie.Rectangle(Convert.ToInt32(Tb_larg_Rectangle.Text), Convert.ToInt32(Tb_long_Rectangle.Text), Convert.ToInt32(Tb_X_Rectangle.Text), Convert.ToInt32(Tb_Y_Rectangle.Text));
                Tb_larg_Rectangle.Text = "";
                Tb_long_Rectangle.Text = "";
                Tb_X_Rectangle.Text = "";
                Tb_Y_Rectangle.Text = "";
                LesForme.Add(Rectangle);
                librairie.Rectangle f1 = (librairie.Rectangle)LesForme[LesForme.Count - 1];
                Conn.AddRectangle(LesForme[LesForme.Count - 1].Id, f1.getlong(), f1.getlarg(), LesForme[LesForme.Count - 1].getposi().getX(), LesForme[LesForme.Count - 1].getposi().getY());
                ActualisationDgv();
            }
            else
                MessageBox.Show("Un champ n'a pas etais saisie");
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {
            this.Tableau.CreateGraphics().Clear(Color.Gainsboro);
        }

        private void BT_start_Click(object sender, EventArgs e)
        {
            if (LesForme.Count >= 5)
            {
                ((Control)this.TP_Dessin).Enabled = false;
                ((Control)this.TP_CreeRect).Enabled = false;
                ((Control)this.TP_CreeCercle).Enabled = false;
                ((Control)this.TP_CreeCarre).Enabled = false;
                BT_start.Visible = false;
                lb_Start.Visible = false;
                int nb = LesForme.Count() - 1;
                FormeRandom = LesForme;
                random = new Random();
                FormeRandom.Sort((x, y) => random.Next(-2, 1));
                numQuestion = 1;
                BonneReponce = 0;
                Question();
                dessiner();
                numQuestion++;
            }
            else
                MessageBox.Show("Vous devez créer au moin 5 formes");
        }
        private void Question()
        {
            if (numQuestion == 1)
            {
                affiche_Fin_Quest.Visible = false;
                L_info_qu.Visible = true;
                L_peri.Visible = true;
                L_surface.Visible = true;
                TB_peri.Visible = true;
                TB_surface.Visible = true;
                L_Quest_num.Visible = true;
                BT_Valider_Quest.Visible = true;
                INFO_Forme.Visible = true;
                Reponce = new List<string>();
                L_Quest_num.Text = "Question " + numQuestion;
                dessiner();

            }
            else if (numQuestion == 6)
            {
                MessageBox.Show("Question Fini, Vous avez eu un score de " + BonneReponce);
                affiche_Fin_Quest.Text = "";
                foreach (string R in Reponce)
                {
                    affiche_Fin_Quest.Text += R+ "\r\n\r\n";
                }
                affiche_Fin_Quest.Visible = true;
                L_info_qu.Visible = false;
                L_peri.Visible = false;
                L_surface.Visible = false;
                TB_peri.Visible = false;
                TB_surface.Visible = false;
                L_Quest_num.Visible = false;
                BT_Valider_Quest.Visible = false;
                INFO_Forme.Visible = false;
                ((Control)this.TP_Dessin).Enabled = true;
                ((Control)this.TP_CreeRect).Enabled = true;
                ((Control)this.TP_CreeCercle).Enabled = true;
                ((Control)this.TP_CreeCarre).Enabled = true;
                BT_start.Visible = true;
                lb_Start.Visible = true;
            }
            else
            {
                L_Quest_num.Text = "Question " + numQuestion;
                dessiner();
            }
        }
        private void BT_Valider_Quest_Click(object sender, EventArgs e)
        {
            if (TB_peri.Text != "" && TB_surface.Text != "")
            {
                if ((FormeRandom[numQuestion - 2].perimetre() == Convert.ToDouble(TB_peri.Text)) || (Math.Round(FormeRandom[numQuestion - 2].perimetre(), 2)) == Math.Round(Convert.ToDouble(TB_peri.Text), 2))
                {
                    BonneReponce++;
                    Reponce.Add("A la " + L_Quest_num.Text + " , vous avez repondus que la forme a pour perimetre de " + TB_peri.Text +" et vous avez eu juste .");
                }
                else
                {
                    Reponce.Add("A la " + L_Quest_num.Text + " , vous avez repondus que la forme a pour perimetre de " + TB_peri.Text + " et vous avez eu faux , \r\nla reponce etais de :" + Math.Round(FormeRandom[numQuestion - 2].perimetre(), 2));
                }
                if (FormeRandom[numQuestion - 2].surface() == Convert.ToDouble(TB_surface.Text) || (Math.Round(FormeRandom[numQuestion - 2].surface(), 2)) == Math.Round(Convert.ToDouble(TB_surface.Text), 2))
                {
                    BonneReponce++;
                    Reponce.Add("A la " + L_Quest_num.Text + " , vous avez repondus que la forme a pour surface de " + TB_surface.Text + " et vous avez eu juste .");
                }
                else
                {
                    Reponce.Add("A la " + L_Quest_num.Text + " , vous avez repondus que la forme a pour surface de " + TB_surface.Text + " et vous avez eu faux , \r\nla reponce etais de :" + Math.Round(FormeRandom[numQuestion - 2].surface(), 2));
                }
                TB_peri.Text = "";
                TB_surface.Text = "";
                Question();
                numQuestion++;
            }
            else
            {
                MessageBox.Show("Le perimetre ou la surface n'a pas etais saisie");
            }
        }
        private void dessiner()
        {
            this.P_Quest.CreateGraphics().Clear(Color.Gainsboro);
            switch (FormeRandom[numQuestion - 1].Type)
            {
                case "Carre":
                    Carre f1 = (Carre)FormeRandom[numQuestion - 1];
                    INFO_Forme.Text = "Le carre a pour cote " + f1.getC() + " pixel .";
                    DessinateurCarre dc = new DessinateurCarre();
                    dc.dessiner(FormeRandom[numQuestion - 1], this.P_Quest);
                    break;
                case "Cercle":
                    Cercle f2 = (Cercle)FormeRandom[numQuestion - 1];
                    INFO_Forme.Text = "Le cercle a pour Rayon " + f2.getR() + " pixel .";
                    DessinateurCercle dc2 = new DessinateurCercle();
                    dc2.dessiner(FormeRandom[numQuestion - 1], this.P_Quest);
                    break;
                case "Rectangle":
                    librairie.Rectangle f3 = (librairie.Rectangle)FormeRandom[numQuestion - 1];
                    INFO_Forme.Text = "Le Rectangle a pour Largeur " + f3.getlarg() + " pixel et de Longeur " + f3.getlong()+" pixel .";
                    DessinateurRectangle dc3 = new DessinateurRectangle();
                    dc3.dessiner(FormeRandom[numQuestion - 1], this.P_Quest);
                    break;
            }
        }


        //Permet de prendre en compte que les Chiffre et la virgule 
        private void TB_peri_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void previsualiser()
        {
            if (Tb_Cote_carre.Text != "")
            {
                DessinateurCarre dc = new DessinateurCarre();
                dc.dessiner(new Carre(Convert.ToInt32(Tb_Cote_carre.Text), Convert.ToInt32(Tb_X_carre.Text), Convert.ToInt32(Tb_Y_carre.Text),"NULL"), this.P_Carre_pos);
            }else if(Tb_Rayon_Cercle.Text != "")
            {
                DessinateurCercle dc2 = new DessinateurCercle();
                dc2.dessiner(new Cercle(Convert.ToInt32(Tb_Rayon_Cercle.Text), Convert.ToInt32(Tb_X_Cercle.Text), Convert.ToInt32(Tb_Y_Cercle.Text), "NULL"), this.P_Cercle_pos);
            }
            else if (Tb_long_Rectangle.Text != "" && Tb_larg_Rectangle.Text != "")
            {
                DessinateurRectangle dc = new DessinateurRectangle();
                dc.dessiner(new librairie.Rectangle(Convert.ToInt32(Tb_larg_Rectangle.Text), Convert.ToInt32(Tb_long_Rectangle.Text), Convert.ToInt32(Tb_X_Rectangle.Text), Convert.ToInt32(Tb_Y_Rectangle.Text), "NULL"), this.P_Rectangle_pos);
            }

        }


        bool IsreadyTogetxandy = true;
        //Capture l'evenement quand la sourie est sur les panel et mes sur les TextBox X et Y les coordoner 
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (IsreadyTogetxandy)
            {
                IsreadyTogetxandy = false;
                Tb_X_carre.Text = e.X.ToString();
                Tb_Y_carre.Text = e.Y.ToString();
                Tb_X_Cercle.Text = e.X.ToString();
                Tb_Y_Cercle.Text = e.Y.ToString();
                Tb_X_Rectangle.Text = e.X.ToString();
                Tb_Y_Rectangle.Text = e.Y.ToString();
                previsualiser();
            }
            else
            {
                IsreadyTogetxandy = true;
                P_Carre_pos.Refresh();
                P_Cercle_pos.Refresh();
                P_Rectangle_pos.Refresh();
            }
        }
        //Capture l'evenement quand la sourie clique est sur les panel et mes sur les TextBox X et Y les coordoner 
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsreadyTogetxandy)
            {
                Tb_X_carre.Text = e.X.ToString();
                Tb_Y_carre.Text = e.Y.ToString();
                Tb_X_Cercle.Text = e.X.ToString();
                Tb_Y_Cercle.Text = e.Y.ToString();
                Tb_X_Rectangle.Text = e.X.ToString();
                Tb_Y_Rectangle.Text = e.Y.ToString();
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Tb_X_carre.Text = "";
            Tb_Y_carre.Text ="";
            Tb_X_Cercle.Text = "";
            Tb_Y_Cercle.Text = "";
            Tb_X_Rectangle.Text = "";
            Tb_Y_Rectangle.Text = "";
            Tb_Cote_carre.Text = "";
            Tb_Rayon_Cercle.Text = "";
            Tb_long_Rectangle.Text = "";
            Tb_larg_Rectangle.Text = "";
            P_Carre_pos.Refresh();
            P_Cercle_pos.Refresh();
            P_Rectangle_pos.Refresh();
            IsreadyTogetxandy = true;
        }
    }
}