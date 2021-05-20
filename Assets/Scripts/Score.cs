
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public float scorePoints = 0;
    public float playerPoints = 0;
    public float totalPoints = 0;

    // Update is called once per frame
    void Update()
    {
        playerPoints = player.position.z;
        totalPoints = (playerPoints + scorePoints);

        scoreText.text = totalPoints.ToString("0");
    }
}
 // player points is gelijk aan player Z positie, die wordt opgeteld bij de scorePoints die de pickup bijhoud. 
 //deze vormen samen de totalPoints, die word weergegeven in scoreText. 