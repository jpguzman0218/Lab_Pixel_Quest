using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{

    string hello = "Hello ";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string world = "World";
        Debug.Log(hello + world);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.005f, 0, 0);
        
    }
}
