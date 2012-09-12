using System.Web;

namespace app.web.core.aspnet
{
  public class WebFormViewFactory : IFindWebFormViews
  {
    public IHttpHandler create_view_to_display<TheData>(TheData info)
    {
      throw new System.NotImplementedException();
    }
  }
}