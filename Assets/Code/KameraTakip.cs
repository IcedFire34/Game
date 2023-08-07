using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y + 2, offset.z -1);
    }
}
