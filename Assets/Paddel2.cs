using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddel2 : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;
    
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 0)
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -8)
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime, 0);
        }
    }
}
