using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickUp : MonoBehaviour
{
        public static event Action OnPickupCollected;
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {
            OnPickupCollected?.Invoke();

            Destroy(gameObject);
        }
    }
}

  
