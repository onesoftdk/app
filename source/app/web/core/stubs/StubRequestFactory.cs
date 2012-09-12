using System.Web;

namespace app.web.core.stubs
{
  public class StubRequestFactory : ICreateRequests
  {
    public IEncapsulateRequestDetails create_request_from(HttpContext http_context)
    {
      return new StubRequest();
    }

    class StubRequest : IEncapsulateRequestDetails
    {
    }
  }
}