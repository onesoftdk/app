using System.Collections.Generic;

namespace app.web.app.catalogbrowsing
{
  public interface IFindDepartments
  {
    IEnumerable<DepartmentItem> get_main_departments();
    IEnumerable<DepartmentItem> get_sub_departments(DepartmentItem theCurentDepartment);
  }
}