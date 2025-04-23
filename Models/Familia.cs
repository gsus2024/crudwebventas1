using System.ComponentModel.DataAnnotations;

namespace crudwebventas1.Models
{
    public class Familia
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}