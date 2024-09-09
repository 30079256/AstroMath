using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMaths;
using System.ServiceModel;

// 2.	Create the server file called “AstroServer.cs” which implements the IAstroContract.
// Add a new instance of the class library method and then create four methods
// with the suitable input parameters and return types.
namespace ConsoleAppServer
{
    public class AstroServer : IAstroContract
    {
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            return Calculation.StarVelocity(observedWavelength, restWavelength);
        }
        public double StarDistance(double parallaxAngle)
        {
            return Calculation.StarDistance(parallaxAngle);
        }
        public double KelvinTemperature(double celsiusTemperature)
        {
            return Calculation.KelvinTemperature(celsiusTemperature);
        }
        public double EventHorizon(double blackholeMass)
        {
            return Calculation.EventHorizon(blackholeMass);
        }
    }
}
