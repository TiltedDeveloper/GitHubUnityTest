using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourchanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sphere;
    public Material red;
    public Material green;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            sphere.GetComponent<MeshRenderer>().material = red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            sphere.GetComponent<MeshRenderer>().material = green;
        }
    }
}
