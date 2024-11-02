using UnityEngine;

public class CubeController : MonoBehaviour
{

    public Vector3 cubePosition;
    public Vector3 cubeScale;
    public Vector3 cubeRotation;
    public int mLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        this.transform.position = new Vector3(cubePosition.x, cubePosition.y, cubePosition.z);
        this.transform.localScale = new Vector3(cubeScale.x, cubeScale.y, cubeScale.z);
        this.transform.rotation = Quaternion.Euler(cubeRotation.x, cubeRotation.y, cubeRotation.z);
        print(LayerMask.LayerToName(mLayer));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
