using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    public float baslangicBekleme, olusturmaBekleme, donguBekleme;
    int score;
    
    void Start()
    {
       StartCoroutine( olustur()); 
    }
    IEnumerator olustur()
    {
        yield return new WaitForSeconds(baslangicBekleme);
        while(true)
        {
        for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
            Instantiate(Asteroid, vec, Quaternion.identity);
            yield return new WaitForSeconds(olusturmaBekleme);
        }
            yield return new WaitForSeconds(olusturmaBekleme);
        }
    }

    public void ScoreArttir(int gelenScore)

    {
        score = gelenScore
 
    }
}
