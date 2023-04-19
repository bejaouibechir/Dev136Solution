using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WebAppCRUD.Modules
{
    public class TraceModule : IHttpModule
    {

        private HttpApplication _context;
        string _path = string.Empty;
        DateTime _now;

        public void Dispose()
        {
           ;
        }

        public void Init(HttpApplication context) //Users,Requests, Responses,Coockies Sessions
        {
            _context = context;
            _context.BeginRequest += _context_BeginRequest;
        }

        private void _context_BeginRequest(object sender, EventArgs e)
        {
            _now = DateTime.Now;
            _path = $"{ _context.Request.Url} last visit at" +
                $" Date:{_now.Day}/{_now.Month}/{_now.Year} Time: {_now.Hour}:{_now.Minute}";
            EventLog.WriteEntry("Application", _path, EventLogEntryType.Information);
        }

    }
}