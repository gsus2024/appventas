using System.ComponentModel.DataAnnotations;

namespace appventas.Models
{
    public class Familia
    {
        [Key]
        public int Id { get; set;}
        public string Nombre { get; set; }

    }
}