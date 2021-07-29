
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public float scorePoints = 0;
    public float playerPoints = 0;
    public float totalPoints = 0;



    /// <summary>
    /// Player points is equal to the players position on the z-axis. These points are added to the scorePoints
    /// that keep track of the pickup value. Together these form the totalPoints, which are displayed in the scoreText
    /// of the level end UI
    /// </summary>
    void Update()
    {
        playerPoints = player.position.z;
        totalPoints = (playerPoints + scorePoints);

        scoreText.text = totalPoints.ToString("0");
    }
}