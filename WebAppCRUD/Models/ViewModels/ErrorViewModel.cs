using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Schema;

namespace WebAppCRUD.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public Severity Severity { get; set; }
    }
}

namespace WebAppCRUD
{
    public enum Severity
    {
        Warning,Error,FatalError,Info
    }
}