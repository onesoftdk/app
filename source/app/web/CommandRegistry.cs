using System.Collections.Generic;

namespace app.web
{
  public class CommandRegistry : IFindCommandsForRequests
  {
    IEnumerable<IProcessARequest> all_commands;

    public CommandRegistry(IEnumerable<IProcessARequest> all_commands)
    {
      this.all_commands = all_commands;
    }

    public IProcessARequest get_the_command_that_can_process_The_request(IEncapsulateRequestDetails request)
    {
      throw new System.NotImplementedException();
    }
  }
}