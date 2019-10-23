using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public int[] x = new int[32];
    public int[] y = new int[32];
    public GameObject block;

    void Start()
    {
        for (int i = 0; i < x.Length; i++)
        {
            x[i] = i + 1;
            Debug.Log(x[i]);
            Instantiate(block, new Vector3(x[i], 0, 0), Quaternion.identity);
            for (int p = 0; p < y.Length; p++)
            {
                Instantiate(block, new Vector3(x[i], 0, p + 1), Quaternion.identity);
            }
        }
    }
}
