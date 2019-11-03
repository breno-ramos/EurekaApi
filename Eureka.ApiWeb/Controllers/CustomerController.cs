using Eureka.Domain.Commands.CustomerCommands;
using Eureka.Domain.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Eureka.ApiWeb.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerApplicationService _service;

        //public CustomerController() { }

        public CustomerController(ICustomerApplicationService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("api/customer")]
        public Task<HttpResponseMessage> Create([FromBody]dynamic body)
        {
            var command = new CreateCustomerCommand();

            var customer = _service.Create(command);

            return CreateResponse(HttpStatusCode.Created, customer);
        }
    }
}