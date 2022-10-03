namespace AdvanWeb.Models
{
    public class TransferModel
    {
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public decimal Amount { get; set; }
        public string TransactionPin { get; set; }
    }

    public class AccoutBalaceModel
    {
        public string AccountNumber { get; set; }

    }
}
