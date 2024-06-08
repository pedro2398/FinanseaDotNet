using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanseaAPI.Model
{
    [Table("FINANCIER")]
    public class Financier
    {
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ID_FINANCIER")]
        public long id { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("DOC_FINANCIER")]
        public string document { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("NM_FINANCIER")]
        public string name { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("EMAIL_FINANCIER")]
        public string email { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("PWD_FINANCIER")]
        public string password { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ADDRESS_FINANCIER")]
        public string address { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("PHONE_FINANCIER")]
        public string telephone { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("BANK_ACCOUNT")]
        public long bankAccount { get; set; }
     }
}