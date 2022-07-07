using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace found
{
    public class Indexx : PageModel
    {
        public const string SessionKeyId = "id";
        public string SessionInfo_Age { get; private set; }
        public void OnGet()
        {
            var id = HttpContext.Session.GetInt32(SessionKeyId);
        }
    }
}
