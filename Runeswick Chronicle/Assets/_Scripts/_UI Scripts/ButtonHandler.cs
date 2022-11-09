using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;



namespace rSwick
{
    public class ButtonHandler : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        [SerializeField] private Button quitButton;
        [SerializeField] private Button optionsButton;
        public int i = 1;

        // Start is called before the first frame update
        void Awake()
        {
            
            startButton.onClick.AddListener(I);
            optionsButton.onClick.AddListener(I);
            quitButton.onClick.AddListener(I);
            
        }

        void I()
        {
            i++;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
