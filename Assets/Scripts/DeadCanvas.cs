using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadCanvas : MonoBehaviour
{
    public Text Message;
    private Canvas dead;
    bool gameOver = false;

    void Start()
    {
        dead = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Time.timeScale = 1;
            if (gameOver) SceneManager.LoadScene("Menu");
            else dead.enabled = false;
        }
    }

    public void Finish()
    {
        Message.text = "GAME OVER";
        dead.enabled = true;
        gameOver = true;
    }
}
