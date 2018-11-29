using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public GameObject player;
    float speed = 0.5f;
    bool facingLeft = true;

    void Start()
    {
        health = 2000;
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector3 target = player.transform.position + new Vector3(0.3f, 0.4f, 0);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        float direction = transform.position.x - player.transform.position.x;
        if (direction > 0 && !facingLeft || direction < 0 && facingLeft) Flip();
    }

    public void GetDamaged(int damage)
    {
        health -= damage;
    }

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 characterScale = transform.localScale;
        characterScale.x *= -1;
        transform.localScale = characterScale;
    }
}
