using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace WebAppCoreNouvelle.Middlewares
{
    public class MonMiddleWare
    {
        private readonly RequestDelegate _next;

        public MonMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        async public Task Invoke(HttpContext context)
        {
            //Ici le traitement 
            Debug.WriteLine($"Traiement de requête {DateTime.Now} ");
            HttpRequest request = context.Request;
            
            await _next(context);


            Debug.WriteLine($"Traiement de reponse {DateTime.Now} ");
            HttpResponse response = context.Response;

        }
    }
}
