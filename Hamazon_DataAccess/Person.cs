using System.ComponentModel.DataAnnotations;

namespace Hamazon_DataAccess
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Cash { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Times in Installments")]
        public sbyte TimesInstallments { get; set; }

        [Required]
        [Display(Name = "Paid Installments")]
        public sbyte PaidInstallments { get; set; }

        public bool Settled => TimesInstallments == PaidInstallments;

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
