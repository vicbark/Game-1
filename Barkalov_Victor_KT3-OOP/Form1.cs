using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barkalov_Victor_KT3_OOP
{
    public partial class BV_Form1 : Form
    {
        int player1=0; // peremennie dlja obshego scheta
        int player2=0;

        public BV_Form1()
        {
            InitializeComponent();
        }

        private void BV_lbl1_Click(object sender, EventArgs e)
        {

        }

        private void BV_Pic1_Click(object sender, EventArgs e)
        {

        }

        private void BV_Start_Click(object sender, EventArgs e)
        {
            BV_Summa1.Text = "";// ochistij polja
            BV_Summa2.Text = "";
            BV_Kosti11.Text = "";
            BV_Kosti12.Text = "";
            BV_Kosti21.Text = "";
            BV_Kosti22.Text = "";
            BV_Rezuljtat.Text = "";

            //pri zapuske posle nazatija otkrivaem jacheiki i nadpisi
            BV_lbl1.Visible = true;
            BV_lbl2.Visible = true;
            BV_lbl3.Visible = true;
            BV_lbl4.Visible = true;
            BV_Kosti11.Visible = true;
            BV_Kosti12.Visible = true;
            BV_Kosti21.Visible = true;
            BV_Kosti22.Visible = true;
            BV_Summa1.Visible = true;
            BV_Summa2.Visible = true;

            // prjachem ostolnoe posle nazhatija knopki
            BV_Korona1.Visible= false;
            BV_Korona2.Visible= false;
            BV_Btn1.Enabled = true;
            BV_Btn2.Enabled = false;
            BV_Start.Enabled = false;
            BV_Rezuljtat.Visible = false;
            BV_lblREZ.Visible= false;
            BV_Btn1.Visible = true; //otkrivaetsa knopka dlja 1-ogo igroka
            BV_Btn2.Visible = true;

            BV_Btn1.Focus();
            BV_Btn2.Focus();

        }

        private void BV_Btn1_Click(object sender, EventArgs e)
        {
            int k1; // 1. sluchajnoe chislo
            int k2; // 2. sluchajnoe chislo

            Random random = new Random();
            k1 = random.Next(1, 7); // chislo ot 1 do 6
            k2 = random.Next(1, 7);
            BV_Kosti11.Text = Convert.ToString(k1); // vivesti poluchennoe chislo
            BV_Kosti12.Text = Convert.ToString(k2);

            float sum1 = k1 + k2; // summa dvuh sluchainih chisel
            BV_Summa1.Text = sum1.ToString(); //vivodim etu summu v jacheike


            BV_Btn1.Enabled = false; //neaktivna knopka 1-ogo igroka
            BV_Btn2.Enabled = true; // aktiviziruetsa knopka 2-ogo igroka

        
        }

        private void BV_Btn2_Click(object sender, EventArgs e)
        {
            int k3; // 3. sluchajnoe chislo
            int k4; // 4. sluchajnoe chislo

            Random random = new Random(); 
            k3 = random.Next(1, 7); // sluchainoe chislo ot 1 do 6
            k4 = random.Next(1, 7);
            BV_Kosti21.Text = Convert.ToString(k3); // zapisivaem poluchenoe chislo v jacheiku
            BV_Kosti22.Text = Convert.ToString(k4);

            float sum2 = k3 + k4; // summa dvuh sluhain]h chisel
            BV_Summa2.Text = sum2.ToString(); //vivodim summu v jacheike

            BV_Btn1.Enabled = false; //otkljuchaem knopki
            BV_Btn2.Enabled = false;
            
            BV_Rezuljtat.Visible = true; // otkrivaem jacheiki 
            BV_lblREZ.Visible = true;
            BV_Start.Enabled = true;

            // perevodim summu sluchainih chisel v chislo, chtobi daljshe s rabotatj s ciframi
            float x1 = Int32.Parse(BV_Summa1.Text); 
            float x2 = Int32.Parse(BV_Summa2.Text);
            if
                (x1 > x2) // esli summa sluch. chisel 1-ogo igra boljshe 2-ogo
            {
                player1++; // scetchik vseh pobed 1-ogo igrika
                BV_Rezuljtat.Text = "В этой игре победил \n Первый игрок.\n Oбщий счет: " + Convert.ToString(player1) + " : " + Convert.ToString(player2);
                
                BV_Korona1.Visible= true; // otkrivaem kartinku - koronu dlja 1-ogo igroka
            }
            else if
                (x1 < x2)
            {
                player2++; // scetchik vseh pobed 2 - ogo igrika
                BV_Rezuljtat.Text = "В этой игре победил \n Второй игрок.\n Oбщий счет: " + Convert.ToString(player1) + " : " + Convert.ToString(player2);

                BV_Korona2.Visible = true; // otkrivaem kartinku - koronu dlja 2-ogo igroka
            }
            else
            {
                BV_Rezuljtat.Text = "Ничья.\n Oбщий счет: " + Convert.ToString(player1) + " : " + Convert.ToString(player2);
            }


        }

        
    }
}
