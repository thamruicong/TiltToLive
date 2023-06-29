using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") 
        {
            Debug.Log("You Lose");
        }

        if (other.gameObject.tag == "PowerUp") 
        {
            var myScript = other.gameObject.GetComponent<PowerUp>();
            myScript.Action();
            myScript.Destroy();
        }
    }
}
