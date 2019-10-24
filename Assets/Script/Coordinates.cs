using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coordinates : MonoBehaviour
{

    public Text c;
    public string pos;
    public Transform player;


    // Update is called once per frame
    void Update()
    {


        pos = player.position.ToString();
        c.text = pos;
    }
}
