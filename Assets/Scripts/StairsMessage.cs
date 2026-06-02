using UnityEngine;

public class DoorMessage : MonoBehaviour
{
    public GameObject message;

    private void Start()
    {
        if (message != null)
            message.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && message != null)
        {
            message.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && message != null)
        {
            message.SetActive(false);
        }
    }
}