using System.Diagnostics;

namespace WebAppCoreNouvelle.Middlewares
{
    static public class ApplicationBuilderExtension
    {
      static public void UseMiddleware1(this IApplicationBuilder app)
      {
            app.Use(async (context, next) =>
            {
                ;//traitement de la requete niveau middleware 1
                Debug.WriteLine("traitement de la requete niveau middleware 1");
                await next();
                ;//traitement de la reponse niveau middleware 1
                Debug.WriteLine("traitement de la reponse niveau middleware 1");
            });
      }
      static public void UseMonMiddleWare(this IApplicationBuilder app)
      {
            app.UseMiddleware<MonMiddleWare>();
      }

    }
}
