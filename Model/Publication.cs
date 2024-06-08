using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanseaAPI.Model
{
    [Table("PUBLICATION")]
    public class Publication
    {
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ID_PUB")]
        public long id { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("DESC_PUB")]
        public string description { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("DT_PUB")]
        public DateTime date { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ONG")]
        public long ong { get; set; }
    }
}