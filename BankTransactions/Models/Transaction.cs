using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This field is requied.")]
        [MaxLength(12, ErrorMessage = "Maximm 12 characters only.")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is requied.")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Namme")]
        [Required(ErrorMessage = "This field is requied.")]
        public string BankNamme { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is requied.")]
        [MaxLength(11, ErrorMessage = "Maximm 12 characters only.")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is requied.")]
        public int Amount { get; set; }
        public DateTime Date { get; set; }

    }
}
