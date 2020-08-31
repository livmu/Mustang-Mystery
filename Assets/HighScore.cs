using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assets
{
    class HighScore
    {
        // instance variables
        // needs array for list of high scores
        // private String list; // to view list of Top 5 highscores
        private int myScore;
        private String myName;
        private string myFile;

        // constructor
        public HighScore(String name, int score)
        {
            myScore = score;
            myName = name;

            string newFile = @"D:\Wumpus\NewHighScore.txt";
            if (!File.Exists(newFile))
            {
                File.Delete(newFile);
            }
            //File.Create(newFile);

            string file = @"D:\Wumpus\HighScore.txt";
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

                            /*  names[iter] = currentName;
                              for (int i = 0; i < names.Length; i++)
                              {
                                  if (myName == names[i])
                                  {
                                      newPlayer = false;
                                  }
                              } */

                            if (myScore >= currentScore && count && newPlayer)
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

                        string backFile = @"D:\Wumpus\BackupHighScore.txt";
                        if (File.Exists(backFile))
                        {
                            File.Delete(backFile);
                        }
                        // File.Create(backFile);


                        File.Move(file, backFile);
                        File.Move(newFile, file);
                    }
                }
                myFile = file;
            }
        }

        // mutators

        // accessors
        /* public int[] GetNewList(int currentscore)
         {
             int[] NewList = { 120, 109, 94, 87, 86, 0 };
             NewList[5] = currentscore;
             return NewList;
         } */

        public String GetHighScores()
        {
            String str = "";
            using (StreamReader sr = File.OpenText(myFile))
            {
                while (sr.Peek() >= 0)
                {
                    str += sr.ReadLine() + "\n";
                }
            }
            return str;
        }
    }
}
