using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace QuadraticEquationProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuadraticEquationController : ControllerBase
    {
        private readonly ILogger<QuadraticEquationController> _logger;

        public QuadraticEquationController(ILogger<QuadraticEquationController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Type values at the end of URL string to perform a calculation. Input example: '/A,B,C'";
        }
        [HttpGet("{A},{B},{C}")]
        public ActionResult<string> Get(double A, double B, double C)
        {
            QuadraticEquation Equation = new QuadraticEquation();
            return Equation.EquationCalculation(A, B, C);
        }
    }
}
