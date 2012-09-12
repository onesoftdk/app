 using Machine.Specifications;
 using app.web;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

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

        command_registry.setup(x => x.get_the_command_that_can_process_The_request(the_request)).Return(command_that_can_process);
      };

      Because b = () =>
        sut.process(the_request);

      It should_delegate_the_processing_of_the_request_to_the_command_that_can_process_the_request = () =>
        command_that_can_process.received(x => x.process(the_request));

      static IProcessARequest command_that_can_process;
      static IEncapsulateRequestDetails the_request;
      static IFindCommandsForRequests command_registry;
    }
  }
}
