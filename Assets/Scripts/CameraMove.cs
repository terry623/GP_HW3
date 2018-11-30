using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    private float offset;

    void Start()
    {
        offset = transform.position.x - player.transform.position.x;
    }

    void LateUpdate()
    {
        float x = Mathf.Clamp(player.transform.position.x + offset, -2.5f, 2.5f);
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}
