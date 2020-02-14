using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_challenges.BIRD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            {
                int lives = 3;
                int livesgained = 0;
                int points = 5000;
                int huntercount = 0;
                int hunterval = 1;
                int shittalkcount = 0;

                
                string commandText = File.ReadAllText(@"D:\1150projects\1150projects\HTMLCSSGoldBadge\C#stuff\game-sequence.txt");
                List<string> command = commandText.Split(',').ToList();


                foreach (string bird in command)

                {

                    if (points >= 10000 && livesgained == 0)
                    {
                        lives += 1;
                        livesgained += 1;
                    }

                    if (lives == 0 && shittalkcount == 0)
                    {
                        Console.WriteLine($"Game over fook off poser. you had {points} points and gained {livesgained} lives.");
                        shittalkcount += 1;
                    }
                    

                    switch (bird)
                    {
                        case "Bird":
                            points += 10;
                            break;
                        case "CrestedIbis":
                            points += 100;
                            break;
                        case "GreatKiskudee":
                            points += 300;
                            break;
                        case "RedCrossbill":
                            points += 500;
                            break;
                        case "Red-neckedPhalarope":
                            points += 700;
                            break;
                        case "EveningGrosbeak":
                            points += 1000;
                            break;
                        case "GreaterPrairieChicken":
                            points += 2000;
                            break;
                        case "IcelandGull":
                            points += 3000;
                            break;
                        case "Orange-belliedParrot":
                            points += 5000;
                            break;
                        case "InvincibleBirdHunter":
                            lives -= 1;
                            break;
                        case "VulnerableBirdHunter":
                            if (huntercount < 5)
                            {
                                points += (200 * hunterval);
                                huntercount += 1;
                                hunterval *= 2;
                                break;
                            }
                            else
                            {
                                points += (200 * hunterval);
                                break;
                            }
                        default:
                            break;
                    }
                    Console.WriteLine($"{lives}             {points}                {bird}");
                }
            }
        }
    }
}

