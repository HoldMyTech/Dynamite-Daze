using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float gameDuration = 30f; // 30 seconds
    private float timer;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        timer = gameDuration;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            EndGame();
        }
    }
    
    void EndGame()
    {
        // Load your end screen scene
        SceneManager.LoadScene("End");
    }
}