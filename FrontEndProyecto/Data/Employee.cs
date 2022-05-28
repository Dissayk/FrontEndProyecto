using System.ComponentModel.DataAnnotations;

namespace FrontEndProyecto.Data
{
    public class Employee
    {
        [Key]
        public int idEmployee { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string profession { get; set; }
        public string position { get; set; }
        public int salary { get; set; }

    }
}
