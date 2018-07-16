using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsSelector
{
    class Webs
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;


            Console.WriteLine(@" __          __  _     _____      _           _             
 \ \        / / | |   / ____|    | |         | |            
  \ \  /\  / /__| |__| (___   ___| | ___  ___| |_ ___  _ __ 
   \ \/  \/ / _ \ '_ \\___ \ / _ \ |/ _ \/ __| __/ _ \| '__|
    \  /\  /  __/ |_) |___) |  __/ |  __/ (__| || (_) | |   
     \/  \/ \___|_.__/_____/ \___|_|\___|\___|\__\___/|_|  ");
            Console.WriteLine("");
            Console.WriteLine("Selecciona la web a la que quieres acceder: ");
            Console.WriteLine("");
            Console.WriteLine("1) MemeDeportes");
            Console.WriteLine("2) CuantaRazón");
            Console.WriteLine("3) YouTube");
            Console.WriteLine("4) Gmail");
            Console.WriteLine("5) Amazon");
            Console.WriteLine("6) Ali-Express");
            Console.WriteLine("7) Instant-Gaming");
            Console.WriteLine("8) Intranet");
            Console.WriteLine("9) Poliformat");

            while(true)
            switch (Console.ReadLine()) {

                case "1":
                    System.Diagnostics.Process.Start("www.memedeportes.com");
                    break;

                case "2":
                    System.Diagnostics.Process.Start("www.cuantarazon.com");
                    break;

                case "3":
                    System.Diagnostics.Process.Start("www.youtube.com");
                    break;

                case "4":
                    System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/");
                    break;

                case "5":
                    System.Diagnostics.Process.Start("www.amazon.es");
                    break;

                case "6":
                    System.Diagnostics.Process.Start("www.es.aliexpress.com");
                    break;

                case "7":
                    System.Diagnostics.Process.Start("www.instant-gaming.com/es/");
                    break;
                    
                case "8":
                    System.Diagnostics.Process.Start("https://intranet.upv.es/pls/soalu/est_intranet.Ni_portal_n");
                    break;
                    
                case "9":
                    System.Diagnostics.Process.Start("https://poliformat.upv.es/portal/site/!gateway-es/tool/4bd36fed-4d79-4d97-a044-f5c1b72f2339");
                    break;
                }

        }
    }
}
