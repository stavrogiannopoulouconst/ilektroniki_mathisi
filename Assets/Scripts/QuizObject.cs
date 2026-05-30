using UnityEngine;
using TMPro;

public class QuizObject : MonoBehaviour
{
    public GameObject quizPanel;
    public TMP_Text questionText;
    public TMP_Text resultText;
    public TMP_InputField answerInput;

    [TextArea]
    public string question;

    public string correctAnswer;

    private bool playerNear = false;
    private PlayerMovement playerMovement;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            questionText.text = question;
            resultText.text = "";
            answerInput.text = "";

            quizPanel.SetActive(true);

            // stop player movement
            if (playerMovement != null)
            {
                playerMovement.enabled = false;
            }
        }
    }

    public void CheckAnswer()
    {
        if (answerInput.text.Trim() == correctAnswer)
        {
            resultText.text = "Correct!";
            answerInput.text = "";

            Invoke(nameof(CloseQuiz), 1.5f);
        }
        else
        {
            resultText.text = "Wrong!";
            answerInput.text = "";
        }
    }

    void CloseQuiz()
    {
        quizPanel.SetActive(false);

        // enable movement again
        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            playerMovement = other.GetComponent<PlayerMovement>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}