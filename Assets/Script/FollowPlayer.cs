using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public int mode = 1;
    public Vector3 offset;


    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            Debug.Log(1);
            if (mode == 1)
            {
                mode = 2;
            }
            else
            {
                mode = 1;
            }
          

        }
        if (mode == 1)
        {
            transform.position = player.position;
        }
        if (mode == 2)
        {
            transform.position = player.position + offset;
        }

    }

}
