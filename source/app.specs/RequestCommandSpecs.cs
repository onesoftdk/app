using Machine.Specifications;
using app.web;
using developwithpassion.specifications.extensions;
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
                                  sut.command_type = "COMMAND_TYPE";
                                  the_request = fake.an<IEncapsulateRequestDetails>();
                                  //the_request.setup(x => x.command_type).Return("COMMAND_TYPE");
                              };

            Because b = () =>
              sut.can_process(the_request);

            It should_have_correct_command_type = () => { sut.command_type.ShouldEqual(the_request.command_type); };

         static IEncapsulateRequestDetails the_request;
        }
    }
}