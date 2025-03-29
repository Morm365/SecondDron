using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLamp : MonoBehaviour
{


    public float interval = 2f;

    private SpriteRenderer LightLamp;




    void Start()
    {

        LightLamp = GetComponent<SpriteRenderer>();

        StartCoroutine(Blink());



    }

    
    IEnumerator Blink()
    {

        while(true)
        {

            LightLamp.enabled = !LightLamp.enabled;

            yield return new WaitForSeconds(interval);

        }
            
    }



}
