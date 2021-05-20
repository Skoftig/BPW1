using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class IO : MonoBehaviour
{
    [HideInInspector]
    public List<int> highscore = new List<int>();
    private string filePath = "Assets/Highscore.txt";


    /// <summary>
    /// this function writes the game highscore.
    /// </summary>
    public void WriteHighScore()
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            for (int i = 0; i < highscore.Count; i++)
            {
                sw.WriteLine(highscore[i].ToString());
            }

        }

        AssetDatabase.Refresh();
    }

    public List<int> ReadHighScore()
    {
        string line = "";
        highscore = new List<int>();

        using (StreamReader sr = new StreamReader(filePath))
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
