using System.Web;

namespace app.web
{
    public class BasicHandler : IHttpHandler
    {
        IProcessWebRequests front_controller;
        readonly ICreateRequests createRequests;

        public BasicHandler(IProcessWebRequests front_controller, ICreateRequests createRequests)
        {
            this.front_controller = front_controller;
            this.createRequests = createRequests;
        }

        public void ProcessRequest(HttpContext context)
        {
            front_controller.process(createRequests.create_request_from(context));
        }

        public bool IsReusable
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}