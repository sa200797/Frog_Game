using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerInitialpos;


    int Scroe;
     

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        playerInitialpos = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            collision.transform.position = playerInitialpos;

            Scroe += 10;
            Debug.Log(Scroe);


        }
    }
   
}
