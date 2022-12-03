using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace rSwick
{
    public class ExitGame : MonoBehaviour
    {

        void Update()
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();
            }
        }
    }
}
