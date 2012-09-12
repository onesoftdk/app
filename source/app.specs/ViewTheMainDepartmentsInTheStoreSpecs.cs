using Machine.Specifications;
using app.web.app.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.extensions;
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
                                  service_request = depends.on<IAmADepartmentServiceRequest>();
                                  request = fake.an<IEncapsulateRequestDetails>();
                              };

            Because b = () =>
              sut.process(request);

            It should_get_the_main_departments_in_the_store = () => service_request.received(x => x.get_main_departments());

            static IEncapsulateRequestDetails request;
            static IAmADepartmentServiceRequest service_request;
        }
    }
}