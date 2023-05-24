using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KameraTakip : MonoBehaviour
{
    public Transform topKonumu;
    Vector3 fark;

    void Start()
    {
        fark=transform.position-topKonumu.position;
    }

    void Update()
    {
        if(TopHareketi.düştü_mü==false)
        {
        transform.position= topKonumu.position+fark;
        }
    }


    public void RestarGame()
     {
       SceneManager.LoadScene(0);
      
     }
}
