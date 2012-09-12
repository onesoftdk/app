using System.Web;
using Machine.Specifications;
using app.specs.utility;
using app.web.core;
using app.web.core.aspnet;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;

namespace app.specs
{
  [Subject(typeof(WebFormDisplayEngine))]
  public class WebFormDisplayEngineSpecs
  {
    public abstract class concern : Observes<IDisplayInformation,
                                      WebFormDisplayEngine>
    {
    }

    public class when_displaying_information : concern
    {
      Establish c = () =>
      {
        the_info = new Person();
        web_form_view_factory = depends.on<IFindWebFormViews>();
        view = fake.an<IHttpHandler>();
        the_current_context = ObjectFactory.web.create_http_context();
        depends.on<GetTheCurrentContext_Behaviour>(() => the_current_context);

        web_form_view_factory.setup(x => x.create_view_to_display(the_info)).Return(view);
      };

      Because b = () =>
        sut.display(the_info);

      It should_get_the_View_That_can_display_the_report = () =>
        web_form_view_factory.received(x => x.create_view_to_display(the_info));

      It should_tell_the_view_to_render = () =>
        view.received(x => x.ProcessRequest(the_current_context));
        

      static Person the_info;
      static IFindWebFormViews web_form_view_factory;
      static IHttpHandler view;
      static HttpContext the_current_context;
    }

    public class Person
    {
    }
  }
}