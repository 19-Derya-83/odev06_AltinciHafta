using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts

{

    public class Player02 : MonoBehaviour
    {

        public float speed;


        private void Update()
        {

            Move();

            if (transform.position.z > 100)
            {

               transform.position = new Vector3(-2, 3, 0);

            }

        }


        private void Move()

        {

            transform.position += Vector3.forward * (Time.deltaTime * speed);


        }


    }

}
