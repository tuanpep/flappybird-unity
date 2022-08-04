using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    private const float JUMP_AMOUNT = 7.5F;
    private Rigidbody2D birdRigidbody2D;
    private Vector3 rotateObject;

    private void Awake()
    {
        birdRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }


        float rotation = birdRigidbody2D.velocity.y * 0.2f;
        if (transform.rotation.z > 0.2f && rotation > 0) rotation = 0;
        else if (transform.rotation.z < 0f && rotation < 0) rotation = 0;
        else if (transform.rotation.z < -0.3f && rotation <= 0) rotation = -10;
        transform.Rotate(0, 0, rotation, Space.Self);
    }

    private void Jump()
    {
        birdRigidbody2D.velocity = Vector2.up * JUMP_AMOUNT;
    }
}
