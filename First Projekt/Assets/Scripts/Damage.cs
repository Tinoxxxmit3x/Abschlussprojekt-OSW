using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float health = 20;
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
        Destroy(gameObject);
    }
}
