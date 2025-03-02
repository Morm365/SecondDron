using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{

    Image energyBar;

    public float maxEnergy;

    public float energyPoints;



    void Start()
    {

        energyBar = GetComponent<Image>();

        energyPoints = maxEnergy;


    }

    
    void Update()
    {

        energyBar.fillAmount = energyPoints / maxEnergy;



    }
}
