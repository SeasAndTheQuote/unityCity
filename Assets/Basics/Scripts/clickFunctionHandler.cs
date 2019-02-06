using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFunctionHandler : MonoBehaviour
{

    Vector3 position;

    List<Transform> prefabs = new List<Transform>();
    public Transform House1;
    public Transform House2;
    public Transform House3;

    System.Random rnd = new System.Random();

    public ClickFunctionHandler()
    {

    }

    private void Start()
    {
        //House1 = GameObject.Find("Prefabs/House1").transform;
        //House2 = GameObject.Find("Prefabs/House2").transform;
        //House3 = GameObject.Find("Prefabs/House3").transform;
    }

    public void Tester(string input)
    {
        prefabs.Add(House1);
        prefabs.Add(House2);
        prefabs.Add(House3);
        float x = rnd.Next(-20, 20) * 0.32f;
        float y = rnd.Next(-15, 15) * 0.32f;
        position = new Vector3(x, y, 1f);
        Instantiate(prefabs[rnd.Next(0,2)], position, Quaternion.identity);
        Debug.Log(input + " x = " + x + ", y = " + y);
    }
}
