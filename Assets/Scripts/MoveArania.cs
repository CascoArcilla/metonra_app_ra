using System.Diagnostics;
using UnityEngine;

public class MoveArana : MonoBehaviour
{
    [SerializeField] private float velocidad = 1.5f;
    [SerializeField] private float distanciaMaxima = 100f;
    [SerializeField] private Transform referencia;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        
        anim.SetBool("walk", true);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);

        if (referencia != null)
        {
            float distancia = Vector3.Distance(transform.position, referencia.position);

            if (distancia > distanciaMaxima)
            {
                Destroy(gameObject);
            }
        }
    }
}
