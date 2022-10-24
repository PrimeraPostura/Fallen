using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ValidarUsuario : MonoBehaviour
{
    public Text cajaNombre;
    public Text cajaEdad;
    string Nombre;
    byte Edad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Validar(){
        Nombre=cajaNombre.text;
        //Interger.parseInt("8")
        Edad = byte.Parse(cajaEdad.text);
        if(Edad>=18){
        SceneManager.LoadScene("escena1");
        }
        else{
            Debug.Log($"Usted es muy chico {Edad}");
        }
    }
}

