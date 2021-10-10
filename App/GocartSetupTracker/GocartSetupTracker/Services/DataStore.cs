using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GocartSetupTracker.Models {
    public class DataStore {  
        private DataStore() { }
        private static DataStore instance;
        public static DataStore getInstance {
            get {
                if (instance == null) {
                    instance = new DataStore();
                }
                return instance;
            }
        }
        private ObservableCollection<CartSetup> oc;
        public ObservableCollection<CartSetup> GetList {
            get {
                oc = new ObservableCollection<CartSetup>(){
                
                    new CartSetup {TrackName = "Nisseringen", SetupName = "Nisseringen setup 1", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Nisseringen", SetupName = "Nisseringen setup 2", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Jyllandsringen", SetupName = "Jyllandsringen regnvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Jyllandsringen", SetupName = "Jyllandsringen tørvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Nisseringen", SetupName = "Nisseringen regnvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Jyllandsringen", SetupName = "Jyllandsringen tørvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Jyllandsringen", SetupName = "Jyllandsringen tørvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Nisseringen", SetupName = "Nisseringen regnvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Jyllandsringen", SetupName = "Jyllandsringen tørvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },
                new CartSetup {TrackName = "Jyllandsringen", SetupName = "Jyllandsringen tørvejr", AirScrewRotations = 1, CamperAndCaster = "data", CartBrand="Rotax", CartClass="open A",
                    ExhaustTemp = 98, FrontRaisedOrLowered = "-10", GearingFront="13 tands", GearingRear="45 tands",
                    HubType="idk", Id=1, IsWithFrontbar= "Med", MotorTemp= 90, NeedlePosition=2, NozzleSize=5.1,
                    RearRaisedOrLowered="+10",SparkPlugGab="2", TirePressureFrontLeft=1.6, TirePressureFrontRight=1.6,
                    TirePressureRearLeft=1.6, TirePressureRearRight= 1.6, WidthFrontAxel="32"
                },

            };


                return oc;
            }
        }


        

        public void AddItem(CartSetup cartSetup) {
            oc.Add(cartSetup);
        }


        public void DeleteItem(CartSetup cartSetup) {
            oc.Remove(cartSetup);
        }

    }
}
