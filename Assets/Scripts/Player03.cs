using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts

{

    public class Player03 : MonoBehaviour
    {
        public float speed;

        private void Update()
        {

            DestroySphere(); 
            
            Move();

            

        }

        private void Move()

        {
            for (int i = 0; i < Random.Range(1, 2); i++)

            {

                transform.position += new Vector3(Random.Range(-20f, 20f), Random.Range(-20, 20f), Random.Range(-20, 20f)) * (Time.deltaTime * speed);

            }


        }

        public void DestroySphere()

        {

            Destroy(gameObject, 2);

        }

    }

}
