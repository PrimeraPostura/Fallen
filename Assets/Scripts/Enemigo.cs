using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;

    private Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        animator= GetComponent<Animator>();
    }


    // Update is called once per frame
    public void TomarDaño(float daño)

    {
        vida-=daño;

        if(vida<=0)
        {
            Muerte();
        }  
    }
    private void Muerte()
    {
        animator.SetTrigger("Muerte");
        Destroy(gameObject,1f);
        
    }
}
