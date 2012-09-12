 using System.Web;
 using Machine.Specifications;
 using app.specs.utility;
 using app.web;
 using app.web.core;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

namespace app.specs
{  
  [Subject(typeof(BasicHandler))]  
  public class BasicHandlerSpecs
  {
    public abstract class concern : Observes<IHttpHandler,
                                      BasicHandler>
    {
        
    }

   
    public class when_processing_an_http_context : concern
    {
      Establish c = () =>
      {
        the_controller = depends.on<IProcessWebRequests>();
        request_factory = depends.on<ICreateRequests>();
        a_new_request = fake.an<IEncapsulateRequestDetails>();  

        a_context = ObjectFactory.web.create_http_context();

        request_factory.setup(x => x.create_request_from(a_context)).Return(a_new_request);
      };

      Because b = () =>
        sut.ProcessRequest(a_context);

      It should_delegate_the_processing_of_a_new_request_to_the_front_controller = () =>
        the_controller.received(x => x.process(a_new_request));

      static IProcessWebRequests the_controller;
      static IEncapsulateRequestDetails a_new_request;
      static HttpContext a_context;
      static ICreateRequests request_factory;
    }
  }
}
