using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    /// <summary>
    /// If player hits the trigger the gamemanager is set to complete level. The trigger is set on an invisible cube that
    /// acts as the finish.
    /// </summary>
    

    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        Debug.Log("Hallo dit is de complete level");
    }
}
