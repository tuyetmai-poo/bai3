using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers
{
    public class Default : Controller
    {
        public string Hi(string fname, string lname)
        {
            return $"Hello {fname} {lname}";
        }
    }
}
