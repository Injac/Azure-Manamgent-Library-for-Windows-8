using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace ManagmentApiMockingService
{
    class Program
    {
        private static string url;

        static int Main(string[] args)
        {
            if (args.Length == 1)
            {
                url = args[0] as string;

                using (WebApp.Start<Startup>(url))
                {

                    Console.WriteLine("Azure Manamgent API mock server started...");
                    Console.ReadLine();
                    Console.WriteLine("Azure Manamgnet API mock server stopped...");
                    return 0;

                }

            }
            
            Console.WriteLine("This will not work. We neeed a url as the first parameter.");
            return 1;
            
        }
    }
}