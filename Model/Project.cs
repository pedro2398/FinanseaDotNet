using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanseaAPI.Model
{
    [Table("PROJECT")]
    public class Project
    {   
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ID_PROJECT")]
        public long id { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("NM_PROJECT")]
        public string name { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ADDRESS_PROJECT")]
        public string address { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("DESC_PROJECT")]
        public string description { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("GOAL_PROJECT")]
        public double goal { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("STATUS_PROJECT")]
        public string status { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("PROOF_PROJECT")]
        public string proofOfTheProject { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ACCUMULATED_PROJECT")]
        public double accumulated { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ONG")]
        public long ong { get; set; }
        
    }
}