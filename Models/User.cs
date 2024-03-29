using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models{
    public class User
    {
        [Key]
        public int userId {get; set;}
        [Required]
        [MinLength(2, ErrorMessage="Your Name Must contain at least 2 Characters!")]
        public string firstName {get; set;}
        [Required]
        [MinLength(2, ErrorMessage="Your First Name Must contain at least 2 Characters!")]
        public string lastName {get; set;}
        [Required]
        [EmailAddress]
        public string email {get; set;}
        [Required]
        [MinLength(2)]
        public string password {get; set;}
        public List<Transactions> CreatedTransaction {get;set;}

        [NotMapped]
        [Compare("password", ErrorMessage="Passwords do not match!")]
        public string confirmPassword {get; set;}
        public DateTime createdAt {get; set;} = DateTime.Now;
        public DateTime updatedAt{get; set;} = DateTime.Now;
    }
}