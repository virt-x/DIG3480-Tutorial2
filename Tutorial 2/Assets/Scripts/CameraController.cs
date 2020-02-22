using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x - offset.x, /*player.transform.position.y -*/ offset.y, offset.z);
    }
}
