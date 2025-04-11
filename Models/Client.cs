using System.ComponentModel.DataAnnotations;

namespace BP_Proyecto.Models
{
    public class Client
    {
        [Key]
        [StringLength(20, ErrorMessage = "La cédula no puede exceder 20 caracteres")]
        [RegularExpression(@"^[0-9\-]+$", ErrorMessage = "La cédula solo puede contener números y guiones")]
        public required string InsureId { get; set; }

        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public required string Name { get; set; }
        [StringLength(50, ErrorMessage = "El primer apellido no puede exceder 50 caracteres")]
        public required string FirstSurname { get; set; }
        [StringLength(50, ErrorMessage = "El segundo apellido no puede exceder 50 caracteres")]
        public required string SecondSurname { get; set; }
        [StringLength(50, ErrorMessage = "El tipo de persona no puede exceder 50 caracteres")]
        public required string PersonType { get; set; }
        [DataType(DataType.Date)]
        public required DateTime Birthdate { get; set; }

        public ICollection<Policy>? Policies { get; set; } = new List<Policy>();
    }
}

