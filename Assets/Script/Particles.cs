using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{


    //void Start()
    //{



    //}

    public ParticleSystem particles;

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            if (!particles.isPlaying)
            {
                particles.Play();

            }

           

        }

        else
        {
            if (particles.isPlaying)
            {

                particles.Stop();
            }
                
        }

    }
}
