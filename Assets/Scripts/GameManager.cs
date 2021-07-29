using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public IO IO;
    public Score finalScore;
    public Text scoreText;


    private void Start()
    {
        IO.ReadHighScore();
    }

    /// <summary>
    /// here i tell the game manager to take the complete level ui i made and enable it on a completed level
    /// I also add the highscore to the list using the IO.AddToList, then i save it to the list using the WriteHighScore
    /// </summary>

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        StartCoroutine(IO.AddToList((int)finalScore.totalPoints));
        StartCoroutine(ShowHighScore());

    }


    /// <summary>
    /// Here I set the Highscore UI to be that of the IO.GetScores. IEnumerator is an asynchronised function.
    /// WaitForSeconds is used to give the player some delay time to actually read the scores before the nect level is loaded.
    /// Debug.Break is used to pause the game when the highscore UI got displayed, this was used during the testing of this code.
    /// </summary>

    public IEnumerator ShowHighScore()
    {
        yield return new WaitForSeconds(1);
        scoreText.text = IO.GetScores();

    }


    /// <summary>
    /// In EndGame I tell the game manager to invoke the restart with a slight delay added to give the player 
    /// time to see the game over.
    /// In Restart the game manager reloads the current level after a game over.
    /// </summary>

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
