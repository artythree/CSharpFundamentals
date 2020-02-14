using System;

[TestClass]
public class KomodoInsuranceTest
{
    [TestMethod]
    public void KomodoInsurance()
    {


        string[] birdarray = { "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "InvincibleBirdHunter", "EveningGrosbeak", "GreaterPrairieChicken", "VulnerableBirdHunter", "VulnerableBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "IcelandGull", "CrestedIbis", "GreatKiskudee", "InvincibleBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Bird", "Orange", "RedneckedPhalarope", "InvincibleBirdHunter", "VulnerableBirdHunter", "OrangebelliedParrot", "InvincibleBirdHunter", "Bird", "Bird", "Bird", "Bird", "Bird", "VulnerableBirdHunter" };
        foreach(string bird in birdarray)
        {
            Drosfnar(bird);
        }

    }
    public void Drosfnar(string[] birdarray)
        {
            int lives = 3;
            int livesgained = 0;
            int points = 5000;
            int huntercount = 1;
            switch (birdarray)
            {
                case points == 10000:
                    lives += 1;
                    livesgained += 1;
                    break;
                case lives == 0:
                    Console.WriteLine($"Game over fook off poser. you had {points} points and gained {livesgained} lives.");
                    return null;
                case "Bird":
                    points += 10;
                    break;
                case "CrestedIbis":
                    points += 100;
                    break;
                case "GreatKiskudee":
                    points += 300;
                    break;
                case "RedCrossBill":
                    points += 500;
                    break;
                case "RedNeckedPhalarope":
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
                case "OrangeBelliedParrot":
                    points += 5000;
                    break;
                case "InvincibleBirdHunter":
                    lives -= 1;
                    break;
                case "VulnerableBirdHunter":
                    if (huntercount < 5)
                    {
                        points += (200 * huntercount);
                        huntercount *= 2;
                        break;
                    }
                    else
                    {
                        points += (200 * huntercount);
                        break;
                    }
                default:
                    break;

            }
        }
}