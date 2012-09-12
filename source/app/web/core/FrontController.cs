namespace app.web.core
{
  public class FrontController : IProcessWebRequests
  {
    IFindCommandsForRequests command_registry;

    public FrontController(IFindCommandsForRequests command_registry)
    {
      this.command_registry = command_registry;
    }

    public FrontController():this(new CommandRegistry())
    {
    }

    public void process(IEncapsulateRequestDetails a_new_request)
    {
      command_registry.get_the_command_that_can_process_The_request(a_new_request).process(a_new_request);
    }
  }
}