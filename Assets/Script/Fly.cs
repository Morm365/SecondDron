using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    public EnergyBar energyBar;

    public bool wireConnection = false;

    public float energyConsumption = 20f;

    public float restoration = 4f;


    public Transform checkSurface;
    public LayerMask surfaceBase;
    private bool surfaced;


    public AudioSource eBoostSound;

    public Animator eBoostAnimation;



    void Start()
    {


        if(energyBar == null)
        {


            GameObject energyObject = GameObject.FindGameObjectWithTag("Energy");

            if(energyObject != null)
            {

                energyBar = energyObject.GetComponent<EnergyBar>();


            }


        }






    }


    void Update()
    {

        CheckSurface();


        if (wireConnection)
        {

            energyBar.energyPoints = energyBar.maxEnergy;

        }



        else if (energyBar.energyPoints < energyBar.maxEnergy && surfaced)
        {
            energyBar.energyPoints += restoration * Time.deltaTime;

            if (energyBar.energyPoints > energyBar.maxEnergy)
            {

                energyBar.energyPoints = energyBar.maxEnergy;

            }


        }



        if (Input.GetKey(KeyCode.Space) && energyBar.energyPoints > 0)
        {

            if (!wireConnection)
            {

                energyBar.energyPoints -= energyConsumption * Time.deltaTime;

                if (energyBar.energyPoints < 0)
                {
                    energyBar.energyPoints = 0;
                }
            }



        }




    }




    void OnTriggerEnter2D(Collider2D other)
    {



        if (other.CompareTag("EnergyBoost"))
        {

            energyConsumption -= 15f;

            if (energyConsumption < 0f)
            {

                energyConsumption = 0f;

            }

            Destroy(other.gameObject);


            if(eBoostSound != null)
            {

                eBoostSound.Play();

            }

            if (eBoostAnimation != null)
            {

                eBoostAnimation.SetTrigger("Call");

            }

            return;
        }




        wireConnection = true;

        Debug.Log("TrueConnection");

        energyBar.energyPoints = energyBar.maxEnergy;


        


    }

    void OnTriggerExit2D(Collider2D other)
    {

        wireConnection = false;

    }

    private void CheckSurface()
    {

        surfaced = Physics2D.Raycast(checkSurface.position, Vector2.down, 0.2f, surfaceBase);

    }
  




}
