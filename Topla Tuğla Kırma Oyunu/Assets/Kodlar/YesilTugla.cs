using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesilTugla : MonoBehaviour
{
    [SerializeField]int tuglasagl�g�;
   

   
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag=="Top")
        {
            tuglasagl�g�--;
            KazanmaYaz�s�.skor += 5;
        }
        if(tuglasagl�g�==0)
        {
            
            Destroy(this.gameObject);
            KazanmaYaz�s�.k�r�lanBlok++;

        }
    }
}
