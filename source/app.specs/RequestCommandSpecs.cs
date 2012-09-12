using System;
using Machine.Specifications;
using app.web;
using app.web.core;
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
        the_request = fake.an<IEncapsulateRequestDetails>();
        depends.on<Predicate<IEncapsulateRequestDetails>>(x =>
        {
          x.ShouldEqual(the_request);
          return true;
        });
      };

      Because b = () =>
        result = sut.can_process(the_request);

      It should_make_its_determination_by_using_its_request_specification = () =>
        result.ShouldBeTrue();

      static IEncapsulateRequestDetails the_request;
      static bool result;
    }

    public class when_processing_a_request : concern
    {
      Establish c = () =>
      {
        app_behaviour = depends.on<IImplementAFeature>();
        request = fake.an<IEncapsulateRequestDetails>();
      };

      Because b = () =>
        sut.process(request);

      It should_run_the_feature = () =>
        app_behaviour.received(x => x.process(request));

      static IImplementAFeature app_behaviour;
      static IEncapsulateRequestDetails request;
    }
  }
}