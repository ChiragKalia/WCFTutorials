using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your name");
            //string name = Console.ReadLine().ToString();
            //HelloService.HelloService service = new HelloService.HelloService();
            //var output = service.GetMessage(name);
            //Console.WriteLine(output);
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host Started @" + DateTime.Now);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
