using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject guard;
    public int resetTime = 5;
    private float reset;
    private bool movingDown;

    // Start is called before the first frame update
    void Start()
    {
        reset = resetTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingDown == false)
            transform.position -= new Vector3(0, 0, 0.1f);
        else
            transform.position += new Vector3(0, 0, 0.1f);
            
        if (transform.position.z > 10)
            movingDown = false;
        else if (transform.position.z < -10)
            movingDown = true;

        reset -= Time.deltaTime;
        if (reset < 0)
        {
            GetComponent<SphereCollider>().enabled = true;
            guard.GetComponent<Guard>().alerted = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            guard.GetComponent<Guard>().alerted = true;
            GetComponent<SphereCollider>().enabled = false;
            reset = resetTime;
        }
    }
}
