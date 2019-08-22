using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models{
    public class Transactions{
        [Key]
        public int transactionId {get; set;}
        public decimal amount {get; set;}
        public int userId {get; set;}
        public User creator {get; set;}
        public DateTime createdAt {get; set;} = DateTime.Now;
        public DateTime updatedAt{get; set;} = DateTime.Now;
    }
}