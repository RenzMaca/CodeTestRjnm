using System;
using System.ComponentModel.DataAnnotations;

namespace CodeTestRjnm.Models
{
    public class Payment
    {
        [Key]
        public Guid id { get;  set; }

        [Required]
        [MaxLength(16, ErrorMessage = "Max digits for Account Number is 16")]
        public string accountNumber { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public double amount { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string status { get; set; }
        public string remarks { get; set; }

        
    }
}
