using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miningDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collision2D collision)
    {
        print("Triggered");
        Destroy(collision.gameObject);
    }

}
