using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            //THE DISPLAY

            var i = 0;
            do
            {
                Console.WriteLine("Select Lab Test:");
                Console.WriteLine("1: Liquid Limit");
                Console.WriteLine("2: Plastic Limit");
                Console.WriteLine("3: 200 Sieve");
                Console.WriteLine("4: Swell");
                Console.WriteLine("5: Moisture Content");
                Console.WriteLine("6: Shrink");
                Console.WriteLine("7: Proctor");
                Console.WriteLine("");
                Console.WriteLine("-Press Enter Alone To End Program-");
                Console.WriteLine("");
                Console.Write("Enter Test Number:");

                //INPUT
                var testType = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine($"You have selected test {testType}");

                //LOGIC
                switch (testType)
                {
                    case 1:
                        LiquidLimitTest();
                        break;
                    case 2:
                        PlasticLimitTest();
                        break;
                    case 3:
                        SieveTest();
                        break;
                    case 4:
                        SwellTest();
                        break;
                    case 5:
                        MoistureTest();
                        break;
                    case 6:
                        ShrinkTest();
                        break;
                    case 7:
                        ProctorTest();
                        break;
                    default:
                        break;
                }
            }
            while (i == 0);
        }

        public static void LiquidLimitTest()
        {
            var i = 1;
            do
            {
                Console.Write("Enter Wet Weight:");
                var wetWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Enter Dry Weight:");
                var dryWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Enter Tare Weight:");
                var tareWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Enter Blow Count:");
                var blowCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine();
                var liquidLimit = (wetWeight - dryWeight) / (dryWeight - tareWeight);
                var liquidLimitCorrected = liquidLimit * BlowRef[blowCount - 1];
                Console.WriteLine($"The liquid Limit is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(liquidLimit), 2)) * 100)}%");
                Console.WriteLine($"The liquid Limit is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(liquidLimitCorrected), 2)) * 100)}%");

                Console.WriteLine("Do you want to enter another test? Enter 1 for yes, or 0 for Main Menu:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);
        }

        public static void PlasticLimitTest()
        {
            var i = 1;
            do
            {
                Console.WriteLine("Enter Wet Weight:");
                var pWetWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Dry Weight:");
                var pDryWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine();
                var plasticlimit = (pWetWeight - pDryWeight) / (pDryWeight);
                Console.WriteLine($"The plastic Limit is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(plasticlimit), 2)) * 100)}%");

                Console.WriteLine("Do you want to enter another test? Enter 1 for yes, or 0 for Main Menu:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);
        }
        public static void SieveTest()
        {
            var i = 1;
            do
            {
                Console.WriteLine("Enter Tare Weight A:");
                var sTareWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Dry Weight Before Wash B:");
                var sBeforeWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Dry Weight After Wash C:");
                var sAfterWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Weight Retained On Number Four:");
                var sFour = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine();
                var fines = (sBeforeWeight - sAfterWeight) / (sBeforeWeight - sTareWeight);
                Console.WriteLine($"The percent fines is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(fines), 2)) * 100)}%");

                Console.WriteLine();
                var gravel = (sFour) / (sBeforeWeight - sTareWeight);
                Console.WriteLine($"The percent gravel is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(gravel), 2)) * 100)}%");

                Console.WriteLine();
                var sand = (1 - (fines + gravel));
                Console.WriteLine($"The percent sand is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(sand), 2)) * 100)}%");

                Console.WriteLine("Do you want to enter another test? Enter 1 for yes, or 0 for Main Menu:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);
        }
        public static void SwellTest()
        {
            var i = 1;
            do
            {
                Console.WriteLine("Enter Ring Weight:");
                var ringWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Inside Diameter:");
                var insideDiameter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Sample Height:");
                var sampleHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Wet Weight of Soil with Ring:");
                var soilRing = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Initial Tare Weight:");
                var iTareWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Initial Moist Soil Weight:");
                var iWetWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Initial Dry Soil Weight:");
                var iDryWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Final Tare Weight:");
                var fTareWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Final Moist Soil Weight:");
                var fWetWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Final Dry Soil Weight:");
                var fDryWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Seat Reading: (Ex. 0.1487)");
                var seatReading = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Highest Swell Reading: (Ex. 0.3327)");
                var swellReading = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine();
                var swellPercent = (swellReading - seatReading) / sampleHeight;
                Console.WriteLine($"The swell percent is {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)swellPercent), 3)) * 100)}%");

                Console.WriteLine();
                var iMoisture = (iWetWeight - iDryWeight) / (iDryWeight - iTareWeight);
                Console.WriteLine($"The initial moisture percent is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(iMoisture), 2)) * 100)}%");

                Console.WriteLine();
                var fMoisture = (fWetWeight - fDryWeight) / (fDryWeight - fTareWeight);
                Console.WriteLine($"The final moisture percent is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(fMoisture), 2)) * 100)}%");

                Console.WriteLine();
                var grams = soilRing - ringWeight;

                Console.WriteLine();
                var volume = (sampleHeight * (insideDiameter * insideDiameter) * 3.14159 / 4);

                Console.WriteLine();
                var moistDensity = (grams * 0.002205 / (volume / (144 * 12)));
                Console.WriteLine($"The Initial Moist Density is {Convert.ToInt32(moistDensity)}");

                Console.WriteLine();
                var dryDensity = (moistDensity / (1 + iMoisture));
                Console.WriteLine($"The Initial Dry Density is {Convert.ToInt32(dryDensity)}");

                Console.WriteLine("Do you want to enter another test? Enter 1 for yes, or 0 for Main Menu:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);

        }
        public static void MoistureTest()
        {
            var i = 1;
            do
            {
                Console.WriteLine("Enter Tare Weight:");
                var mTareWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Moist Soil Weight:");
                var mWetWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Dry Soil Weight:");
                var mDryWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine();
                var moisture = (mWetWeight - mDryWeight) / (mDryWeight - mTareWeight);
                Console.WriteLine($"The percent moisture is {Convert.ToInt32((Decimal.Round(Convert.ToDecimal(moisture), 2)) * 100)}%");

                Console.WriteLine("Do you want to enter another test? Enter 1 for yes, or 0 for Main Menu:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);

        }
        public static void ShrinkTest()
        {
            var i = 1;
            do
            {
                Console.WriteLine("Construction in progress.");

                Console.WriteLine("Enter 0 to end program and rerun for Main Menu:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);
        }
        public static void ProctorTest()
        {
            var i = 1;
            do
            {
                Console.WriteLine("Enter Moist Soil with Mold:");
                var proctorWetWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Weight of Mold:");
                var moldWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Volume of Mold:");
                var moldVolume = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Weight of Wet Soil with Tare:");
                var wetSoil = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Weight of Dry Soil with Tare:");
                var drySoil = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Weight of Tare:");
                var proctorTareWeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine();
                var waterWeight = (wetSoil - drySoil);
                Console.WriteLine($"The water weight is {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)waterWeight), 3)))}");

                Console.WriteLine();
                var drySoilWeight = (drySoil - proctorTareWeight);
                Console.WriteLine($"The dry soil weight is {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)drySoilWeight), 3)))}");

                Console.WriteLine();
                var moistureContent = (waterWeight / drySoilWeight);
                Console.WriteLine($"The moisture content is {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)moistureContent), 3)* 100))}%");

                Console.WriteLine();
                var soilWeight = (proctorWetWeight - moldWeight);
                Console.WriteLine($"The dry soil weight out of mold is {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)soilWeight), 3)))}");

                Console.WriteLine();
                var pounds = (soilWeight / 453.59);
                Console.WriteLine($"The converted pounds are {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)pounds), 2)))}");

                Console.WriteLine();
                var proctorMoistDensity = (pounds / moldVolume);
                Console.WriteLine($"The moist density is {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)proctorMoistDensity), 1)))}");

                Console.WriteLine();
                var dryDensity = (proctorMoistDensity / (1 + moistureContent));
                Console.WriteLine($"The dry soil weight is {Convert.ToDecimal((Decimal.Round(Convert.ToDecimal((float)dryDensity), 1)))}");

                Console.WriteLine("Enter 0 to end program and rerun for Main Menu:");
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);
        }
        public static List<double> BlowRef = new List<double>
        {
            //enter all the right values in here
            0.68,
            0.74,
            0.77,
            0.80,
            0.82,
            0.84,
            0.86,
            0.87,
            0.88,
            0.90,
            0.91,
            0.92,
            0.92,
            0.93,
            0.94,
            0.95,
            0.95,
            0.96,
            0.97,
            0.97,
            0.98,
            0.98,
            0.99,
            1.00,
            1.00,
            1.00,
            1.01,
            1.01,
            1.02,
            1.02,
            1.03,
            1.03,
            1.03,
            1.04,
            1.04
        };


    }
}