using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 5.0f;
    //public int moveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
     body = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

}
