using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public void   OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Boat")
        {
            Destroy(collision.gameObject);
        }
    }
}
