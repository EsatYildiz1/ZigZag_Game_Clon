using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopHareketi : MonoBehaviour
{
    Vector3 yön;
    public float hız;

    public ZeminSpawner zeminSpawnerScripti;
    public static bool düştü_mü;
    public float hız_artışı;
    public GameObject Finish;
    
    void Start()
    {
       // yön = Vector3.forward;
        düştü_mü=false;
    }

    
    void Update()
    {
        if(transform.position.y<=0.5f)
        {
            Finish.SetActive(true);
            düştü_mü=true;
            Destroy(gameObject,3f);
        }

        if(düştü_mü==true)
        {
            return;
        }
        if(Input.GetMouseButtonDown(0))
        {
            
           
            if(yön.x==0)
            {
                yön=Vector3.left;
            }
            else
            {
                yön=Vector3.forward;
            }
            
            

            hız+= hız_artışı*Time.deltaTime;
        }
    }

    private void FixedUpdate() 
    {
        Vector3 hareket= yön*Time.deltaTime* hız;
        transform.position+=hareket;
    }

    private void OnCollisionExit(Collision other) 
    {
        if(other.gameObject.tag== "Zemin")
        {
            Skor.skor++;
            zeminSpawnerScripti.Zemin_Oluştur();
            StartCoroutine(ZeminiSil(other.gameObject));
            other.gameObject.AddComponent<Rigidbody>();
        }
    }
    
    IEnumerator ZeminiSil (GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    
    }

   
}
