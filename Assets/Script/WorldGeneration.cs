using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{

    public int[] x = new int[64];
    public int[] y = new int[64];
    public GameObject block;

    void Start()
    {
        for (int i = 0; i < x.Length; i++)
        {
            for (int m = 0; m < y.Length; m++){
                x[i] = i + 1;
                y[m] = m + 1;
                Instantiate(block, new Vector3(x[i], 0, y[m]), Quaternion.identity);
            }
            /*x[i] = i + 1;
            Instantiate(block, new Vector3(x[i], 0, 0), Quaternion.identity);
            /*for (int p = 0; p < y.Length; p++)
            {
                Instantiate(block, new Vector3(x[i], 0, p + 1), Quaternion.identity);
            }*/
        }
    }
}
