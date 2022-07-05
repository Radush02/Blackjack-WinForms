using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private bool Gasit, ContineAs, ContineAsDealer, EsteInsurance;
        private int cnt, CartiTrase, CartiDealer, credite, miza;
        private int[] carti;
        private string[] numecarti;
        private string tipDeCarte;
        System.Media.SoundPlayer norocos = new System.Media.SoundPlayer();
        public Form1()
        {
            carti = new int[53];
            norocos.SoundLocation = "noroc.wav";
            numecarti = new string[53];
            CartiTrase = CartiDealer = 0;
            credite = 10000;
            ContineAs = false; ContineAsDealer = false; 
            InitializeComponent();
            cnt = 0;
            labeltest.Text = ""; labeldealer.Text = ""; labelscor.Text = ""; labelscordealer.Text = "";
            GenerareCarti();
            buttonhit.Visible = false; buttonstand.Visible = false; buttondoubledown.Visible = false; buttonsurrender.Visible = false;
            insurance.Font = new Font("Segoe UI", 16, FontStyle.Regular);
        }
        //genereaza cartile in ordinea A♠,2♠,...,A♣,2♣,...,A♥,2♥,...,A♦,2♦
        private void GenerareCarti()
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 0) tipDeCarte = "♠";
                else if (i == 1) tipDeCarte = "♣";
                else if (i == 2) tipDeCarte = "♥";
                else tipDeCarte = "♦";
                for (int j = 0; j < 13; j++)
                {
                    carti[i] = (i + 1) * (j + 1);
                    if (j == 0)
                        numecarti[cnt++] = "A" + tipDeCarte;
                    else if (j < 10)
                        numecarti[cnt++] = Convert.ToString(j + 1)  + tipDeCarte;
                    else if (j == 10)
                        numecarti[cnt++] = "J " + tipDeCarte;
                    else if (j == 11)
                        numecarti[cnt++] = "Q " + tipDeCarte;
                    else if (j == 12)
                        numecarti[cnt++] = "K" + tipDeCarte;
                }
            } 
        }

        //Stand.
        private void buttonstand_Click(object sender, EventArgs e)
        {
            while (CartiDealer < 17)
                HitDealer();
            if(EsteInsurance==true)
            {
                labeldealer.Visible = true;
                labelscordealer.Visible = true;
                insurance.Text = "";
            }
            if (CartiTrase > CartiDealer || CartiDealer>21)
            {
                MessageBox.Show("Ai castigat!");
                credite += 2 * miza;
            }
            else if (CartiTrase == CartiDealer)
            {
                MessageBox.Show("Push");
                credite += miza;
            }
            else
            {
                MessageBox.Show("Ai pierdut");
                if(credite==0)
                {
                    MessageBox.Show("Ai ramas fara credite. Jocul se va inchide.");
                    Application.Exit();
                }    
            }
            labelcredite.Text = "Credite: " + Convert.ToString(credite);
            JocTerminat();

        }

        //double down. Jucatorul dubleaza pariul initial, trage o singura carte si se opreste automat
        private void DoubleDown()
        {
            Hit();
            if (CartiTrase > 21)
            {
                MessageBox.Show("Ai pierdut");
                if (credite <=10)
                {
                    MessageBox.Show("Ai ramas fara credite. Jocul se va inchide.");
                    Application.Exit();
                }
            }
            else
            {
                if (EsteInsurance == true)
                {
                    labeldealer.Visible = true;
                    labelscordealer.Visible = true;
                    insurance.Text = "";
                }
                while (CartiDealer < 17)
                    HitDealer();
                if (CartiTrase > CartiDealer || CartiDealer > 21)
                {
                    MessageBox.Show("Ai castigat!");
                    credite += 4 * miza; //pariu initial + dublu
                }
                else if (CartiTrase == CartiDealer)
                {
                    MessageBox.Show("Push");
                    credite += 2 * miza;
                }
                else
                {
                    MessageBox.Show("Ai pierdut");
                    if (credite <=10)
                    {
                        MessageBox.Show("Ai ramas fara credite. Jocul se va inchide.");
                        Application.Exit();
                    }
                }
            }
            labelcredite.Text = "Credite: " + Convert.ToString(credite);
            JocTerminat();
        }

        private void buttondoubledown_Click(object sender, EventArgs e)
        {
            if (credite < miza)
                MessageBox.Show("Nu ai suficiente credite");
            else
            {
                credite -= miza;
                DoubleDown();
            }
        }

        //reseteaza jocul
        private void ReseteazaJoc()
        {
            numericUpDown1.Maximum = credite;
            miza = (int)numericUpDown1.Value;
            EsteInsurance = false;
            carti = new int[53];
            numecarti = new string[53];
            credite -= miza;
            labelcredite.Text = "Credite: " + Convert.ToString(credite);
            CartiTrase = CartiDealer = 0;
            ContineAs = false; ContineAsDealer = false;
            cnt = 0;
            labeltest.Text = ""; labeldealer.Text = "";
            GenerareCarti();
            ///labeltest.Text = numecarti[51];
            Hit();
            Hit();
            HitDealer();
            if (CartiTrase == 21)
            {
                MessageBox.Show("Blackjack!");
                credite += (3 * miza) / 2;
                norocos.Play();
                JocTerminat();
            }

            //verifica daca dealerul are as in mana
            if (CartiDealer == 11)
                if (MessageBox.Show("Dealerul a tras un as, doresti sa te asiguri?", "Insurance", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    EsteInsurance = true;
                    credite -= (int)miza / 2;
                    insurance.Text = labeldealer.Text;
                    labeldealer.Visible = false;
                    labelscordealer.Visible = false;
                    HitDealer();
                    if (CartiDealer == 21)
                    {
                        MessageBox.Show("Dealerul a avut blackjack!");
                        credite += miza + (int)miza / 2;
                        labeldealer.Visible = true;
                        labelscordealer.Visible = true;
                        JocTerminat();
                    }
                    else MessageBox.Show("Dealerul nu are blackjack!");

                }
                
        }

        //reseteaza jocul
        private void buttonrestart_Click(object sender, EventArgs e)
        {
            buttonhit.Visible = true;
            buttonstand.Visible = true;
            buttondoubledown.Visible = true;
            buttonsurrender.Visible = true;
            buttonrestart.Enabled = false;
            buttondoubledown.Enabled = true;
            buttonrestart.Text = "Alt joc";
            ReseteazaJoc();
        }


        //daca apesi pe textul de "credite" 
        private void label1_Click(object sender, EventArgs e)
        {
            if(credite<20)
            {
                if (credite == 1) MessageBox.Show("Ai 1 credit");
                else MessageBox.Show("Ai " + credite + " credite");
            }    
            else MessageBox.Show("Ai " + credite + " de credite");
        }

        //devine int
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            miza = (int)numericUpDown1.Value;
        }

        //surrender. Cand jucatorul apasa acest buton, jocul se incheie si jucatorul primeste jumatate din miza.
        private void buttonsurrender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai renuntat");
            credite += (int)(miza / 2);
            labelcredite.Text = "Credite: " + Convert.ToString(credite);
            JocTerminat();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //butonul de hit
        private void button1_Click(object sender, EventArgs e)
        {
            Hit();
            buttondoubledown.Enabled = false;
            VerificaPierdere();
           
        }
        //dispar butoanele mai putin cel de start
        private void JocTerminat()
        {
            buttonrestart.Enabled = true;
            buttonhit.Visible = false;
            buttonstand.Visible = false;
            buttondoubledown.Visible = false;
            buttonsurrender.Visible = false;
        }
        //verific daca am pierdut 
        private void VerificaPierdere()
        {
            if (CartiTrase > 21)
            {
                MessageBox.Show("Ai pierdut");
                JocTerminat();
                if (credite <= 10)
                {
                    MessageBox.Show("Ai ramas fara credite. Jocul se va inchide.");
                    Application.Exit();
                }
                labelcredite.Text = "Credite: " + Convert.ToString(credite);
            }
        }

        //Jucatorul trage o carte
        private void Hit()
        {
            
            Random r = new Random();
            Gasit = false;
            while(Gasit==false)
            {
                int x = r.Next(0, 51);
                if(carti[x]==0)
                {
                    carti[x] = 1;
                    labeltest.Text += numecarti[x] + "\n";
                    if (x % 13 == 0 && CartiTrase < 11)
                    {
                        CartiTrase += 11;
                        ContineAs = true; 
                    }
                    else if (x % 13 + 1 > 10)
                        CartiTrase += 10;
                    else
                        CartiTrase += x % 13 + 1;
                    Gasit = true;
                }
            }
            if (ContineAs == true && CartiTrase>21)
            {
                CartiTrase -= 10;
                ContineAs = false;
            }
            labelscor.Text = Convert.ToString(CartiTrase);
        }

        //Dealerul trage o carte
        private void HitDealer()
        {
            Random r = new Random();
            Gasit = false;
            while(Gasit==false)
            {
                int x = r.Next(0, 51);
                if(carti[x]==0)
                {
                    carti[x] = 1;
                    labeldealer.Text += numecarti[x]+ "\n";
                    if (x % 13 == 0 && CartiDealer < 11)
                    {
                        CartiDealer += 11;
                        ContineAsDealer = true;
                    }
                    else if (x % 13 + 1 > 10)
                        CartiDealer += 10;
                    else
                        CartiDealer += x % 13 + 1;
                    Gasit = true;
                }
            }
            if(ContineAsDealer==true && CartiDealer>21)
            {
                CartiTrase -= 10;
                ContineAsDealer= false;
            }
            labelscordealer.Text = Convert.ToString(CartiDealer);
            
        }
    }
}
