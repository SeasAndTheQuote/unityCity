using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SnapToGrid : MonoBehaviour
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
        x = Mathf.Round(transform.position.x / cell_size) * cell_size;
        y = Mathf.Round(transform.position.y / (cell_size * 0.5f)) * cell_size * 0.5f;
        z = transform.position.y / 3;

            /*
        if ((x % (2 * cell_size) == 0) && (y % cell_size != 0))
            x += cell_size;

        if ((x % (2 * cell_size) != 0) && (y % cell_size == 0))
            x += cell_size;*/
        
        transform.position = new Vector3(x, y, z);
        

    }

}