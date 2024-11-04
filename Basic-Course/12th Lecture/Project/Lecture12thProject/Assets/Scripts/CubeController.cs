using System.Collections;
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
        //CubeFunction(cubePosition, cubeScale, cubeRotation);
        //print(Health(2));

        //if (this.transform.GetComponent<CubeController>() != null)
        //{
        //    print("Script Attached! ");
        //}
        //else {
        //    print("Script Not Attached! ");
        //}

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }


    //// creating own parameterize fucntion 
    //void CubeFunction(Vector3 postition, Vector3 scale,Vector3 rotation) {
    //    this.transform.position = new Vector3(postition.x, postition.y, postition.z);
    //    this.transform.localScale = new Vector3(scale.x, scale.y, scale.z);
    //    this.transform.rotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);

    //    print(LayerMask.LayerToName(mLayer));
    }

    // return type fucntion 
    //int Health(int health) {

    //    int temp = health * 2;
    //    return temp;
    //}

    //// method overloading 

    //void Sum(int a, int b)
    //{

    //}

    //void Sum(int a, int b, int c)
    //{


    //}


 
