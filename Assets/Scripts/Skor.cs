using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Skor : MonoBehaviour
{
    public static int skor;
    public Text skorText;
    public GameObject opening;

    void Start()
    {
        skor=0;
    }

   
    void Update()
    {
        skorText.text=skor.ToString();

        if(Input.GetMouseButtonDown(0))
        {
            opening.SetActive(false);
        }
    }
}
