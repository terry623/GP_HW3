using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCanvas : MonoBehaviour
{
    private Canvas dead;

    void Start()
    {
        dead = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            dead.enabled = false;
            Time.timeScale = 1;
        }
    }
}
