using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

// 1.	Create the ServiceContract file called “IAstroContract.cs”
// which will require an Interface that references the AstroMath.DLL
// and four OperationContract (one for each calculation). 
namespace ConsoleAppServer
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
