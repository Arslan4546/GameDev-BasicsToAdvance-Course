using UnityEngine;

public class ChildClass : ParentClass
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Now this works because PrintingMyName is protected in the ParentClass
        PrintingMyName("Arslan");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
