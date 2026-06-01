using UnityEngine;

public class DoorMessage : MonoBehaviour
{
    public GameObject message;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            message.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            message.SetActive(false);
        }
    }
}