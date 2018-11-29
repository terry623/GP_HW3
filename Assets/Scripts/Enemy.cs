using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float health;
    public GameObject player;
    float speed = 0.5f;
    bool facingLeft = true;
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

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
        if (health < 0)
        {
            Invoke("Fade", 2.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            anim.SetBool("Attack", true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            anim.SetBool("Attack", false);
    }

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 characterScale = transform.localScale;
        characterScale.x *= -1;
        transform.localScale = characterScale;
    }

    void Fade()
    {
        Initiate.Fade("Menu", Color.black, 1.0f);
    }
}
