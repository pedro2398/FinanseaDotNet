using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanseaAPI.Model
{
    [Table("ONG")]
    public class Ong
    {
        [Required(ErrorMessage = "the field cannot be empty!")]        
        [Column("ID_ONG")] 
        public long id { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("DOC_ONG")]
        public string document{ get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("NM_ONG")]
        public string name { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("EMAIL_ONG")]
        public string email { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("PWD_ONG")]
        public string password { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ADDRESS_ONG")]
        public string address { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("PHONE_ONG")]
        public string telephone { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("BANK_ACCOUNT")]
        public long bankAccount { get; set; }
     }
}