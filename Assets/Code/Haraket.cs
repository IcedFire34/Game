using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Haraket : MonoBehaviour
{
    public int hız = 1;
    public int ZıplamaGücü = 2;
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
      Zıpla();
    }
    void YatayHaraket()
    {
      yatay = Input.GetAxis("Horizontal");
      Rigid.AddForce(new Vector3(yatay * hız,0,0));      
    }
    void Zıpla()
    {
        dikey = Input.GetAxis("Vertical");
        Rigid.AddForce(new Vector3(0, dikey * ZıplamaGücü, 0));
    }
}
