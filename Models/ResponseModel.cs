using System.Collections.Generic;

namespace AdvanWeb.Models
{
    public class ResponseModel
    {
        public string Data { get; set; }
        public bool isSuccessful { get; set; }
        public string message { get; set; }
    }

    public class ResponseData
    {
        public string Data { get; set; }
        public bool Succeeded { get; set; }
        public string message { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal CurrentAccountBalance { get; set; }
    }
    public class ViewModelData
    {

       public List<ResponseData> List  { get; set; }
    }
    public class ResponseData1
    {
        public string Data { get; set; }
        public bool Succeeded { get; set; }
        public string message { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentAccountBalance { get; set; }

    }
}
