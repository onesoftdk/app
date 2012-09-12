namespace app.web.core
{
  public interface IFindCommandsForRequests
  {
    IProcessARequest get_the_command_that_can_process_The_request(IEncapsulateRequestDetails request);
  }
}