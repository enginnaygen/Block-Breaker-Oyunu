using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KazanmaYazısı : MonoBehaviour
{
    public static int skor, kırılanBlok;
    public TextMeshProUGUI kazanmaYazısı, skorYazısı;
    public Transform bloklar;
    int blokSayısı;



    void Start()
    {
        
    }

    void Update()
    {
        skorYazısı.text = "skor:" + skor;
        blokSayısı = bloklar.childCount;

        if(blokSayısı==0)
        {
            kazanmaYazısı.text = "Tebrikler Kazandınız\n Puanınız: " + skor +"\n Kırılan Blok: "+ kırılanBlok+ "\n\nTekrar Oynamak ENTER'a Basınız";
            Time.timeScale = 0;
            Destroy(skorYazısı);

            if(Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
                skor = 0;
                kırılanBlok = 0;
                Time.timeScale = 1;
            }
        }
        

    }
}
