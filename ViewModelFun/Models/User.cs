
namespace ViewModelFun.Models
{
    public class User
    {

    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Name {get;set;}
    }
}