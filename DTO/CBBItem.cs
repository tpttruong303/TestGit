using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QLQuanNet
{
    public class CBBItem
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            if(Value == 1)
            {
                Text = "Khach Hang";
            }
            else if(Value == 2)
            {
                Text = "Nhan Vien";

            }
         
            return Text;
        }

    }
}
