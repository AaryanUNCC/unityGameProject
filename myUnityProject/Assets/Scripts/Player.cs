
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("onCollision" + collision.gameObject.name);
        if (collision.gameObject.tag.Equals("Collectible"))
        {
            collision.gameObject.GetComponent<Gem>().OnGemCollected();
            gameManager.OnGemCollected();
        }
        else if (collision.gameObject.tag.Equals("Portal"))
        {
            gameManager.Save();
            SceneManager.LoadScene("Menu");
        }
    }
}
