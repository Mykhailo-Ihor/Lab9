using System;

public class Receipt
{
    public string CardNumber { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal PreviousBalance { get; set; }
    public decimal TransactionAmount { get; set; }
    public decimal CurrentBalance { get; set; }
    public string TransactionType { get; set; }
}