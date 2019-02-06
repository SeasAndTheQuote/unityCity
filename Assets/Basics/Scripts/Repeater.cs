using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Repeater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("ping", 1, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
            
        
    }

    void ping()
    {
        Debug.Log("test");
    }
}
