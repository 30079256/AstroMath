using System;
using System.ServiceModel;

// Student Name: Olga Selezneva
// Student ID: 30079256
// Date: 29/04/2024

// Create a separate console client with test data to establish connectivity and check the basic functionality of the server.
namespace ConsoleAppClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Started");

            ChannelFactory<IAstroContract> pipeFactory = 
                new ChannelFactory<IAstroContract>(
                    new NetNamedPipeBinding(),
                    new EndpointAddress("net.pipe://localhost/AstroService"));
            
            IAstroContract pipeProxy = pipeFactory.CreateChannel();

            try
            {
                double obsWavNm = 500.1;
                double restWavNm = 500.0;
                double starVelMps = Math.Round(pipeProxy.StarVelocity(obsWavNm, restWavNm));
                Console.WriteLine("Observed Wavelength: " + obsWavNm + " nm. Rest Wavelength: " + restWavNm + " nm. Star Velocity: " + starVelMps + " m/s\n");

                double parAngArcs = 0.547;
                double starDistPars = Math.Round(pipeProxy.StarDistance(parAngArcs), 2);
                Console.WriteLine("Parallax Angle: " + parAngArcs + " arcseconds. Star Distance: " + starDistPars + " parsec\n");

                double celsTempDeg = 27;
                double kelvTempDeg = pipeProxy.KelvinTemperature(celsTempDeg);
                Console.WriteLine("Temperature in Celsius: " + celsTempDeg + " degrees C. Temperature in Kelvin: " + kelvTempDeg + " degrees K\n");

                double blackMassKg = 8.2 * Math.Pow(10, 36);
                double eventHorizM = pipeProxy.EventHorizon(blackMassKg);
                Console.WriteLine("Black Hole Mass: " + blackMassKg.ToString("0.0e+00").Replace("e+", " x 10^") + " kg. Event Horizon: " + eventHorizM.ToString("0.0e+00").Replace("e+", " x 10^") + " metres");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press <ENTER> to exit");
            Console.ReadLine();
        }
    }
}