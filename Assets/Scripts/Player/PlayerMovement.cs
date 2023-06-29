using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float defaultMoveSpeed = 1.0f;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        
        // Position
        rigidBody.MovePosition(transform.position + direction * defaultMoveSpeed * Time.deltaTime);

        // Rotation
        float targetAngle = Vector2.SignedAngle(Vector2.up, direction);
        rigidBody.MoveRotation(targetAngle);
    }
}
