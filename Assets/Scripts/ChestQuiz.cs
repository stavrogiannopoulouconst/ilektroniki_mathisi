using UnityEngine;
using TMPro;

public class ChestQuiz : MonoBehaviour
{
    public GameObject quizPanel;
    public TMP_InputField answerInput;

    private bool playerNear = false;

    void Update()
    {
        if(playerNear && Input.GetKeyDown(KeyCode.E))
        {
            quizPanel.SetActive(true);
        }
    }

    public void CheckAnswer()
    {
        if(answerInput.text == "1010")
        {
            Debug.Log("Correct!");
            quizPanel.SetActive(false);
        }
        else
        {
            Debug.Log("Wrong!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}