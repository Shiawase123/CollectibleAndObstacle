using UnityEngine;

public class spinOrigin : MonoBehaviour
{
    public float spinDegreePerSec;
    public int direction;
    public Vector3 spinAxis;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction *= -1;
        }

        transform.Rotate(spinAxis.normalized,
            spinDegreePerSec * direction * Time.deltaTime,
            Space.Self);
    }
}