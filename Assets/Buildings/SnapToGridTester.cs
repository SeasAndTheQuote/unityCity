using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SnapToGridTester : MonoBehaviour
{

    public float cell_size = 0.64f;
    private float x, y, z;

    void Start()
    {
        x = 0f;
        y = 0f;
        z = 0f;
    }

    void Update()
    {
        x = Mathf.Round(transform.position.x * cell_size) / cell_size;
        y = Mathf.Round(transform.position.y * (cell_size * 0.5f)) / (cell_size * 0.5f);
        z = transform.position.y / 3;
        /*
        if ((y % 0.64f == 0f && x % 1.28f != 0) || (y % 0.64f != 0f && x % 1.28f == 0)) 
            x += 0.64f;
            */

        float xModulo = Mathf.Round(Mathf.Repeat(x, (2 * cell_size)) * 100f) / 100f;
        float yModulo = Mathf.Round(Mathf.Repeat(y, cell_size) * 100f) / 100f;
        
        Debug.Log("rounded Log 1: cords: x=" + x + ", y=" + y + ", modula x i y: " + xModulo + ", " + yModulo);
        /*
        if ((x % (2 * cell_size) == 0) && (y % cell_size != 0))
            x += cell_size;

        if ((x % (2 * cell_size) != 0) && (y % cell_size == 0))
            x += cell_size;*/

        if (xModulo == 0 && yModulo != 0)
            x += cell_size;
        
        if (xModulo != 0 && yModulo == 0)
            x += cell_size;



        Debug.Log("Log 2: cords: x=" + x + ", y=" + y);

       transform.position = new Vector3(x, y, z);
        
    }

}