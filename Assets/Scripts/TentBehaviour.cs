using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TentBehaviour : MonoBehaviour
{
       private void OnTriggerEnter(Collider other) {
        
        if (other.tag == "Europe")
        {
            SceneManager.LoadScene("Game.Europe"); 
        }

        if (other.tag == "Asia")
        {
            SceneManager.LoadScene("Game.Asia");
        }

        if (other.tag == "America")
        {
            SceneManager.LoadScene("Game.America");       
        }
    }
}
