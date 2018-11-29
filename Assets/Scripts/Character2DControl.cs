using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2DControl : MonoBehaviour
{
    private Character2D character;
    private bool jump;
    private float movingSpeed;

    void Start()
    {
        character = GetComponent<Character2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump")) jump = true;
    }

    void FixedUpdate()
    {
        movingSpeed = Input.GetAxis("Horizontal");
        character.Move(movingSpeed, jump);
        jump = false;
    }
}
