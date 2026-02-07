using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management  

public class ResetOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object has collided with a specific tag or object  
        if (collision.gameObject.CompareTag("Untagged"))
        {
            // Reload the current scene  
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}