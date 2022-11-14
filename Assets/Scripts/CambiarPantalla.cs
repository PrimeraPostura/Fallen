using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Cambiar de escena
using UnityEngine.SceneManagement;
public class CambiarPantalla : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cambiar(){
        SceneManager.LoadScene("Formulario");

    }
    public void Reintentar(){
        SceneManager.LoadScene("Inicio");

    }
    public void Creditos(){
        SceneManager.LoadScene("Creditos");
    }
}
