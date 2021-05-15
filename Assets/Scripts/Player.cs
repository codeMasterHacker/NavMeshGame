using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * Time.deltaTime * speed, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-Vector3.right * Time.deltaTime * speed, Space.World);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
    }
}
