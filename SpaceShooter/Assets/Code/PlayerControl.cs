﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float karakterHiz;
    public float minX,maxX,minZ,maxZ,egim;
    float atesZamani = 0;
    public float atesGecikme;
    public GameObject Kursun;
    public Transform KursunCikis;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>atesZamani)
        {
            atesZamani = Time.time + atesGecikme;
            Instantiate(Kursun, KursunCikis.position,Quaternion.identity);
        }
    }


    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec = new Vector3(horizontal,0,vertical);

        fizik.velocity = vec*karakterHiz;

        fizik.position = new Vector3
         (
            Mathf.Clamp(fizik.position.x,minX,maxX),
            0.0f,
            Mathf.Clamp(fizik.position.z,minZ,maxZ)
        );

        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*-egim);


        

    }
}
