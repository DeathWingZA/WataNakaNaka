using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Spawnpoint;


    private void OnTriggerEnter(Collider other) {
        
        if (other.tag == "Fall")
        {
            transform.position = Spawnpoint.transform.position;
        }
    }
}
