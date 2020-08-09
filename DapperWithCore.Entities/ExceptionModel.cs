namespace DapperWithCore.Entities
{
    public class ExceptionModel
    {
        public string Path { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
    }
}
