using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    //here i tell the game manager to take the complete level ui i made and enable it on a completed level
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
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
