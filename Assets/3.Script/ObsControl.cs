using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsControl : MonoBehaviour
{
    public ObstacleSpawner obSpawner;

    /*
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Floor"))
        {

        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Floor"))
        {
            Debug.Log("¿€µø¿ﬂµ ");
            obSpawner.instance.InsertQueue(gameObject);
        }
    }
}
