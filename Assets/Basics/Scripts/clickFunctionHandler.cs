using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickFunctionHandler : MonoBehaviour
{
    List<Transform> prefabs = new List<Transform>();
    public Transform House1;
    public Transform House2;
    public Transform House3;

    Vector3 position;

    System.Random rnd = new System.Random();

    public clickFunctionHandler()
    {
    }
    public void Tester(string input)
    {
        prefabs.Add(House1);
        prefabs.Add(House2);
        prefabs.Add(House3);
        float x = rnd.Next(-20, 20) * 0.32f;
        float y = rnd.Next(-15, 15) * 0.32f;
        position = new Vector3(x, y, 1f);
        Instantiate(prefabs[2], position, Quaternion.identity);
        Debug.Log(input + " x = " + x + ", y = " + y);
    }
}
