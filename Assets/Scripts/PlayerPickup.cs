using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public float range = 20;
    public float throwPower = 10;
    public Transform handTransform;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject pickedUpItem;

        if (collision.collider.GetComponent<IPickup>() != null)
        {
            pickedUpItem = collision.collider.gameObject;
            pickedUpItem.GetComponent<IPickup>().Pickup(handTransform);
        }
    }
}
