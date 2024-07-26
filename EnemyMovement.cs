using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        myRigidbody.velocity = new Vector2(moveSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Exit 2D");
        moveSpeed = -moveSpeed;
        FlipEnemyFacing();
    }

    void FlipEnemyFacing()
    {
        Debug.Log("Testing");
        // changing direction wherever the direction is, but when it triggers something
        transform.localScale = new Vector2(-Mathf.Sign(myRigidbody.velocity.x), 1f);
    }
}
