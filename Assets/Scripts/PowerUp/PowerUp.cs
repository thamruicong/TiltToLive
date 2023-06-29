using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Action();

    public void Destroy()
    {
        Debug.Log("Destroy PowerUp");
        Destroy(this.gameObject);
    }
}
