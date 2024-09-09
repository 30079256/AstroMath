using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

// Student Name: Olga Selezneva
// Student ID: 30079256
// Date: 29/04/2024

// 3.	Create a ServiceHost and NetNamedPipeBinding in the “Program.cs” file to provide connection for the client(s).
// Ensure to add a Console.ReadLine to pause the program during operation.
namespace ConsoleAppServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer), 
                new Uri[]
                {
                    new Uri("net.pipe://localhost")
                }))
            {
                try
                {                    
                    host.AddServiceEndpoint(typeof(IAstroContract), 
                        new NetNamedPipeBinding(), "AstroService");
                    host.Open();
                    Console.WriteLine("Service is available. " + "Press <ENTER> to exit."); 
                    Console.ReadLine();
                    host.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    host.Abort();
                }
            }
        }
    }
}
