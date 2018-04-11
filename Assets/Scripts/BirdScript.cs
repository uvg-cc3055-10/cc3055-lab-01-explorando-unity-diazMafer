using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
    public float jumpForce = 20f;
    Rigidbody2D rb;
    public float forwardSpeed = 2f;
    public GameObject cam;
    public Boolean dead = false;
   



    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();

    }

   
	
	// Update is called once per frame
	void Update() {
        if (dead == false)
        {
            if (rb.position.x > 24.995)
            {
                dead = true;
            }

            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);


            }
            rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);

            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }


}
