namespace AutoFac.ConsoleApp.Response
{
    public class BaseResponse<T> where T : class
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}
