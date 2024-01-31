using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kırmızıTugla : MonoBehaviour
{
    [SerializeField] int tuglasaglıgı;
    


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Top")
        {
            tuglasaglıgı--;
            KazanmaYazısı.skor += 10;
        }
        if (tuglasaglıgı == 0)
        {
            
            Destroy(this.gameObject);
            KazanmaYazısı.kırılanBlok++;

        }
    }

   
    
}
