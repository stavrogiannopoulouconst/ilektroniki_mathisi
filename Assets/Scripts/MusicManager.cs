using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        // Έλεγχος για διπλό MusicManager
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        // Δεν καταστρέφεται όταν αλλάζει scene
        DontDestroyOnLoad(gameObject);
    }
}