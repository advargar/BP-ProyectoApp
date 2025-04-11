using System.ComponentModel.DataAnnotations;

namespace BP_Proyecto.Models
{
    public class Policy
    {
        

        [Key]
        [StringLength(20, ErrorMessage = "El número de póliza no puede exceder 20 caracteres")]
        public required string PolicyNumber { get; set; }

        [StringLength(20, ErrorMessage = "El tipo de póliza no puede exceder 20 caracteres")]
        public required string PolicyType { get; set; }

        public decimal CoverageAmount { get; set; }
        [DataType(DataType.Date)]
        public required DateTime ExpirationDate { get; set; }
        [DataType(DataType.Date)]
        public required DateTime IssueDate { get; set; }
        [StringLength(50, ErrorMessage = "La Cobertura no puede exceder 50 caracteres")]
        public required string Coverage { get; set; }
        [StringLength(50, ErrorMessage = "El estado de la poliza no puede exceder 50 caracteres")]
        public required string PolicyStatus { get; set; }
        public required decimal Premium { get; set; }
        [DataType(DataType.Date)]
        public required DateTime PolicyPeriod { get; set; }
        [DataType(DataType.Date)]
        public required DateTime InclusionDate { get; set; }
        [StringLength(50, ErrorMessage = "La Aseguradora no puede exceder 100 caracteres")]
        public required string InsuranceCompany { get; set; }


        [StringLength(20, ErrorMessage = "La cédula no puede exceder 20 caracteres")]
        [RegularExpression(@"^[0-9\-]+$", ErrorMessage = "La cédula solo puede contener números y guiones")]
        public required string ClientId { get; set; }
    }

    public class PolicyFiltroDto
    {
        public string? PolicyNumber { get; set; }
        public string? PolicyType { get; set; }
        public string? InsureId { get; set; }
        public string? Name { get; set; }
        public string? FirstSurname { get; set; }
        public string? SecondSurname { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}