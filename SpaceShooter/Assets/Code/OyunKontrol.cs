using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    void Start()
    {
        olustur(); 
    }
    void olustur()
    {
        Vector3 vec = new Vector3(Random.Range(-randomPos.x,randomPos.x),0,randomPos.z);
        Instantiate (Asteroid,vec,Quaternion.identity);
    }

   
}
