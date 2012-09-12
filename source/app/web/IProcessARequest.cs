namespace app.web
{
  public interface IProcessARequest
  {
    void process(IEncapsulateRequestDetails the_request);
    bool can_process(IEncapsulateRequestDetails request);
    string command_type { get; set; }
  }
}