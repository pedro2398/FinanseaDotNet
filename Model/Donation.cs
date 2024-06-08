using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanseaAPI.Model 
{
    [Table("DONATION")]
    public class Donation
    {     
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ID_DONATION")]
        public long id { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("AMOUNTH_DONATION")]
        public double amounth { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("DATE_DONATION")]
        public DateTime date { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("PROJECT_DONATION")]
        public long project { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("FINANCIER")]
        public long financier { get; set; }
    }
 }