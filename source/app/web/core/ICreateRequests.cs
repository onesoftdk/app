using System.Web;

namespace app.web.core
{
  public interface ICreateRequests
  {
    IEncapsulateRequestDetails create_request_from(HttpContext http_context);
  }
}