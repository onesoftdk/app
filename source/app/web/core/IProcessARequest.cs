namespace app.web.core
{
  public interface IProcessARequest : IImplementAFeature
  {
    bool can_process(IEncapsulateRequestDetails request);
  }
}