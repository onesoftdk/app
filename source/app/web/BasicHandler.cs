using System.Web;

namespace app.web
{
  public class BasicHandler : IHttpHandler
  {
    IProcessWebRequests front_controller;

    public BasicHandler(IProcessWebRequests front_controller)
    {
      this.front_controller = front_controller;
    }

    public void ProcessRequest(HttpContext context)
    {
      front_controller.process(context);
    }

    public bool IsReusable
    {
      get { throw new System.NotImplementedException(); }
    }
  }
}