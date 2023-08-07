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
    public Collider2D col;
    public float yatay;
    public float dikey;
    
    void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        YatayHaraket();
        void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log(collision.gameObject.tag);
            if (collision.gameObject.tag == "Yer")
            {
                Zıpla();
            }
        }
        OnTriggerEnter2D(col);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
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
        Rigid.AddForce(new Vector3(50, 0, 0));
    }
}
