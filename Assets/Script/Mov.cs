using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed = 15f;

    public float currentSpeed = 0f;

    public float acceleration = 20f;

    public float decceleration = 30f;

    private Rigidbody2D direct;

    public SpriteRenderer droneSpr;

    public float upSpeed = 12f;

    public float artificialGravity = -5f;

    public EnergyBar energyBar;

    private float verticalSpeed = 0f;

    //public float accelerationScale = 0f;

    //public float deccelerationScale = 0f;

    //private bool notStop = false;

    //private Rigidbody2D direct;


    void Start()
    {


        direct = GetComponent<Rigidbody2D>();

        //droneSpr = GetComponent<SpriteRenderer>();


        if (energyBar == null)
        {


            GameObject energyObject = GameObject.FindGameObjectWithTag("Energy");

            if (energyObject != null)
            {

                energyBar = energyObject.GetComponent<EnergyBar>();


            }

            else
            {
                Debug.LogError("NO ENERGY BAR");
            }


        }







    }

    void Update()
    {

        float move = Input.GetAxisRaw("Horizontal");

       if (move != 0)
        {


            if (Mathf.Sign(move) != Mathf.Sign(currentSpeed))
            {

                currentSpeed = 0f;

            }


            currentSpeed = Mathf.MoveTowards(currentSpeed, move * maxSpeed, acceleration * Time.deltaTime);


            // droneSpr.flipX = move < 0;  // dont change transform

            if (droneSpr != null)
            {
                droneSpr.flipX = move < 0;


            }
                
        }
       else
        {

            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, decceleration * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Space) && energyBar.energyPoints > 0)
        {

            verticalSpeed = upSpeed;





            //transform.Translate(Vector2.up * upSpeed * Time.deltaTime);

        }


        else
        {
            verticalSpeed = artificialGravity;


        }













    }


   
    private void FixedUpdate()
    {

        direct.velocity = new Vector2(currentSpeed, verticalSpeed);

    }


}
