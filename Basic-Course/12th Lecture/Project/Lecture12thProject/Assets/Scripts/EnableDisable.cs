using UnityEngine;

public class EnableDisable : MonoBehaviour
{

    // public CubeController cube1;

    public GameObject[] cubes; 

    // Start iscalled once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //cube1 = cube1.GetComponent<CubeController>();
        //cube1.enabled = false;
        //foreach (GameObject i in cubes) { 

        //    i.SetActive(false); 
        //}

        cubes[1].SetActive(false);// idhr poora ka poora game object he off ho jyee ga 
        cubes[1].transform.GetComponent < CubeController >().enabled = false; // or idhr just script ho gee just 
        cubes[2].transform.GetComponent<MeshRenderer>().enabled = false;// ye game object k mesh render ko off kr dy ga 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
