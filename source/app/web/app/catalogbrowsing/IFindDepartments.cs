using System.Collections.Generic;

namespace app.web.app.catalogbrowsing
{
  public interface IFindDepartments
  {
    IEnumerable<DepartmentItem> get_main_departments();
  }
}