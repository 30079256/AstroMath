using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleAppClient
{
    [ServiceContract]
    public interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double observedWavelength, double restWavelength);

        [OperationContract]
        double StarDistance(double parallaxAngle);

        [OperationContract]
        double KelvinTemperature(double celsiusTemperature);

        [OperationContract]
        double EventHorizon(double blackholeMass);
    }
}