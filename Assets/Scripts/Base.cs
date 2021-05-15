using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public GameObject winPanel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && collision.gameObject.GetComponentInChildren<IPickup>() != null)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
