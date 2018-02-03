namespace Lab5.Models
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public object Body { get; set; }
    }
}