using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prize : MonoBehaviour
{
    public GameObject player;
    private bool pickedUp = false;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickedUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime*speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pickedUp = true;
        }
    }
}
