using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Beginning : MonoBehaviour
{
    public string nextScene;
    public void StartGameButton()
    {
        SceneManager.LoadScene(nextScene);
    }
}