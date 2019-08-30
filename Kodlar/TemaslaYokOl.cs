using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemaslaYokOl : MonoBehaviour
{
    public GameObject patlama;
    public GameObject playerpatlama;
    GameObject OyunKontrol;
    OyunKontrol kontrol;
    void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = OyunKontrol.GetComponent<OyunKontrol>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "sinir")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.ScoreArttir(10);
        }
        if (other.tag == "Player")
        {
            Instantiate(playerpatlama, other.transform.position, other.transform.rotation);
            kontrol.oyunBitti();
        }
    }
}
