using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{
    public ParticleSystem dust;
    void Start()
    {
        dust.Play();
    }

}
