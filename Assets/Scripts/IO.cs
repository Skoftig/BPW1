using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class IO : MonoBehaviour
{
    [HideInInspector]
    public List<int> highscore = new List<int>();
    private string filePath = "Assets/Resources/Highscore.txt";
    public Score totalPoints;


    /// <summary>
    /// This script is used for a simple highscore that shows the players highscores during the current session.
    /// I make a list to store these highscores in.
    /// 
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


    }

    public IEnumerator AddToList(int value)
    {
        highscore.Add(value);
        yield return new WaitForSeconds(1);

        WriteHighScore();

        yield return new WaitForSeconds(1);

    }

    /// <summary>
    /// Here i tell the list to be organised and add +1 because the list begins at 0.
    /// </summary>
    /// <returns></returns>

    public string GetScores()
    {
        ReadHighScore();
        string Temp = string.Empty;

        for (int i = 0; i < highscore.Count; i++)
        {
            Temp += (i + 1).ToString() + ". " + highscore[i] + "\n";
        }

        return Temp;
    }

    /// <summary>
    /// Here the function checks if the highscore list exists, and if true, it uses the Parse to convert the string back to numbers
    /// these numbers are added to the list sorted by value from highest to lowest.
    /// </summary>

    public void ReadHighScore()
    {

        highscore.Clear();

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
        highscore.Reverse();

    }
}
