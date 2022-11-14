using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CombateJugador : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarraDeVida barraDeVida;


    private void Start()
    {
        vida=maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);
    }

    
    public void TomarDaño(float daño)
    {
        vida-=daño;
        barraDeVida.CambiarVidaActual(vida);
        if(vida<=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void Curar(int curacion)
    {   vida+=curacion;
        barraDeVida.CambiarVidaActual(vida);
        if((vida+ curacion)>maximoVida)
        {
            vida=maximoVida;
        }
        else
        {
            vida+=curacion;
        }
    }

}
