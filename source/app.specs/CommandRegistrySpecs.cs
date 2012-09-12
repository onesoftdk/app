 using System.Collections.Generic;
 using System.Linq;
 using Machine.Specifications;
 using app.web;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

namespace app.specs
{  
  [Subject(typeof(CommandRegistry))]  
  public class CommandRegistrySpecs
  {
    public abstract class concern : Observes<IFindCommandsForRequests,
                                      CommandRegistry>
    {
        
    }

   
    public class when_getting_a_command_for_a_request_and_ITh_AS_The_command : concern
    {
      Establish c = () =>
      {
        all_the_commands = Enumerable.Range(1,100).Select(x => fake.an<IProcessARequest>()).ToList();
        all_the_commands.Add(the_Command_that_can_handle_theR_Equest);
        the_Command_that_can_handle_theR_Equest = fake.an<IProcessARequest>();

        request = fake.an<IEncapsulateRequestDetails>();
        the_Command_that_can_handle_theR_Equest.setup(x => x.can_process(request)).Return(true);


        depends.on<IEnumerable<IProcessARequest>>(all_the_commands);
      };

      Because b = () =>
        result = sut.get_the_command_that_can_process_The_request(request);

      It should_return_THE_COMmand_That_can_HAndle_it = () =>
        result.ShouldEqual(the_Command_that_can_handle_theR_Equest);


      static IProcessARequest result;
      static IProcessARequest the_Command_that_can_handle_theR_Equest;
      static IEncapsulateRequestDetails request;
      static IList<IProcessARequest> all_the_commands;
    }
  }
}
