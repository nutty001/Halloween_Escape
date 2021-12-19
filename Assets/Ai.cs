using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    public float speed;
    public bool MovingRight = false;
    public float RayDistance;

    public Transform groundDetection;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        RaycastHit2D groundinfo = Physics2D.Raycast(groundDetection.position, Vector2.down, RayDistance);

        if (groundinfo.collider == false)
        {
            if (MovingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                MovingRight = false;
            }
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            MovingRight = true;
        }

    }
}