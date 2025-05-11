using System.Collections.Generic;
using System.Xml.Serialization;

public class Bank
{
    public string Name { get; set; }
    public decimal Commission { get; set; }

    [XmlArray("Cards")]
    [XmlArrayItem("Card")]
    public List<Card> Cards { get; set; } = new List<Card>();
}

public class Card
{
    public string CardNumber { get; set; }
    public string ExpiryDate { get; set; }
    public string CVV { get; set; }
    public string PIN { get; set; }
    public decimal Balance { get; set; }
    public string BankName { get; set; } 
}