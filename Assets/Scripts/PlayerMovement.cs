using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;     
    public float jumpHeight = 2.0f;
    public float groundDistance = 0.2f;
    public LayerMask groundMask;

    private Rigidbody rb;
    [SerializeField]
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float z = speed * Time.fixedDeltaTime;

        transform.Translate(0, 0, z);

        transform.Translate(x, 0, 0);

        isGrounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);

    }

    private void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y), ForceMode.Impulse);
        }
    }
}
