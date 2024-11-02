using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombres")]
        [Required]
        public string Nombres { get; set; }

        [Column("apellidos")]
        public string Apellidos { get; set; }

        [Column("fechanacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Column("direccion")]
        public string Direccion { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("telefono")]
        public string Telefono { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("fechacreacion")]
        public DateTime FechaCreacion { get; set; }

        [Column("fechamodificacion")]
        public DateTime? FechaModificacion { get; set; }
    }
}
