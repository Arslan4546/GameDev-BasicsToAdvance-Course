using UnityEngine;
using UnityEngine.UI;

public class SwitchPanel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // References to the panels
    public GameObject panel1;
    public GameObject panel2;

    // References to the buttons
    public Button exitButton;
    public Button yesButton;
    public Button noButton;

    void Start()
    {
        // Add listeners to the buttons
        exitButton.onClick.AddListener(SwitchToPanel2);
        yesButton.onClick.AddListener(YesAction);
        noButton.onClick.AddListener(SwitchToPanel1);

        // Ensure only Panel 1 is active at the start
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    // Switch to Panel 2 when Exit button is clicked
    void SwitchToPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    // Switch back to Panel 1 when No button is clicked
    void SwitchToPanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    // Action for Yes button (do nothing in this case)
    void YesAction()
    {
        Debug.Log("Yes clicked: Doing nothing.");
    }
}
