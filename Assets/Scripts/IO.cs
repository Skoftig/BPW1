using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class IO : MonoBehaviour
{
    [HideInInspector]
    public List<int> highscore = new List<int>();
    public string filePath = "Assets/Resources/Highscore.txt";
    public Score totalPoints;
    




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

    public IEnumerator AddToList(int value)
    {
        highscore.Add(value);
        yield return new WaitForSeconds(1);

        WriteHighScore();

        yield return new WaitForSeconds(1);
        
    }

    public string GetScores()
    {
        string Temp = string.Empty;

        for (int i = 0; i < highscore.Count; i++)
        {
            Temp += (i + 1).ToString() + ". " + highscore[i] + "\n";
        }

        return Temp;
    }

    public void ReadHighScore()
    {
        string line = "";



        if (File.Exists(filePath))
        {

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

    }


    highscore.Sort();

        for (int i = 0; i < highscore.Count; i++)
        {
            Debug.Log(highscore[i]);
        }
        
        highscore.Reverse();

        for (int i = 0; i < highscore.Count; i++)
        {
            Debug.Log(highscore[i]);
        }
    }
}
