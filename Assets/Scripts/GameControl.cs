using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject horse;
    private int limitNum = 5;
    int count = 0;

    void Start()
    {
        InvokeRepeating("HorseGo", 0.1f, 1.0f);
    }

    void Update()
    {

    }

    void HorseGo()
    {
        count++;
        if (count > limitNum)
        {
            Invoke("Fade", 2.0f);
        }
        else
        {
            Instantiate(horse, new Vector3(2.0f, 0, 0), Quaternion.Euler(Vector3.zero));
        }
    }

    void Fade()
    {
        Initiate.Fade("Stage2", Color.black, 1.0f);
    }
}
