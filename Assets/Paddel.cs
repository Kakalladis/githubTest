using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 3f;
    [SerializeField]
    KeyCode up;
    [SerializeField]
    KeyCode down;



    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up) && transform.position.y < 0)
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(down) && transform.position.y > -8)
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime, 0);
        }
    }
}
