using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzonMarket.Service.Helpers
{
    public class HttpContextHelper
    {
        public static IHttpContextAccessor Acsessor;

        public static HttpContext Context => Acsessor?.HttpContext;

        public static IHeaderDictionary ResponseHeaders => Context?.Response?.Headers;
    }
}
