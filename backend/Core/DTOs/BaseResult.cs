namespace Core.DTOs
{
    public abstract class BaseResult
    {
        public bool IsSuccessfull { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
