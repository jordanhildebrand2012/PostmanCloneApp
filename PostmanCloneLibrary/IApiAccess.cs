
namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string apiUrl, bool formatOutput = true, HttpAction action = HttpAction.GET);
        bool IsValidApiUrl(string apiUrl);
    }
}