using System.ComponentModel.DataAnnotations;

namespace FrontEndProyecto.Data
{
    public class Product
    {
        [Key]
        public int idProduct { get; set; }
        public string name { get; set; }
        public int purchasePrice { get; set; }
        public int salePrice { get; set; }
        public string distributionChannel { get; set; }
    }
}
