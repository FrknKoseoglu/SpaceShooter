using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    public float baslangicBekleme, olusturmaBekleme, donguBekleme;
    int score;
    bool GameOverControl = false;
    bool restartControl = false;

    public Text text; 
    void Start()
    {
        score = 0;
        text.text = "score = " + score; 
       StartCoroutine( olustur()); 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && restartControl)
        {
            SceneManager.LoadScene("Level 1");
        }
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

            if(GameOverControl)
            {
                restartControl = true;
                break;
            }
        }
    }

    public void ScoreArttir(int gelenScore)

    {
        score += gelenScore;
        text.text = "score =" + score;

    }

    public void GameOver()
    {
        GameOverControl = true;
    }
}
