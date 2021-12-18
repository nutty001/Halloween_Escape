using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{

    public float Speed;
    public float distance;

    private bool movingRight = true;

    public Transform GroundDetection;

    private void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(GroundDetection.position, Vector2.down, 2.0f, LayerMask.GetMask("Ground"));
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}