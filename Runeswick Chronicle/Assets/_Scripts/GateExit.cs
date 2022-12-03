using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace rSwick
{
   

    public class GateExit : PlayerInventory
    {
        private void Update()
        {
            Debug.Log(Keycollect);
        }

        [SerializeField] private GameObject Gate;
        [SerializeField] private Collision playerCol;
        private void OnTriggerEnter(Collider other)
        {
            Application.Quit();
        }
        }
    }

