using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Mysz"))
        {
            audioSource.Play();
        }
    }

}
