namespace app.web.core.stubs
{
  public class StubMissingCommand : IProcessARequest
  {
    public void process(IEncapsulateRequestDetails request)
    {
    }

    public bool can_process(IEncapsulateRequestDetails request)
    {
      return false;
    }
  }
}