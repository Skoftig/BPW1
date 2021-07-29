using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Script for loading the next level by checking the current active scene and adding 1 to make sure the next scene
/// in the scenemanager is loaded.
/// </summary>

public class LevelComplete : MonoBehaviour
{
    //here i tell the game to load the next scene based on the current active scene + 1
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
