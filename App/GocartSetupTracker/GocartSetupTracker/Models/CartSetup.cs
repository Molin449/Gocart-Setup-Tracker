using System;
using System.Collections.Generic;
using System.Text;

namespace GocartSetupTracker.Models {
    public class CartSetup {

        public string TrackName { get; set; }
        public string SetupName { get; set; }
        public int Id { get; set; }
        public string CartBrand { get; set; }
        public string CartClass { get; set; }
        public double TirePressureFrontRight { get; set; }
        public double TirePressureFrontLeft { get; set; }
        public double TirePressureRearRight { get; set; }
        public double TirePressureRearLeft { get; set; }
        public string RearRaisedOrLowered { get; set; }
        public string FrontRaisedOrLowered { get; set; }
        public string HubType { get; set; }
        public string GearingFront { get; set; }
        public string GearingRear { get; set; }
        public string WidthFrontAxel { get; set; }
        public string WidthRearAxel { get; set; }
        public string IsWithFrontbar { get; set; }
        public string CamperAndCaster { get; set; }
        public double MotorTemp { get; set; }
        public double ExhaustTemp { get; set; }
        public double NozzleSize { get; set; }
        public double AirScrewRotations { get; set; }
        public int NeedlePosition { get; set; }
        public string SparkPlugGab { get; set; }

        public List<CartSetupPropertyData> GetCartSetupProperties() {
            
            Type myType = typeof(CartSetup);
            
            List<CartSetupPropertyData> propertiesWithName = new List<CartSetupPropertyData>() {
                new CartSetupPropertyData("Bane", TrackName, myType.GetProperty("TrackName")),
                new CartSetupPropertyData("Setup navn", SetupName, myType.GetProperty("SetupName")),
                new CartSetupPropertyData("Cart mærke", CartBrand, myType.GetProperty("CartBrand")),
                new CartSetupPropertyData("Cart klasse", CartClass, myType.GetProperty("CartClass")),
                new CartSetupPropertyData("Dæktryk højre forhjul", TirePressureFrontRight.ToString(), myType.GetProperty("TirePressureFrontRight")),
                new CartSetupPropertyData("Dæktryk venstre forhjul", TirePressureFrontLeft.ToString(), myType.GetProperty("TirePressureFrontLeft")),
                new CartSetupPropertyData("Dæktryk højre baghjul", TirePressureRearRight.ToString(), myType.GetProperty("TirePressureRearRight")),
                new CartSetupPropertyData("Dæktryk venstre baghjul", TirePressureRearLeft.ToString(), myType.GetProperty("TirePressureRearLeft")),
                new CartSetupPropertyData("Hævet/sænket bag", RearRaisedOrLowered, myType.GetProperty("RearRaisedOrLowered")),
                new CartSetupPropertyData("Hævet/sænket front", FrontRaisedOrLowered, myType.GetProperty("FrontRaisedOrLowered")),
                new CartSetupPropertyData("Nav type", HubType, myType.GetProperty("HubType")),
                new CartSetupPropertyData("Gearing front", GearingFront, myType.GetProperty("GearingFront")),
                new CartSetupPropertyData("Gearing bag", GearingRear, myType.GetProperty("GearingRear")),
                new CartSetupPropertyData("Med eller uden frontbar", IsWithFrontbar, myType.GetProperty("IsWithFrontbar")),
                new CartSetupPropertyData("Bredde foraksel", WidthFrontAxel, myType.GetProperty("WidthFrontAxel")),
                new CartSetupPropertyData("Bredde bagaksel", WidthRearAxel, myType.GetProperty("WidthRearAxel")),
                new CartSetupPropertyData("Camper/Caster", CamperAndCaster, myType.GetProperty("CamperAndCaster")),
                new CartSetupPropertyData("Motor temperatur", MotorTemp.ToString(), myType.GetProperty("MotorTemp")),
                new CartSetupPropertyData("Udstødnings temperatur", ExhaustTemp.ToString(), myType.GetProperty("ExhaustTemp")),
                new CartSetupPropertyData("Nål størrelse", NozzleSize.ToString(), myType.GetProperty("NozzleSize")),
                new CartSetupPropertyData("Luftskrue omgange", AirScrewRotations.ToString(), myType.GetProperty("AirScrewRotations")),
                new CartSetupPropertyData("Nål position 1/5", NeedlePosition.ToString(), myType.GetProperty("NeedlePosition")),
                new CartSetupPropertyData("Tændrørs gab", SparkPlugGab, myType.GetProperty("SparkPlugGab")),

            };

            return propertiesWithName;
        }
    }
}
