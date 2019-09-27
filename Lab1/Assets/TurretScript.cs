﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    bool pressed = false;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1") && !pressed)
        {
            GameObject b = Instantiate(bullet, transform.position, transform.rotation);
            b.transform.parent = this.transform;
            pressed=true;
        }
	else if(!Input.GetButton("Fire1")) pressed=false;
    }
}
