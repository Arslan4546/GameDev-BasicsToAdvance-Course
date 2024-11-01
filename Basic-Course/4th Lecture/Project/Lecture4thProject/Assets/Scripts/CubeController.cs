using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = new Vector3(12, 12, 0);
        this.transform.localScale = new Vector3(10, 10, 10);
        this.transform.rotation = Quaternion.Euler(0, 10, 10);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
