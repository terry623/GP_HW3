using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    List<GameObject> heartList = new List<GameObject>();
    AudioSource dieSound;
    public GameObject dead;

    void Start()
    {
        heartList.Add(heart1);
        heartList.Add(heart2);
        heartList.Add(heart3);
        dieSound = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    public void costHealth()
    {
        dieSound.Play();
        int last = heartList.Count - 1;
        GameObject obj = heartList[last];
        obj.SetActive(false);
        heartList.RemoveAt(last);
        if (last == 0) dead.GetComponent<DeadCanvas>().Finish();
        Time.timeScale = 0;
    }
}
