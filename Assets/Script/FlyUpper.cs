using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyUpper : MonoBehaviour
{

    public EnergyBar energyBar;

    public float upSpeed = 12f;

    public float artrificalGravity = -5f;

    public Rigidbody2D  robot;


    void Start()
    {
        robot = GetComponent<Rigidbody2D>();



    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && energyBar.energyPoints > 0)
        {

            robot.velocity = new Vector2(robot.velocity.x, upSpeed);

          



            //transform.Translate(Vector2.up * upSpeed * Time.deltaTime);

        }


        else
        {
            robot.velocity = new Vector2(robot.velocity.x, artrificalGravity);


        }

    }

}
