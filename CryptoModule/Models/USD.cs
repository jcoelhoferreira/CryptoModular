using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoModule.Models
{
    public class USD
    {
        [Display(Name = "Price USD")]
        [DisplayFormat(DataFormatString = "${0:N2}")]
        public double Price { get; set; }
        [Display(Name = "Volume(24h)")]
        [DisplayFormat(DataFormatString = "${0:N2}")]
        public double Volume_24h { get; set; }
        public double Volume_change_24h { get; set; }
        public double Percent_change_1h { get; set; }
        [Display(Name = "24h %")]
        [DisplayFormat(DataFormatString = "{0:N2}%")]
        public double Percent_change_24h { get; set; }
        [Display(Name = "7d %")]
        [DisplayFormat(DataFormatString = "{0:N2}%")]
        public double Percent_change_7d { get; set; }
        public double Percent_change_30d { get; set; }
        public double Percent_change_60d { get; set; }
        public double Percent_change_90d { get; set; }
        [Display(Name = "Market Cap")]
        [DisplayFormat(DataFormatString = "${0:N2}")]
        public double Market_cap { get; set; }
        public double Market_cap_dominance { get; set; }
        public double Fully_diluted_market_cap { get; set; }
        public DateTime Last_updated { get; set; }
    }
}
