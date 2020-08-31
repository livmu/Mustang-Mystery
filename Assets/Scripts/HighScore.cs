using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class HighScore : MonoBehaviour
{
    // public GameObject myGold;

    // public int myScore;
    // public string myName;
    // public string myFile;

    private Text text;
   // string myName = Player.myName;
   // int myScore = GoldNumber.coinAmount;
   // public Object myFile;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();


       /* ILeaderboard leaderboard = Social.CreateLeaderboard();
        leaderboard.id = "Leaderboard012";
        leaderboard.LoadScores(result =>
        {
            Debug.Log("Received  " + leaderboard.scores.Length + " scores");
            foreach (IScore score in leaderboard.scores)
                Debug.Log(score);
        }); */

      /*  string newFile = @"Assets/NewHighScore.txt";
        if (!File.Exists(newFile))
        {
            File.Delete(newFile);
        }
        //File.Create(newFile);

        string file = @"Assets/HighScore.txt";
        if (File.Exists(file))
        {
            using (StreamReader sr = File.OpenText(file))
            {
                using (StreamWriter sw = File.CreateText(newFile))
                {
                    bool count = true;
                    int iter = 0;
                    string[] names = new string[5];
                    bool newPlayer = true;

                    while (sr.Peek() >= 0 && iter < 5)
                    {
                        string[] words = sr.ReadLine().Split(' ');
                        string currentName = words[0];
                        int currentScore = int.Parse(words[1]);

                        if (myScore <= currentScore && count && newPlayer)
                        {
                            sw.WriteLine(myName + " " + myScore);
                            count = false;
                            iter++;
                        }

                        if (myName != currentName)
                        {
                            sw.WriteLine(currentName + " " + currentScore);
                            iter++;
                        }
                        else if (myName == currentName && myScore < currentScore)
                        {
                            sw.WriteLine(currentName + " " + currentScore);
                            iter++;
                            newPlayer = false;
                        }
                        else
                        {
                            iter--;
                        }
                    }

                    sw.Flush();
                    sw.Close();
                    sr.Close();

                    string backFile = @"Assets/BackupHighScore.txt";
                    if (File.Exists(backFile))
                    {
                        File.Delete(backFile);
                    }
                    // File.Create(backFile);


                    File.Move(file, backFile);
                    File.Move(newFile, file);
                }
            }
           // myFile = file;
        } */
    }

    /*  public string GetHighScores()
      {
          string str = "";
          using (StreamReader sr = File.OpenText(myFile))
          {
              while (sr.Peek() >= 0)
              {
                  str += sr.ReadLine() + "\n";
              }
          }
          return str;
      } */

    void Update()
    {
        text.text = "Hello";
      //  text.text = "Hello";//myName + " " + myScore;
    }
}
