using UnityEngine;

public class Gem : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip gemSFX;
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
    }

    public void OnGemCollected()
    {
        audioSource.clip = gemSFX;
        audioSource.Play();
        float testLength = gemSFX.length;
        Destroy(gameObject, testLength);
    }
}
