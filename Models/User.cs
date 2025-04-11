using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Humanizer;
using LinqToDB.Mapping;
using static LinqToDB.Sql;

namespace BP_Proyecto.Models
{
    public class User
    {
        internal bool MantenerActivo;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int UserId { get; set; }

        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
        public required string Email { get; set; }
    }
}
