using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eat_It_
{
    public class Item : PictureBox
    {

        public string _name { get; set; }
        public int _id { get; set; }
        public int _calories { get; set; }
        public int _carbs { get; set; }
        public int _protein { get; set; }
        public int _fat { get; set; }
        public int _spot { get; set; }

        public Item()
            : base()
        {

        }

        public void Inicjacja(string nam, int cal, int car, int pro, int fat)
        {
            _name = nam;
            _calories = cal;
            _carbs = car;
            _protein = pro;
            _fat = fat;
        }
    }
}