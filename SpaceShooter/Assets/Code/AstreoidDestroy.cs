using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreoidDestroy : MonoBehaviour
{
    public GameObject patlama;
    public GameObject playerPatlama;
    GameObject OyunKontrol;
    OyunKontrol kontrol;

    private void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = OyunKontrol.GetComponent<OyunKontrol>();
       
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sinir")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            kontrol.ScoreArttir(10);
        }
        if (col.tag != "sinir")
        {
            Instantiate(playerPatlama, col.transform.position, col.transform.rotation);
        }


    }
}
