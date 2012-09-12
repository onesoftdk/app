﻿using System.Collections.Generic;
using System.Linq;

namespace app.web
{
  public class CommandRegistry : IFindCommandsForRequests
  {
    IEnumerable<IProcessARequest> all_commands;
    IProcessARequest special_case;

    public CommandRegistry(IEnumerable<IProcessARequest> all_commands, IProcessARequest special_case)
    {
      this.all_commands = all_commands;
      this.special_case = special_case;
    }

    public IProcessARequest get_the_command_that_can_process_The_request(IEncapsulateRequestDetails request)
    {
        var the_one = this.all_commands.FirstOrDefault(x => x.can_process(request));

        if (the_one == null)
            return special_case;

        return the_one;
    }
  }
}