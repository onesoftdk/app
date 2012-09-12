using Machine.Specifications;
using app.web;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(RequestCommand))]
  public class RequestCommandSpecs
  {
    public abstract class concern : Observes<IProcessARequest,
                                      RequestCommand>
    {
    }

    public class when_determining_if_it_can_process_a_request : concern
    {
      Establish c = () =>
      {
        the_request = fake.an<IEncapsulateRequestDetails>();
      };

      Because b = () =>
        sut.can_process(the_request);

      static IEncapsulateRequestDetails the_request;
    }
  }
}