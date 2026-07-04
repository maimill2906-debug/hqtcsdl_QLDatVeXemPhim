using System;
using System.Windows.Forms;
using MovieTicketBookingSystem.GUI;

namespace MovieTicketBookingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Enable TLS 1.2 for modern HTTPS connections (avoids SSL/TLS secure channel errors when downloading posters)
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;

            // Start the application with the Login Form
            Application.Run(new FormLogin());
        }
    }
}
