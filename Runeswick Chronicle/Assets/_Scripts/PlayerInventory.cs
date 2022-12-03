using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace rSwick
{
    public class PlayerInventory : MonoBehaviour
    {
        public int Keycollect { get; private set; }

        public void KeyGet()
        {
            Keycollect++;
        }
        
        
    }
}
