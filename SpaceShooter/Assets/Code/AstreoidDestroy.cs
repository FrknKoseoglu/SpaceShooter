using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreoidDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sinir")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }

    }
}
