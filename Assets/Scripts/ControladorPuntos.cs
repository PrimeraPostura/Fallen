using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorPuntos : MonoBehaviour
{
 public static ControladorPuntos Instance;


 [SerializeField] private float cantidadPuntos;


 private void Awake()
 {
    if(ControladorPuntos.Instance == null)
    {
        ControladorPuntos.Instance = this;
        DontDestroyOnLoad(this.gameObject);
    
    }
    else
    {
        Destroy(gameObject);
    }
 }
 public void SumarPuntos(float puntos)
 {
    cantidadPuntos+=puntos;
 }
}

