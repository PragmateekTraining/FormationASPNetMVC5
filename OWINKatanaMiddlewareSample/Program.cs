using System;

using Owin;
using Microsoft.Owin.Hosting;


namespace OWINKatanaMiddlewareSample
{
    class Program
    {
        const string serverUrl = "http://localhost:1234";

        const string htmlDocument = @"<!DOCTYPE html>
<body>
    <section>
        <h1>Hello</h1>
    </section>
</body>";

        static void StartUp(IAppBuilder appBuilder)
        {
            appBuilder.Use(async (context, next) =>
            {
                if (context.Request.Path.Value == "/")
                {
                    context.Response.Redirect("/index.html");
                }

                await next();
            });

            appBuilder.Use(async (context, next) =>
            {
                Console.WriteLine("New request for resource '{0}'.", context.Request.Path);

                await next();

                Console.WriteLine("Response status is '{0}'.", context.Response.StatusCode);
            });

            appBuilder.Run(async context =>
            {
                await context.Response.WriteAsync(htmlDocument);
            });
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Server is starting...");

            using (WebApp.Start(serverUrl, StartUp))
            {
                Console.WriteLine("Server is running.");
                Console.WriteLine("Press <ENTER> to stop it...");

                Console.ReadLine();

                Console.WriteLine("Server is stopping...");
            }

            Console.WriteLine("Server has been stopped.");
        }
    }
}
