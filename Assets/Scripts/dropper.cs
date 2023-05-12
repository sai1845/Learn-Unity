using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 3f;
    public Rigidbody rigidbody;
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        mesh = GetComponent<MeshRenderer>();
        mesh.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time >= waitTime)
        {
            rigidbody.useGravity= true;
            if (Time.time > waitTime + 0.25)
            {
                mesh.enabled = true;
            }
        }
       

    }
}
