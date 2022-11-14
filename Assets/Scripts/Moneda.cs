using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    [SerializeField] private float puntos;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            ControladorPuntos.Instance.SumarPuntos(puntos);
            Destroy(gameObject);
        }
    }
}
