using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats c = collision.GetComponent<PlayerStats>();
        if (c != null)
        {
            GetComponent<IPickUpObject>().OnPickUp(c);
            Destroy(gameObject);
        }
    }
}


