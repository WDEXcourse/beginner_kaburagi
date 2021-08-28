using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public int magnification = 1;
    public bool fallFlag = false;//
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5 * magnification);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5 * magnification);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5 * magnification, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5 * magnification, 0, 0);
        }

        if(transform.position.y < -10)
        {
            magnification = 1;
            transform.position = new Vector3(0, 4, -4);
            rb.velocity = Vector3.zero;
            fallFlag = true;
        }
    }

    private void OnCollisionStay(Collision hit)
    {
        if(hit.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(0, 4, -4);
        }

        if(hit.gameObject.tag == "Wall")
        {
            magnification = 5;
        }
    }
}
