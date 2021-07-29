
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Score pickupScore;
    public PlayerMovement movement;
    public float pickupValue = 1000;

    private IO highscoreUpdate = new IO();


    /// <summary>
    /// In OnCollisionEnter i check if the player has collider with any obstacles that have the 'Obstacle' tag.
    /// During testing, I used the Debug.Log(collisionInfo.collider.name) to check what objects the player character collided with
    /// The pickup value is a public float to make it easily editable in the Unity Editor
    /// </summary>

    void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //disables players movement when hitting an obstacle

            //highscoreUpdate.highscore.Add((int)pickupScore.totalPoints);
            //highscoreUpdate.AddToList((int)pickupScore.totalPoints);
            //highscoreUpdate.WriteHighScore();

            FindObjectOfType<GameManager>().EndGame();


        }


    }

    public void AddScore(int points)
    {
        pickupScore.scorePoints += points; //pickupValue;
    }

    void OnTriggerEnter(Collider colliderInfo)
    {

        Debug.Log(colliderInfo.name);

        if (colliderInfo.tag == "Pickup")
        {
            colliderInfo.gameObject.SetActive(false);

            //pickupScore.scoreText.text = "haha";

            pickupScore.scorePoints += pickupValue;
            // referentie gemaat naar mijn Score script, die heb ik pickupScore genoemd en is nu 1000. 
            //pickupScore word opgeteld bij scorePoints



        }
    }

}
