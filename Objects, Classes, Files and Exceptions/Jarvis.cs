using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Jarvis
{
    class Arm
    {
        public int EnergyConsumption { get; set; }
        public int ReachDistance { get; set; }
        public int FingerCount { get; set; }
    }

    class Leg
    {
        public int EnergyConsumption { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }

    class Torso
    {
        public int EnergyConsumption { get; set; }
        public double ProcessorSize { get; set; }
        public string HousingMaterial { get; set; }
    }

    class Head
    {
        public int EnergyConsumption { get; set; }
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }
    }

    class Jarvis
    {
        public List<Arm> Arms { get; set; }
        public List<Leg> Legs { get; set; }
        public Torso Torso { get; set; }
        public Head Head { get; set; }

        static void Main()
        {
            BigInteger maxEnergyConsumption = BigInteger.Parse(Console.ReadLine());

            Jarvis jarvis = AssembleJarvis();
            var totalJarvisPartsEnergyConsumption = 0;

            for (int i = 0; i < 2; i++)
            {
                totalJarvisPartsEnergyConsumption += jarvis.Arms[i].EnergyConsumption;
                totalJarvisPartsEnergyConsumption += jarvis.Legs[i].EnergyConsumption;
            }

            totalJarvisPartsEnergyConsumption += jarvis.Head.EnergyConsumption + jarvis.Torso.EnergyConsumption;

            if (maxEnergyConsumption  < totalJarvisPartsEnergyConsumption)
            {
                Console.WriteLine("We need more power!");
            }
            else if (jarvis.Head.EnergyConsumption == 0 || jarvis.Torso.EnergyConsumption == 0 ||
                jarvis.Arms.Count <= 0 || jarvis.Legs.Count <= 0)
            {
                Console.WriteLine("We need more parts!");
            }
            else
            {
                PrintJarvis(jarvis);
            }

        }

        private static void PrintJarvis(Jarvis jarvis)
        {
            Console.WriteLine("Jarvis:");

            Console.WriteLine($"#Head:\r\n###Energy consumption: {jarvis.Head.EnergyConsumption}");
            Console.WriteLine($"###IQ: {jarvis.Head.IQ}\r\n###Skin material: {jarvis.Head.SkinMaterial}");
            Console.WriteLine($"#Torso:\r\n###Energy consumption: {jarvis.Torso.EnergyConsumption}");
            Console.WriteLine($"###Processor size: {jarvis.Torso.ProcessorSize:f1}\r\n###Corpus material: {jarvis.Torso.HousingMaterial}");

            foreach (var arm in jarvis.Arms.OrderBy(x => x.EnergyConsumption))
            {
                Console.WriteLine($"#Arm:\r\n###Energy consumption: {arm.EnergyConsumption}");
                Console.WriteLine($"###Reach: {arm.ReachDistance}\r\n###Fingers: {arm.FingerCount}");
            }

            foreach (var leg in jarvis.Legs.OrderBy(x => x.EnergyConsumption))
            {
                Console.WriteLine($"#Leg:\r\n###Energy consumption: {leg.EnergyConsumption}");
                Console.WriteLine($"###Strength: {leg.Strength}\r\n###Speed: {leg.Speed}");
            }
        }

        static Jarvis AssembleJarvis()
        {
            var input = Console.ReadLine();

            Jarvis jarvis = new Jarvis();

            jarvis.Arms = new List<Arm>();
            jarvis.Legs = new List<Leg>();
            jarvis.Head = new Head();
            jarvis.Torso = new Torso();


            while (input != "Assemble!")
            {
                var robotTokens = input.Split(' ').ToArray();
                var componentType = robotTokens[0];
                var energyConsumption = int.Parse(robotTokens[1]);
                var firstProperty = robotTokens[2];
                var secondProperty = robotTokens[3];

                switch (componentType)
                {
                    case "Arm":
                        Arm arm = new Arm();
                        arm.EnergyConsumption = energyConsumption;
                        arm.ReachDistance = int.Parse(firstProperty);
                        arm.FingerCount = int.Parse(secondProperty);

                        if (jarvis.Arms.Count == 2)
                        {
                            if (jarvis.Arms[0].EnergyConsumption > arm.EnergyConsumption && jarvis.Arms[1].EnergyConsumption > arm.EnergyConsumption)
                            {
                                jarvis.Arms.Remove(jarvis.Arms[0]);
                                jarvis.Arms.Add(arm);
                            }
                            else
                            {
                                foreach (var jarvisArm in jarvis.Arms)
                                {
                                    if (arm.EnergyConsumption < jarvisArm.EnergyConsumption)
                                    {
                                        jarvis.Arms.Remove(jarvisArm);
                                        jarvis.Arms.Add(arm);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            jarvis.Arms.Add(arm);
                        }
                        break;
                    case "Leg":
                        Leg leg = new Leg();
                        leg.EnergyConsumption = energyConsumption;
                        leg.Strength = int.Parse(firstProperty);
                        leg.Speed = int.Parse(secondProperty);

                        if (jarvis.Legs.Count == 2)
                        {
                            if (jarvis.Legs[0].EnergyConsumption > leg.EnergyConsumption && jarvis.Legs[1].EnergyConsumption > leg.EnergyConsumption)
                            {
                                jarvis.Legs.Remove(jarvis.Legs[0]);
                                jarvis.Legs.Add(leg);
                            }
                            else
                            {
                                foreach (var jarvisLeg in jarvis.Legs)
                                {
                                    if (leg.EnergyConsumption < jarvisLeg.EnergyConsumption)
                                    {
                                        jarvis.Legs.Remove(jarvisLeg);
                                        jarvis.Legs.Add(leg);
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            jarvis.Legs.Add(leg);
                        }
                        break;
                    case "Head":

                        if(jarvis.Head.EnergyConsumption != 0)
                        {
                            if (jarvis.Head.EnergyConsumption > energyConsumption)
                            {
                                jarvis.Head.EnergyConsumption = energyConsumption;
                                jarvis.Head.IQ = int.Parse(firstProperty);
                                jarvis.Head.SkinMaterial = secondProperty;
                            }
                            break;
                        }
                        else
                        {
                            jarvis.Head.EnergyConsumption = energyConsumption;
                            jarvis.Head.IQ = int.Parse(firstProperty);
                            jarvis.Head.SkinMaterial = secondProperty;
                        }
                        break;
                    case "Torso":
                        Torso torso = new Torso();
                        torso.EnergyConsumption = energyConsumption;
                        torso.ProcessorSize = double.Parse(firstProperty);
                        torso.HousingMaterial = secondProperty;

                        jarvis.Torso = torso;

                        if(jarvis.Torso.EnergyConsumption > torso.EnergyConsumption)
                        {
                            jarvis.Torso = torso;
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            return jarvis;
        }
    }
}
