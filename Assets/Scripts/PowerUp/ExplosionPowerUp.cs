using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPowerUp : PowerUp
{
    public GameObject explosionEffect;
    private float explosionTime = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // explosionEffect = TODO
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Action()
    {
        Debug.Log("Explosion");

        Object currExplosion = Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Destroy(currExplosion, explosionTime);
    }
}
