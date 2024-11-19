using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("nextScene", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
