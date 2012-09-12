using System.Web;

namespace app.web
{
  public interface ICreateRequests
  {
    IEncapsulateRequestDetails create_request_from(HttpContext http_context);
  }
}