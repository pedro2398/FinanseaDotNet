using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanseaAPI.Model
{ 
    [Table("BANK_ACCOUNT")]
    public class BankAccount
    {
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("ID_BANK_ACCOUNT")]
        public long id { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("NUMBER_BANCK_ACCOUNT")]
        public string accountNumber { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("AGENCY_BANCK_ACCOUNT")]
        public string agency { get; set; }
        [Required(ErrorMessage = "the field cannot be empty!")]
        [Column("PWD_BANCK_ACCOUNT")]
        public string password { get; set; }
    }
}