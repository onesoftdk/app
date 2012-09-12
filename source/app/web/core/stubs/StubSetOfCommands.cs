using System.Collections;
using System.Collections.Generic;
using app.web.app.catalogbrowsing;

namespace app.web.core.stubs
{
  public class StubSetOfCommands : IEnumerable<IProcessARequest>
  {
    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public IEnumerator<IProcessARequest> GetEnumerator()
    {
      yield return new RequestCommand(x => true,
                                      new ViewTheMainDepartmentsInTheStore());
    }
  }
}