using System;
using System.ComponentModel.DataAnnotations;

namespace CodeTestRjnm.Models
{
    public class Account
    {

        [Key]
        public Guid id { get; set; }
        [Required]
        public string accountNumber { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public double balance { get; set; }
        [Required]
        public string currency { get; set; }

    }
}
