using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour
{
    int hitvalue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hitvalue++;
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("You Hit the wall " + hitvalue + "times");
    }
}
