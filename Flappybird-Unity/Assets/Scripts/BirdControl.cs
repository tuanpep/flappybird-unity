using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControl : MonoBehaviour
{
    private const float JUMP_AMOUNT = 5.5F;
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
    }

    private void Jump()
    {
        transform.Rotate(0, 0, 15);
        birdRigidbody2D.velocity = Vector2.up * JUMP_AMOUNT;
    }
}
