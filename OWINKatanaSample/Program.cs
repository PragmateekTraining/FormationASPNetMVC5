using System;

using Owin;
using Microsoft.Owin.Hosting;


namespace OWINKatanaSample
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
