using System.Collections.Generic;
using System.Linq;

namespace app.web.app.catalogbrowsing.stubs
{
  public class StubDepartmentRepository : IFindDepartments
  {
    public IEnumerable<DepartmentItem> get_main_departments()
    {
      return Enumerable.Range(1, 100).Select(x => new DepartmentItem{name = x.ToString("Department 0")});
    }

      public void get_sub_departments(DepartmentItem theCurentDepartment)
      {
          throw new System.NotImplementedException();
      }
  }
}