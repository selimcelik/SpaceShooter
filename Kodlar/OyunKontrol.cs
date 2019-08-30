using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject asteroid;
    public Vector3 randomPos;
    int score;
    public Text text;
    public Text oyunbittiText;
    public Text yenidenbaslaText;
    bool oyunbittikontrol = false;
    bool yenidenbaslakontrol = false;




    void Start()
    {
        score = 0;
        text.text = "score = " + score;
        StartCoroutine(olustur());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("1");
        }
    }

    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for (int i = 0; i < 100000; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
            }
            if (oyunbittikontrol = true)
            {
                yenidenbaslaText.text = "YENİDEN BAŞLAMAK İÇİN R TUŞUNA BASINIZ.";
                yenidenbaslakontrol = true;
                break;
            }
            yield return new WaitForSeconds(0.2f);

        }
    }
    public void ScoreArttir(int gelenscore)
    {
        score += gelenscore;
        text.text = "score= " + score;
    }
    public void oyunBitti()
    {
        oyunbittiText.text = "OYUN BİTTİ YENİDEN BAŞLAMAK İÇİN R TUŞUNA BASINIZ.";
        oyunbittikontrol = true;

    }
}