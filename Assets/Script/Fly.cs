using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    public EnergyBar energyBar;

    private bool wireConnection = false;

    public float energyConsumption = 20f;

    public float restoration = 4f;

    void Start()
    {
        

    }

    
    void Update()
    {


        if (wireConnection)
        {

          energyBar.energyPoints = energyBar.maxEnergy;

        }
           


       else if (energyBar.energyPoints < energyBar.maxEnergy)
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
        //if (other.CompareTag("Wire"))
        //{
        //    wireConnection = true;
        //    Debug.Log("TrueConnection");

        //}
        wireConnection = true;
        Debug.Log("TrueConnection");
        energyBar.energyPoints = energyBar.maxEnergy;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //if (other.CompareTag("Wire"))
        //{
        //    wireConnection = false;
        //}
        wireConnection = false;

    }
}
