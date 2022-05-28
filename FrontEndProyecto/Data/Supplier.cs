using System.ComponentModel.DataAnnotations;

namespace FrontEndProyecto.Data
{
    public class Supplier
    {
        [Key]
        public int idSupplier { get; set; }
        public string name { get; set; }
        public int nit { get; set; }
        public string service { get; set; }

    }
}
