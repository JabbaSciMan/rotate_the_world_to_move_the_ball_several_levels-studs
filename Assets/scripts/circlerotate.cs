using UnityEngine;

public class SpinWithArrows : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of rotation  

    void Update()
    {
        float rotation = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotation = rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }

        transform.Rotate(0, 0, rotation);
    }
}