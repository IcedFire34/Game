using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int puan;
    public Text PuanText;    
    public int hız = 7;
    public int ZıplamaGücü = 150;
    Rigidbody2D Rigid;
    public float yatay;
    public float dikey;
    
    void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        YatayHaraket();
        PuanText.text = puan.ToString();
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                puan++;
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == "Yer")
            {
                Zıpla();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            puan++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Yer")
        {
            Zıpla();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Yer")
        {
            Zıpla();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Yer")
        {
            Zıpla();
        }
    }
    void Zıpla()
    {
        dikey = Input.GetAxis("Vertical");
        Rigid.AddForce(new Vector3(0, dikey * ZıplamaGücü, 0));
    }
    void YatayHaraket()
    {
        yatay = Input.GetAxis("Horizontal");
        Rigid.AddForce(new Vector3(yatay * hız, 0, 0));
    }
}
