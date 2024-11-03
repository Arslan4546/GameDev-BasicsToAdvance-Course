using UnityEngine;

public class ParentClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // This Start method is here just for demonstration.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Change access modifier to protected or public so it can be accessed in the child class
    protected void PrintingMyName(string name) 
    {
        print(name);
    }
}
