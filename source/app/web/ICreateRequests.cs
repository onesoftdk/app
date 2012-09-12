using System.Web;

namespace app.web
{
  public interface ICreateRequests
  {
    object create_request_from(HttpContext http_context);
  }
}