using app.web.app.catalogbrowsing.stubs;
using app.web.core;
using app.web.core.stubs;

namespace app.web.app.catalogbrowsing
{
  public class ViewTheMainDepartmentsInTheStore : IImplementAFeature
  {
    IFindDepartments department_service;
    IDisplayInformation display_engine;

    public ViewTheMainDepartmentsInTheStore():this(new StubDepartmentRepository(),
      new StubDisplayEngine())
    {
    }

    public ViewTheMainDepartmentsInTheStore(IFindDepartments department_service, IDisplayInformation display_engine)
    {
      this.department_service = department_service;
      this.display_engine = display_engine;
    }

    public void process(IEncapsulateRequestDetails request)
    {
      display_engine.display(department_service.get_main_departments());
    }
  }
}