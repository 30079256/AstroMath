using System;

// Student Name: Olga Selezneva
// Student ID: 30079256
// Date: 29/04/2024

namespace AstroMaths
{
    /// <summary>
    /// Methods for astronomical calculations
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// Method to measure the Star velocity using the Doppler shift
        /// </summary>
        /// <param name="observedWavelength">Observed wavelength of light from the star in meters of type double</param>
        /// <param name="restWavelength">Rest wavelength of the emitted light in meters of type double</param>
        /// <returns>A double which represents the star velocity in meters per second</returns>
        public static double StarVelocity(double observedWavelength, double restWavelength)
        {
            return (((observedWavelength - restWavelength) / restWavelength) * (3.0 * Math.Pow(10, 8)));
        }

        /// <summary>
        /// Method to measure the star distance using the parallax angle
        /// </summary>
        /// <param name="parallaxAngle">Parallax angle of the star measured in arcseconds of type double</param>
        /// <returns>A double which represents the distance to the star in parsecs. Returns 0 for non-positive parallax angle values</returns>
        public static double StarDistance(double parallaxAngle)
        {
            if (parallaxAngle <= 0)
                return 0;
            else
                return (1 / parallaxAngle);
        }

        /// <summary>
        /// Method to convert a temperature from Celsius to Kelvin
        /// </summary>
        /// <param name="celsiusTemperature">Temperature in degrees Celsius of type double</param>
        /// <returns>A double which represents the temperature in degrees Kelvin. Returns 0 for temperatures below absolute zero</returns>
        public static double KelvinTemperature(double celsiusTemperature)
        {
            if (celsiusTemperature < -273.00)
                return 0;
            else
                return (celsiusTemperature + 273);
        }

        /// <summary>
        /// Method that returns the distance from the centre of a blackhole to the event horizon
        /// </summary>
        /// <param name="blackholeMass">Mass of the black hole in kilograms of type double</param>
        /// <returns>A double which is the event horizon in metres</returns>
        public static double EventHorizon(double blackholeMass)
        {
            return (2 * (6.674 * Math.Pow(10, -11)) * blackholeMass / Math.Pow(299792458, 2));
        }
    }
}
