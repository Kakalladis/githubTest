using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7;
    Vector3 dir;


    private void ResetBall()
    {
        transform.position = new Vector3(10, -4, 0);
        int x = Random.Range(0, 2);
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1, 2), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dir.x = -dir.x;
        }
        else
        {
            dir.y = -dir.y;
        }
        print("Blals");


    }

    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
    }



    // Update is called once per frame
    void Update()
    {
        transform.position += dir * 7 * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
        
        
    }
}
