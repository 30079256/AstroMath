using AstroMaths;

// Student Name: Olga Selezneva
// Student ID: 30079256
// Date: 29/04/2024

// Finally, test and debug the code to ensure the formulas work correctly and return the correct values (use a driver program or the built-in Unit Test).
// Create a separate console program with test methods and hardcoded data to check the basic functionality of the DLL. 
// Sample Test Data:
// Star Velocity: Input Observed 500.1nm; Rest 500.0nm. Output 60000 m/s
// Star Distance: Input parallax angle 0.547 arcseconds. Output 1.83 parsec
// Temp in Kelvin: Input 27 degrees C. Output 300 degrees K
// Event Horizon: Input 8.2 x 10^36kg. Output 1.2 x 10^10 metres

double obsWavNm = 500.1; 
double restWavNm = 500.0; 
double parAngArcs = 0.547;
double celsTempDeg = 27;
double blackMassKg = 8.2 * Math.Pow(10, 36);

double starVelMps = Math.Round(Calculation.StarVelocity(obsWavNm, restWavNm));
double starDistPars = Math.Round(Calculation.StarDistance(parAngArcs), 2);
double kelvTempDeg = Calculation.KelvinTemperature(celsTempDeg);
double eventHorizM = Calculation.EventHorizon(blackMassKg);

Console.WriteLine("Observed Wavelength: " + obsWavNm + " nm. Rest Wavelength: " + restWavNm + " nm. Star Velocity: " + starVelMps + " m/s\n");
Console.WriteLine("Parallax Angle: " + parAngArcs + " arcseconds. Star Distance: " + starDistPars + " parsec\n");
Console.WriteLine("Temperature in Celsius: " + celsTempDeg + " degrees C. Temperature in Kelvin: " + kelvTempDeg + " degrees K\n");
Console.WriteLine("Black Hole Mass: " + blackMassKg.ToString("0.0e+00").Replace("e+", " x 10^") + " kg. Event Horizon: " + eventHorizM.ToString("0.0e+00").Replace("e+", " x 10^") + " metres");
Console.ReadLine();