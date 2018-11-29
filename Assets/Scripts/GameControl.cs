using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject horse;

    void Start()
    {
        InvokeRepeating("HorseGo", 0.5f, 1.0f);
    }

    void Update()
    {

    }

    void HorseGo()
    {
        Instantiate(horse, new Vector3(2.0f, 0, 0), Quaternion.Euler(Vector3.zero));
    }
}
