using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHareket : MonoBehaviour
{
    [SerializeField] float hareket;
    [SerializeField] float hýz;
    [SerializeField] float Xpozisyonu;
    
    
    

    void Update()
    {
        Xpozisyonu = Mathf.Clamp(transform.position.x, -9.75f, 9.75f);
        transform.position = new Vector2(Xpozisyonu, transform.position.y);

        hareket = Input.GetAxisRaw("Horizontal");
        transform.Translate(hareket*hýz*Time.deltaTime,0,0);

    }
}
