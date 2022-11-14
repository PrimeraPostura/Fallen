using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveles : MonoBehaviour
{
   [SerializeField]
   private string escena;

   void OnTriggerEnter2D(Collider2D other){

    if(other.CompareTag("Player"))
    {
        SceneManager.LoadScene(escena);
    }
   }
}
