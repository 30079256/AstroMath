using System.ServiceModel;

// 1.	Create the ServiceContract called “IAstroContract.cs” which will need to be identical to the server without a reference to the AstroMath.DLL.
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