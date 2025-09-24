using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Phone
    {
        public Phone(string[] phone)
        {
            make = phone[0];
            model = phone[1];
            display = phone[2];
            storage = phone[3];
            price = decimal.Parse(phone[4]);
        }
        
        public string make { get; set; }
        public string model { get; set; }
        public string display { get; set; }
        public string storage { get; set; }
        public decimal price { get; set; }
    }
}
