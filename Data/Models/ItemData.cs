using System;

namespace PaymentApp.Models
{
    public class ItemData
    {
        public int Id { get; set;}
        public string cardOwnerName {get; set;}
        public string cardNumber {get; set;}
        public string expirationDate {get; set;}
        public string securityCode {get; set;}
    }
}