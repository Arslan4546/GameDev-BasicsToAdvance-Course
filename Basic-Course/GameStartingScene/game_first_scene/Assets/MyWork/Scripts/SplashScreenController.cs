using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour
{

    public float splashDuration = 5f; // Time in seconds
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("nextScene", splashDuration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void nextScene()
    {
        SceneManager.LoadScene("mainMenueScene");
    }
}
