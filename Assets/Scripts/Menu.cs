using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    //here i tell the menu button to start scene 01
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
