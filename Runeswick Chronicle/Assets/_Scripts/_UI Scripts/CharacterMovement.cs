using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace rSwick
{
    public class CharacterMovement : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
       
        void Update()

        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            float speed = 10.0f;
            transform.position = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        }
    }
}
