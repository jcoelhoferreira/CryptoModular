using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoModule.Models
{
    public class Status
    {
        public DateTime Timestamp { get; set; }
        public int Error_code { get; set; }
        public object Error_message { get; set; }
        public int Elapsed { get; set; }
        public int Credit_count { get; set; }
        public object Notice { get; set; }
        public int Total_count { get; set; }
    }
}
