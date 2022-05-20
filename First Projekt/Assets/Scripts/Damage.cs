using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float health = 20;
    public GameObject munitionBundle;
    public ParticleSystem bloodParticles;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            CreateParticles();
            health -= 10;
            if (health <= 0)
            {
                delete();
            }
        }
    }

    void CreateParticles()
    {
        Instantiate(bloodParticles, transform.position, Quaternion.identity);
    }

    void delete()
    {
        if (Random.value <= 0.2)
        {
            Instantiate(munitionBundle, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
