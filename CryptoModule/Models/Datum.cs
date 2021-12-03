using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoModule.Models
{
    public class Datum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int Num_market_pairs { get; set; }
        public DateTime Date_added { get; set; }
        public List<string> Tags { get; set; }
        public long? Max_supply { get; set; }
        public double Circulating_supply { get; set; }
        public double Total_supply { get; set; }
        [Display(Name = "Rank")]
        public int Cmc_rank { get; set; }
        public DateTime Last_updated { get; set; }
        public Quote Quote { get; set; }
    }
}
