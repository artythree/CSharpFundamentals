using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    public Class1()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void Drosfnar()
    {
        int lives = 3;
        int livesgained = 0;
        int points = 5000;
        int huntercount = 1;
        switch (gameSequence)
        {
            case points == 10000:
                lives += 1;
                livesgained += 1;
                break;
            case lives == 0:
                Console.WriteLine($"Game over fook off poser. you had {points} points.");
                return null;
            case "bird":
                points += 10;
                break;
            case "crestedibis":
                points += 100;
                break;
            case "greatkiskudee":
                points += 300;
                break;
            case "redcrossbill":
                points += 500;
                break;
            case "redneckedphalarope":
                points += 700;
                break;
            case "eveninggrosbeak":
                points += 1000;
                break;
            case "greaterprairiechicken":
                points += 2000;
                break;
            case "icelandgull":
                points += 3000;
                break;
            case "orangebelliedparrot":
                points += 5000;
                break;
            case "invinciblebirdhunter":
                lives -= 1;
                break;
            case "vulnerablebirdhunter":
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

        }

    }







//    Bird: 10 points each
//Crested Ibis: 100 points
//Great Kiskudee: 300 points
//Red Crossbill: 500 points
//Red-necked Phalarope: 700 points
//Evening Grosbeak: 1000 points
//Greater Prairie Chicken: 2000 points
//Iceland Gull: 3000 points
//Orange-Bellied Parrot: 5000 points
//Vulnerable Bird Hunters: 
//#1 in succession: 200 points 
//#2 in succession: 400 points
//#3 in succession: 800 points
//#4 in succession: 1600 points  
}


