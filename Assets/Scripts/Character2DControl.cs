using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DControl : MonoBehaviour
{
    private Character2D character;
    private bool jump;
    private bool attack;
    private float movingSpeed;
    public AudioClip jumpSound;
    public AudioClip attackSound;
    AudioSource source;

    void Start()
    {
        character = GetComponent<Character2D>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            source.clip = jumpSound;
            source.Play();
            jump = true;
        }
        if (Input.GetButton("Fire1"))
        {
            source.clip = attackSound;
            source.Play();
            character.Attack();
        }
    }

    void FixedUpdate()
    {
        movingSpeed = Input.GetAxis("Horizontal");
        character.Move(movingSpeed, jump);
        jump = false;
    }
}
