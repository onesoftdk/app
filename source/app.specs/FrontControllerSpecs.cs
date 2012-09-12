using Machine.Specifications;
using app.web;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(FrontController))]
  public class FrontControllerSpecs
  {
    public abstract class concern : Observes<IProcessWebRequests,
                                      FrontController>
    {
    }

    public class when_processing_a_new_request : concern
    {
      Establish c = () =>
      {
        command_registry = depends.on<IFindCommandsForRequests>();
        command_that_can_process = fake.an<IProcessARequest>();
        the_request = fake.an<IEncapsulateRequestDetails>();

        command_registry.setup(x => x.get_the_command_that_can_process_The_request(the_request)).Return(
          command_that_can_process);
      };

      Because b = () =>
        sut.process(the_request);

      It should_use_a_command_registry_to_find_the_command_that_Can_process_the_request = () =>
        command_registry.received(x => x.get_the_command_that_can_process_The_request(the_request));

      It should_process_the_request_using_the_command_that_CAn_Handle_it = () =>
        command_that_can_process.received(x => x.process(the_request));

      static IProcessARequest command_that_can_process;
      static IEncapsulateRequestDetails the_request;
      static IFindCommandsForRequests command_registry;
    }
  }
}