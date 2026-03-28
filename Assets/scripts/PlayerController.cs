using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("COLLISION DETECTED with: " + other.gameObject.name);

        MovingObject movingObj = other.GetComponent<MovingObject>();

        if (movingObj != null)
        {
            if (movingObj.isCollectible)
            {
                GameManager.Instance.AddScore(movingObj.pointValue);
                Destroy(other.gameObject);
                Debug.Log("Collected! Score: " + GameManager.Instance.score);
            }
            else
            {
                GameManager.Instance.GameOver();
                Debug.Log("Hit obstacle!");
            }
        }
        else
        {
            Debug.Log("No MovingObject component found on: " + other.gameObject.name);
        }
    }
}