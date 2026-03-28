using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float moveSpeed = 3f;
    public bool isCollectible = true;
    public int pointValue = 10;

    void Start()
    {
        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
        {
            Debug.Log(gameObject.name + " - Is Trigger: " + col.isTrigger);
        }
        else
        {
            Debug.LogError(gameObject.name + " has NO COLLIDER!");
        }
    }

    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        if (transform.position.x > 12f)
        {
            Destroy(gameObject);
        }
    }
}