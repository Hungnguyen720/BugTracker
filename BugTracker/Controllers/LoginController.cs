using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        // GET: api/Login
        [HttpGet]
        public ActionResult Get()
        {
            var grandmaClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Hung"),
                new Claim(ClaimTypes.Email, "Hung@gmail.com"),
                new Claim("Grandma.Says", "Very cool")
            };

            var licenseClaims = new List<Claim>()
            {

                new Claim(ClaimTypes.Name, "Hung Nguyen"),
                new Claim("DrivingLicense", "A+")

            };

            var grandmaIdentity = new ClaimsIdentity(grandmaClaims, "Grandma Identity");
            var licenseIdentity = new ClaimsIdentity(licenseClaims, "Government Identity ");

            var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });

            HttpContext.SignInAsync(userPrincipal);

            return Content("test");
        }


    }
}
