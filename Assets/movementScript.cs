using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    [SerializeField]
    private string balls = "balls";
    float jumpForce = 300;
    float walkingForce = 5;
    Rigidbody playerbody;

    // Start is called before the first frame update
    void Start()
    {
        playerbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            playerbody.AddForce(new Vector3(0, jumpForce, 0));
            
            
        }
        if (Input.GetKey("w"))
        {
            playerbody.AddForce(new Vector3(0, 0, walkingForce));
        }

        if (Input.GetKey("s"))
        {
            playerbody.AddForce(new Vector3(0, 0, -walkingForce));
        }

        if (Input.GetKey("a"))
        {
            playerbody.AddForce(new Vector3(-walkingForce, 0, 0));
        }

        if (Input.GetKey("d"))
        {
            playerbody.AddForce(new Vector3(walkingForce, 0, 0));
        }

    }
}
