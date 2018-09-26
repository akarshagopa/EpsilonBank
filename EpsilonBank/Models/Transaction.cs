using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpsilonBank.Models
{
    public class Transaction
    {
        [Display(Name = "Transaction ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string TransactionID
        { get; set; }

        [Display(Name = "Account ID")]
        public long AccNo  //fk
        { get; set; }

        [Display(Name = "Transaction Type")]
        public TransType TransType  //enum
        { get; set; }

        [Display(Name = "Transaction Amount")]
        public float TransAmount
        { get; set; }

        [Display(Name = "Updated Balance")]
        public float UpBalance
        { get; set; }

        [Display(Name = "Destination Account Number")]
        public long DAccNo
        { get; set; }

        [Display(Name = "Transaction Date")]
        public DateTime TransDate
        { get; set; }

        public Account Account { get; set; }
    }

    public enum TransType
    {
        WITHDRAWAL,
        DEPOSIT,
        FUNDTRANSFER
    }

}