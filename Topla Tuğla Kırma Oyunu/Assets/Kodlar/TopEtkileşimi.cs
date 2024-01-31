using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TopEtkileşimi : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbTop;
    [SerializeField] float baslangıcTopHızıY, baslangıcTopHızıX;
    [SerializeField] TextMeshProUGUI kaybeymeYazısı;
    [SerializeField] AudioSource CarpmaSesi;
    void Start()
    {
        rbTop.velocity = new Vector2(Random.Range(-baslangıcTopHızıX, baslangıcTopHızıX), baslangıcTopHızıY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "sagduvar")
        {
            rbTop.velocity = new Vector2(-baslangıcTopHızıX, rbTop.velocity.y);
        }
        if (collision.gameObject.tag == "solduvar")
        {
            rbTop.velocity = new Vector2(baslangıcTopHızıX, rbTop.velocity.y);
        }
        if (collision.gameObject.tag == "tavan")
        {
            rbTop.velocity = new Vector2(rbTop.velocity.x, -baslangıcTopHızıY);
        }
        if (collision.gameObject.tag == "tugla")
        {
            CarpmaSesi.Play();
        }
        /*if (collision.gameObject.tag == "Player"&& rbTop.velocity.y<=0)
        {
            rbTop.velocity = new Vector2(rbTop.velocity.x, baslangıcTopHızıY);
        }*/
        if (collision.gameObject.tag == "YenidenBaslatıcı")
        {
            Time.timeScale = 0;
            kaybeymeYazısı.text = "Kaybettiniz" + "\n Skor: " + KazanmaYazısı.skor + "\nKırılan Blok: " + KazanmaYazısı.kırılanBlok + "\n\n Yeniden Başlamak İçn ENTER'a basınız";

            
        }
    }
    private void Update()
    {
        if (Time.timeScale == 0)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
                KazanmaYazısı.skor = 0;
                KazanmaYazısı.kırılanBlok = 0;
                Time.timeScale = 1;

            }
        }
    }
}
