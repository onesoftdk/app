namespace app.web
{
  public class RequestCommand : IProcessARequest
  {
    
    public void process(IEncapsulateRequestDetails the_request)
    {
      throw new System.NotImplementedException();
    }

    public bool can_process(IEncapsulateRequestDetails request)
    {
       
       
      throw new System.NotImplementedException();
    }

      public string command_type { get; set; }
  }
}