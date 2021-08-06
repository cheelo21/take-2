using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AN
{
    public class PlayerManager : MonoBehaviour
    {
        InputHandler inputHandler;
        Animator anim;

        void Start()
        {
            inputHandler = GetComponent<InputHandler>();
            anim = GetComponent<Animator>();
        }


        void Update()
        {
            inputHandler.isInteracting = anim.GetBool("isInteracting");

        }
    }
}