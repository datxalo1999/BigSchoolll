using System;
using System.Web.Http;

namespace BigSchoolll
{
    internal class WebApiConfig
    {
        public static Action<HttpConfiguration> Register { get; internal set; }
    }
}