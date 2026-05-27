using UnityEngine;
using TMPro;

public class QuizObject : MonoBehaviour
{
    public GameObject quizPanel;
    public TMP_Text questionText;
    public TMP_Text resultText; // Correct / Wrong text
    public TMP_InputField answerInput;

    [TextArea]
    public string question;

    public string correctAnswer;

    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            questionText.text = question;

            // clear old result text
            resultText.text = "";

            // clear input field
            answerInput.text = "";

            quizPanel.SetActive(true);
        }
    }

    public void CheckAnswer()
    {
        if (answerInput.text.Trim() == correctAnswer)
        {
            resultText.text = "Correct!";

            // clear text field
            answerInput.text = "";

            // close panel after a moment
            Invoke(nameof(CloseQuiz), 1.5f);
        }
        else
        {
            resultText.text = "Wrong!";
            
            // clear text field
            answerInput.text = "";
        }
    }

    void CloseQuiz()
    {
        quizPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
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