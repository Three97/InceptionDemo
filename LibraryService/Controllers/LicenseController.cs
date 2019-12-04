namespace LibraryService.Controllers
{
    using System.Collections.Generic;

    using LibraryService.Models;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/license")]
    public class LicenseController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get([FromQuery] string customer)
        {
            IList<License> licenses;
            if (customer == "1")
            {
                licenses = GetLicenseForCustomerA();
            }
            else if (customer == "2")
            {
                licenses = GetLicenseForCustomerB();
            }
            else
            {
                licenses = GetDefaultLicenses();
            }

            return new JsonResult(licenses);
        }

        private IList<License> GetLicenseForCustomerA()
        {
            var licenses = new List<License>
            {
              new License { Name = "Angular", Title = "Space Module", Url = "http://localhost:4200", IconUrl = "" },
              new License { Name = "React", Title = "Planning Module", Url = "http://localhost:3000", IconUrl = "" },
              new License { Name = "Vue", Title = "Building Module", Url = "http://localhost:8080", IconUrl = "" },
              new License { Name = "ASP.NET Core", Title = "Awesome Module", Url = "http://localhost:5000", IconUrl = "" }
            };
            return licenses;
        }
        private IList<License> GetLicenseForCustomerB()
        {
            var licenses = new List<License>
            {
              new License { Name = "Angular", Title = "Space Module", Url = "http://localhost:4200", IconUrl = "" },
              new License { Name = "Vue", Title = "Building Module", Url = "http://localhost:8080", IconUrl = "" }
            };
            return licenses;
        }
        private IList<License> GetDefaultLicenses()
        {
            var licenses = new List<License>
            {
              new License { Name = "Angular", Title = "Space Module", Url = "http://localhost:4200", IconUrl = "" }
            };
            return licenses;
        }
    }
}
