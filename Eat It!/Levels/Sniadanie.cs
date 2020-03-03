using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eat_It_
{
    public partial class EatIt : Form
    {
        //System.Media.SoundPlayer loop = new System.Media.SoundPlayer(@"C:\Users\danio\Desktop\JPWP PROJEKT\Eat It!\Eat It!\Resources\Music\Theme.wav");

        WorldObject[] worldObjects = new WorldObject[10];
        Item[] worldItems = new Item[20];
        int[] zajete = new int[20];
        int[] spot = new int[10];

        bool goLeft = false;
        bool goRight = false;
        bool jump = false;
        bool space = false;

        int jumpSpeed = 8;
        int force = 0;
        double sniadanie_cal;
        double sniadanie_pro;
        double sniadanie_fat;
        double sniadanie_car;

        int x;
        int y;

        public EatIt()
        {
            InitializeComponent();
            //loop.PlayLooping();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EatIt_FormClosed);
        }

        private void EatIt_FormClosed(object sender, FormClosedEventArgs e)
        {
     
        }
    
        private void SpotLocation (int spot)
        {
            switch (spot)
            {
                case 0:
                    x = 727;
                    y = 606;
                    break;
                case 1:
                    x = 907;
                    y = 606;
                    break;
                case 2:
                    x = 752;
                    y = 461;
                    break;
                case 3:
                    x = 907;
                    y = 461;
                    break;
                case 4:
                    x = 426;
                    y = 383;
                    break;
                case 5:
                    x = 148;
                    y = 299;
                    break;
                case 6:
                    x = 28;
                    y = 299;
                    break;
                case 7:
                    x = 435;
                    y = 185;
                    break;
                case 8:
                    x = 657;
                    y = 69;
                    break;
                case 9:
                    x = 793;
                    y = 69;
                    break;
            }
        }

        public int SpotNull()
        {
            for (int i = 0; i < 10; i++)
            {
                if (spot[i] == 0)
                {
                    return i;
                }
            }
            return -1;
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            worldObjects[0] = Ground;
            worldObjects[2] = Block1;
            worldObjects[3] = Block2;
            worldObjects[4] = Block3;
            worldObjects[5] = Block4;
            worldObjects[6] = Block5;
            worldItems[0] = Banana;
            worldItems[1] = Avocado;
            worldItems[2] = Apple;
            worldItems[3] = Bacon;
            worldItems[4] = B_Egg;
            worldItems[5] = Bread;
            worldItems[6] = Broccoli;
            worldItems[7] = Cake;
            worldItems[8] = Candy;
            worldItems[9] = Cheese;
            worldItems[10] = Chicken;
            worldItems[11] = Fish;
            worldItems[12] = F_Egg;
            worldItems[13] = Ice_Cream;
            worldItems[14] = OliveOil;
            worldItems[15] = Orange;
            worldItems[16] = Peas;
            worldItems[17] = Pizza;
            worldItems[18] = Rice;
            worldItems[19] = Tomato;
            for (int i = 0; i < 20; i++)
            {
                zajete[i] = 0;
            }
            for (int i = 0; i < 10; i++)
            {
                spot[i] = 0;
            }
            Gracz._wiek = Formularz.wiek;
            Gracz._waga = Formularz.waga;
            Gracz._plec = Formularz.plec;
            Gracz._akt = Formularz.akt;
            Gracz._wzrost = Formularz.wzrost;
            Console.WriteLine(Gracz._wzrost);
            Gracz.Zapotrzebowanie();
            sniadanie_cal = 0.25 * Gracz.p_zapotrzebowanie;
            sniadanie_pro = 0.15 * sniadanie_cal / 4;
            sniadanie_car = 0.55 * sniadanie_cal / 4;
            sniadanie_fat = 0.3 * sniadanie_cal / 9;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.Tab)
            {
                this.Close();
                (new EatIt()).Show();
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (!space && !jump )
                {   
                    Gracz.Top -= jumpSpeed;
                    force = 20;
                    jump = true;
                    space = true;
                }
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Cal.Text = "Calories : " + Gracz.p_cal +" ( Zapotrzebowanie : "+Convert.ToInt32(sniadanie_cal)+")";
            if (Gracz.p_cal > sniadanie_cal - 0.2 * sniadanie_cal && Gracz.p_cal < sniadanie_cal + 0.2 * sniadanie_cal)
                label_Cal.ForeColor = Color.Green;
            else if (Gracz.p_cal < sniadanie_cal - 0.2 * sniadanie_cal)
                label_Cal.ForeColor = Color.Gray;
            else
                label_Cal.ForeColor = Color.Red;

            label_Pro.Text = "Proteins : " + Gracz.p_pro + " ( Zapotrzebowanie : " + Convert.ToInt32(sniadanie_pro) + ")";
            if (Gracz.p_pro > sniadanie_pro - 0.2 * sniadanie_pro && Gracz.p_pro < sniadanie_pro + 0.2 * sniadanie_pro)
                label_Pro.ForeColor = Color.Green;
            else if (Gracz.p_pro < sniadanie_pro - 0.2 * sniadanie_pro)
                label_Pro.ForeColor = Color.Gray;
            else
                label_Pro.ForeColor = Color.Red;

            label_Fat.Text = "Fats : " + Gracz.p_fat + " ( Zapotrzebowanie : " + Convert.ToInt32(sniadanie_fat) + ")";
            if (Gracz.p_fat > sniadanie_fat - 0.2 * sniadanie_fat && Gracz.p_fat < sniadanie_fat + 0.2 * sniadanie_fat)
                label_Fat.ForeColor = Color.Green;
            else if (Gracz.p_fat < sniadanie_fat - 0.2 * sniadanie_fat)
                label_Fat.ForeColor = Color.Gray;
            else
                label_Fat.ForeColor = Color.Red;

            label_Car.Text = "Carbohydrates : " + Gracz.p_car + " ( Zapotrzebowanie : " + Convert.ToInt32(sniadanie_car) + ")";
            if (Gracz.p_car > sniadanie_car - 0.2 * sniadanie_car && Gracz.p_car < sniadanie_car + 0.2 * sniadanie_car)
                label_Car.ForeColor = Color.Green;
            else if (Gracz.p_car < sniadanie_car - 0.2 * sniadanie_car)
                label_Car.ForeColor = Color.Gray;
            else
                label_Car.ForeColor = Color.Red;

            if (goLeft && Gracz.Location.X >= 3 && !Funkcje.Collision_Right(Gracz, worldObjects))
            {
                Gracz.Left -= 5;
            }
            if (goRight && Gracz.Right <= this.Width - 3 && !Funkcje.Collision_Left(Gracz, worldObjects))
            {
                Gracz.Left += 5;
            }
            if (force > 0)
            {
                if (Funkcje.Collision_Bottom(Gracz, worldObjects))
                {
                    force = 0;
                }
                else
                {
                    force--;
                    Gracz.Top -= jumpSpeed;
                }
            }
            else
            {
                jump = false;
            }

            if (!jump && !Funkcje.Collision_Top(Gracz, worldObjects))
            {
                Gracz.Top += jumpSpeed;
            }

            if (Funkcje.Collision_Top(Gracz, worldObjects))
            {
                space = false;
            }

            if (Gracz.Bounds.IntersectsWith(Door.Bounds))
            {
                timerGame.Stop();
                timer_NewItem.Stop();
                if (label_Cal.ForeColor == Color.Green && label_Car.ForeColor == Color.Green && label_Fat.ForeColor == Color.Green && label_Pro.ForeColor == Color.Green)
                {
                    MessageBox.Show("Udało się! Świetny posiłek! Czas na Obiad.");
                    this.Close();
                    (new Obiad()).Show();
                }
                else
                {
                    MessageBox.Show("To nie jest odpowiedni posiłek!\n Spójrz na jaki kolor zabarwione są statystyki w lewym górnym rogu.\n Szary - za mało, Czarwony - za dużo, Zielony - w sam raz. \nSpróbuj ponownie.");
                    this.Close();
                    (new EatIt()).Show();

                }

            }

            foreach (Item xx in worldItems)
            if (xx !=null)
            {
                if (Gracz.Bounds.IntersectsWith(xx.Bounds))
                {
                    Gracz.p_cal += xx._calories;
                    Gracz.p_pro += xx._protein;
                    Gracz.p_fat += xx._fat;
                    Gracz.p_car += xx._carbs;
                    xx.Location = new System.Drawing.Point(-1, -1);
                    spot[xx._spot] = 0;
                    zajete[xx._id] = 0;
                    xx.Hide();
                }
            }
        }

        private void label_Cal_Click(object sender, EventArgs e)
        {

        }

        private void label_Car_Click(object sender, EventArgs e)
        {

        }

        private void Door_Click_1(object sender, EventArgs e)
        {

        }

        private void timer_NewItem_Tick(object sender, EventArgs e)
        {
            int temp = SpotNull();
            Console.WriteLine(temp);
            if (temp != -1)
            {
                int rand = Funkcje.RandomNumber(0, 19);
                while (zajete[rand]!=0)
                {
                    rand = Funkcje.RandomNumber(0, 19);
                }
                SpotLocation(temp);
                worldItems[temp].Size = new System.Drawing.Size(32, 32);
                worldItems[rand].Location = new System.Drawing.Point(x, y);
                worldItems[rand]._spot = temp;
                worldItems[rand]._id = rand;
                worldItems[rand].Show();
                zajete[rand] = 1;
                spot[temp] = 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
