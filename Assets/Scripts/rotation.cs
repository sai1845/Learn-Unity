using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    
    [SerializeField] float player_rotation = 25f;

    void Start()
    {
        greeting();
    }

    
    void Update()
    {
        
        float yAxis = player_rotation * Time.deltaTime;
        transform.Rotate(0,yAxis,0);
    }

    void greeting()
    {
        Debug.Log("Welcome to the Game world");
        Debug.Log("Use ASDWD Keys to Move the player");
        Debug.Log("Don't Hit the walls");
    }
}
