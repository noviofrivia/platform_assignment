using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float horizontal_speed;

    void Update()
    {
        gameObject.transform.Translate(0, 0, MoveSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(horizontal_speed * Time.deltaTime, 0, 0);
        }

        else if(Input.GetKey("a"))
        {
            gameObject.transform.Translate(-horizontal_speed * Time.deltaTime, 0, 0);
        }
    }
}
