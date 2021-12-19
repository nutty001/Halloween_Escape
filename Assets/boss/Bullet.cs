using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

        // Use this for initialization
        private float bulletSpeed;
        GameObject parent;

        private Vector3 theScale;

        void Start()
        {

            rigidbody2D.velocity = new Vector2(bulletSpeed, 0);
        }

        // Update is called once per frame
        void Update()
        {

            //  if(transform.localScale.x < 0) bulletSpeed = -100;
            //  if(transform.localScale.x > 0) bulletSpeed = 100;
        }
        public void SetEnemy(GameObject obj)
        {
            parent = obj;
        }
    }
