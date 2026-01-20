using TMPro;
using UnityEngine;

public class TriggerText : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mysz"))
        {
            text.gameObject.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Mysz"))
        {
            text.gameObject.SetActive(false);
        }

    }
}
