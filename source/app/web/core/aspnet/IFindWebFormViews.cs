using System.Web;

namespace app.web.core.aspnet
{
  public interface IFindWebFormViews
  {
    IHttpHandler create_view_to_display<TheData>(TheData info);
  }
}