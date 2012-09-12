using System;

namespace app.web.core
{
  public class RequestCommand : IProcessARequest
  {
    Predicate<IEncapsulateRequestDetails> request_match;
    IImplementAFeature feature;

    public RequestCommand(Predicate<IEncapsulateRequestDetails> request_match, IImplementAFeature feature)
    {
      this.request_match = request_match;
      this.feature = feature;
    }

    public void process(IEncapsulateRequestDetails the_request)
    {
      feature.process(the_request);
    }

    public bool can_process(IEncapsulateRequestDetails request)
    {
      return request_match(request);
    }
  }
}