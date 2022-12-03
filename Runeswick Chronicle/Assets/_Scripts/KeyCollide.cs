using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace rSwick
{
    public class KeyCollide : MonoBehaviour
    {
       private void OnTriggerEnter(Collider other)
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

            if (playerInventory != null)
            {
                playerInvetory.KeyGet();
                gameObject.SetActive(false);

            }

        }
    }
}
