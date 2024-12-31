using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject exitPanel,menuPanel,levelSelectionPanel;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exitBtnClick()
    {
        exitPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void playBtnClick()
    {
        levelSelectionPanel.SetActive(true);
        menuPanel.SetActive(false);

    }

    public void noBtnClick()
    {
        exitPanel.SetActive(false);
        menuPanel.SetActive(true);
    }
    public void yesBtnClick()
    {
      
    }
}
