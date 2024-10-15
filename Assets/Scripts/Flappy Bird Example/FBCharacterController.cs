using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FBCharacterSystem
{
    public class FBCharacterController : MonoBehaviour 
    {
        public float forceMagnitude = 10000;
        private Rigidbody2D rb;
        

        private void Start() 
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update() 
        {
            if (FBInputManager.instance.fly) 
            {
                rb.AddForce(Vector3.up * forceMagnitude * Time.deltaTime);
            }
        }


    }
}
