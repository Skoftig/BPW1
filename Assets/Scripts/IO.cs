using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class IO : MonoBehaviour
{
    public List<int> highscore = new List<int>();

    /// <summary>
    /// this function writes the game highscore.
    /// </summary>
    public void WriteHighScore()
    {
        using (StreamWriter sw = new StreamWriter("Highscore.txt"))
        {
            for (int i = 0; i < highscore.Count; i++)
            {
                sw.WriteLine(highscore[i].ToString());
            }
        }
    }

    public List<int> ReadHighScore()
    {
        string line = "";
        highscore = new List<int>();

        using (StreamReader sr = new StreamReader("Highscore.txt"))
        {
            while ((line = sr.ReadLine()) != null)
            {
                Debug.Log(line);

                int result = int.Parse(line);
                Debug.Log(result);
                highscore.Add(result);

            }
        }

                return highscore;
    }
}
