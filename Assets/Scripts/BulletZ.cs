﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletZ : MonoBehaviour
{
    
    public float speed = 2;
    public float lifeTime =2;

    private void Start()
    {
        Destroy(gameObject,lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
        
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }
}
