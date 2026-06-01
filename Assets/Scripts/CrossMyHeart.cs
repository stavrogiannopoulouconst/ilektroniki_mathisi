using UnityEngine;
using TMPro;

public class CrossMyHeart : MonoBehaviour
{
    public TMP_Text messageText;

    [TextArea]
    public string message;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageText.text = message;
            messageText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            messageText.gameObject.SetActive(false);
        }
    }
}