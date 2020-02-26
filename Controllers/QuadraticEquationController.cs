using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Linq;


namespace QuadraticEquationProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuadraticEquationController : ControllerBase
    {
        private readonly ILogger<QuadraticEquationController> _logger;

        public QuadraticEquationController(ILogger<QuadraticEquationController> logger)
        {
            _logger = logger;
        }

        /*public ActionResult Index()
        {
            return base.Content("index.html");
        }*/

        /*[HttpGet]
        public ActionResult<string> Get()
        { 
            return "Type values at the end of URL string to perform a calculation. Input example: '/A,B,C'";
        }*/
        [HttpGet]//("{A},{B},{C}")]
        public  ActionResult<string> Get(double A, double B, double C)
        {
            QuadraticEquation Equation = new QuadraticEquation();//from uri
            return Equation.EquationCalculation(A, B, C);
        }

        QuadraticEquation post_test_equation = new QuadraticEquation();
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> Put(double value)
        {
            return Ok();
        }
        [HttpGet("id")]
        public ActionResult<string> GetValue(double id)
        {
            return post_test_equation.A.ToString();
        }
    }
}
