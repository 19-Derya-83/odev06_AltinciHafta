using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts

{

    public class Player01 : MonoBehaviour
    {

        public float rotateSpeed;

        private void Update()
        {

            Rotate();

        }

        private void Rotate()

        {

            transform.Rotate(Vector3.right * (Time.deltaTime * rotateSpeed));

        }

    }

}
