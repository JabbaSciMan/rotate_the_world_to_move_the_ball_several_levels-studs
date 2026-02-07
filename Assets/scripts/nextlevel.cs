using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnCollision : MonoBehaviour
{
    public string sceneName; // Name of the scene to load  

    void OnTriggerEnter2D(Collider2D other)
    {
        // Change to the specified scene when a collision occurs  
        SceneManager.LoadScene(sceneName);
    }
}
