using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public int mode = 1;
    public Vector3 offset;
    public GameObject target;


    void Update()
    {
        if (mode==1)
        {
            transform.position = player.position;
        }
        else
        {
            transform.position = player.position + offset;
            //transform.rotation = Quaternion.Euler(0, 10, 0);
         


            transform.LookAt(target.transform);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (mode == 1)
            {
                mode = 2;
            }
            else
            {
                mode = 1;
            }
        }
    }

}
