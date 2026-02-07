using UnityEngine;

public class reverseSpinWithArrows : MonoBehaviour
{
    public float rotationSpeed = 150f; // Speed of rotation  

    void Update()
    {
        float rotation = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotation = -rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rotation = rotationSpeed * Time.deltaTime;
        }

        transform.Rotate(0, 0, rotation);
    }
}