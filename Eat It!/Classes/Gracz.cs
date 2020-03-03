using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eat_It_
{
    public class Gracz : PictureBox
    {
        public int _max_hp { get; set; }
        public int _current_hp { get; set; }

        public int _wiek { get; set; }
        public int _wzrost { get; set; }
        public int _waga { get; set; }
        public string _plec { get; set; }
        public string _akt { get; set; }

        public int p_cal { get; set; }
        public int p_pro { get; set; }
        public int p_fat { get; set; }
        public int p_car { get; set; }

        public double p_zapotrzebowanie { get; set; }

        public Gracz()
            : base()
        {
         
        }

        public void Zapotrzebowanie()
        {
            p_zapotrzebowanie = 9.99*_waga + 6.25*_wzrost - 4.92*_wiek;
            if (_plec == "Kobieta")
                p_zapotrzebowanie -= 161;
            else
                p_zapotrzebowanie += 5;
            switch (_akt)
            {
                case "Żadna":
                    break;
                case "1-2 dni w tygodniu":
                    p_zapotrzebowanie += 300;
                    break;
                case "3-4 dni w tygodniu":
                    p_zapotrzebowanie += 500;
                    break;
                case "Codziennie/Prawie codziennie":
                    p_zapotrzebowanie += 700;
                    break;
            }
            Console.WriteLine(p_zapotrzebowanie);
        }
    }
}
