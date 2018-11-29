using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour
{
    public float speed;

    void Start()
    {
        speed = 2.0f;
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector3 target = new Vector3(-5.0f, 0, 0);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Wall"))
            Destroy(gameObject);
    }
}
