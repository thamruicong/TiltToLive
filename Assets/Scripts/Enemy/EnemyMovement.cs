using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private GameObject target;
    private Rigidbody2D rigidBody;
    private float defaultMoveSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = Vector3.Normalize(target.transform.position - transform.position);
        rigidBody.MovePosition(transform.position + direction * defaultMoveSpeed * Time.deltaTime);
    }
}
