using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    
    [SerializeField] float player_rotation = 25f;

    void Start()
    {
        
    }

    
    void Update()
    {
        
        float yAxis = player_rotation * Time.deltaTime;
        transform.Rotate(0,yAxis,0);
    }
}
