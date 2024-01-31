using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesilTugla : MonoBehaviour
{
    [SerializeField]int tuglasaglýgý;
   

   
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag=="Top")
        {
            tuglasaglýgý--;
            KazanmaYazýsý.skor += 5;
        }
        if(tuglasaglýgý==0)
        {
            
            Destroy(this.gameObject);
            KazanmaYazýsý.kýrýlanBlok++;

        }
    }
}
