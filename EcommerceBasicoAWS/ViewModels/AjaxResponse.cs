namespace EcommerceBasicoAWS.ViewModels
{
    public class AjaxResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public object? Data { get; set; }
    }
}
