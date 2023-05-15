using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorrer : MonoBehaviour
{
    float hit = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Untagged")
        {
            hit++;
            Debug.Log("yot Hit a wall " + hit);
            gameObject.tag = "Hit";
        }
        else
        {
            hit = hit;
        }


    }

    

}
