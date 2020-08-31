using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Scoreboard : MonoBehaviour
{
    public GameObject Scores;
    private TextMeshProUGUI text;

  //  private string myFile;
    private string newFile = @"Assets/NewHighScore.txt";
    private string file = @"Assets/HighScore.txt";
    private string backFile = @"Assets/BackupHighScore.txt";

    private string myName = "Nova";//Player.myName;
    private int myScore = 100;//GoldNumber.coinAmount;
    // public Object myFile;

    // Start is called before the first frame update
    void Start()
    {
        text = Scores.GetComponent<TextMeshProUGUI>();

        if (File.Exists(newFile))
        {
            File.Delete(newFile);
        }
        File.Create(newFile);
    }

    // Update is called once per frame
    //    void Update()
    //  {

    // }

    public void UpdateScores()
    {
        if (File.Exists(file))
        {
            // using (StreamReader sr = File.OpenText(file))
            using (StreamReader sr = new StreamReader(file))
            {
            // using (StreamWriter sw = File.CreateText(newFile))
                using (StreamWriter sw = new StreamWriter(newFile))
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

                       // sw.WriteLine(currentName + " " + currentScore);
                       // iter++; 
                    }


                   // sw.WriteLine("Hello World");
                    sw.Flush();
                    sw.Close();
                    sr.Close();


                    if (File.Exists(backFile))
                    {
                        File.Delete(backFile);
                    }
                    File.Move(file, backFile);
                    File.Move(newFile, file);

                    // File.Create(backFile);
                }
            }
           // myFile = file;
        }

        string str = "";
        using (StreamReader sr = new StreamReader(file))
        {
            while (sr.Peek() >= 0)
            {
                str += sr.ReadLine() + "\n";
            }
        }
        text.text = str;
    }
}
