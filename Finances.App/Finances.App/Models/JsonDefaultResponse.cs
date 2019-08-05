using System;
using System.Collections.Generic;
using System.Text;

namespace Finances.App.Models
{
    public class JsonDefaultResponse<T>
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public T Payload { get; set; }
    }
}
