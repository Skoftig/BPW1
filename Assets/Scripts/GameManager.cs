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


    //here i tell the game manager to take the complete level ui i made and enable it on a completed level
    //I also add the highscore to the list using the IO.AddToList, then i save it to the list using the WriteHighScore
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        //StartCoroutine(IO.AddToList((int)finalScore.totalPoints));
        //StartCoroutine(ShowHighScore());       
    }

    public IEnumerator ShowHighScore()
    {
        yield return new WaitForSeconds(1);
        scoreText.text = IO.GetScores();
        
        //completeLevelUI.SetActive(true);
        //Debug.Break();

    }

    //here i tell the game manager to invoke the restart with a slight delay added to give the player time to see the game over.
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }

    //here i tell the game manager to restart the current level after a game over
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
