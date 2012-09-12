using Machine.Specifications;
using app.web.app.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(ViewTheMainDepartmentsInTheStore))]
  public class ViewTheMainDepartmentsInTheStoreSpecs
  {
    public abstract class concern : Observes<IImplementAFeature,
                                      ViewTheMainDepartmentsInTheStore>
    {
    }

    public class when_run : concern
    {
      Establish c = () =>
      {
        request = fake.an<IEncapsulateRequestDetails>();
      };

      Because b = () =>
        sut.process(request);

      It should_get_The_Main_departments_in_the_Store = () =>
      {

      };

      static IEncapsulateRequestDetails request;
    }
  }
}