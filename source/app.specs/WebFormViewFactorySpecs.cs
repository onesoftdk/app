using Machine.Specifications;
using app.web.core.aspnet;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(WebFormViewFactory))]
  public class WebFormViewFactorySpecs
  {
    public abstract class concern : Observes<IFindWebFormViews,
                                      WebFormViewFactory>
    {
    }

    public class when_creating_a_view_for_data : concern
    {
      Establish c = () =>
      {
        web_form_path_registry = depends.on<IFindPathsToWebForms>();
        item = new AnItem();
      };

      Because b = () =>
        sut.create_view_to_display(item);

      It should_find_the_path_to_the_view_that_can_display_the_information = () =>
        web_form_path_registry.received(x => x.get_the_path_to_view_for<AnItem>());

      static IFindPathsToWebForms web_form_path_registry;
      static AnItem item;
    }

    public class AnItem
    {
    }
  }
}