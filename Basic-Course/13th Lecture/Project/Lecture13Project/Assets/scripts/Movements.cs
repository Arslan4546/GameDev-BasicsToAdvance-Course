using UnityEngine;

public class Movements : MonoBehaviour
{
    public float move = 10f;
    public float rotate = 50f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Input.GetKey(KeyCode.UpArrow)) { 
        transform.Translate(Vector3.forward*move* Time.deltaTime);
        
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
