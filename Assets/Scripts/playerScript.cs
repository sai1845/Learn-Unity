using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    float xAxis;
    float yAxis;
    float zAxis;
    public float  playerSpeed = 5f;
    public float moveUP = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        yAxis = moveUP * Input.GetAxis("Jump") * Time.deltaTime;
        zAxis = playerSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xAxis, yAxis, zAxis);
    }
}
