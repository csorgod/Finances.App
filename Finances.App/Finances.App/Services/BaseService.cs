using Finances.App.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Finances.App.Services
{
    public class BaseService
    {
        protected HttpClient HttpClient;

        public BaseService()
        {
            HttpClient = new HttpClient();
        }

    }
}
