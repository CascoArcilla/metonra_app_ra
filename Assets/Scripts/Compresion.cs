using UnityEngine;

public class Compresion : MonoBehaviour
{
    [SerializeField] private Transform referencia;
    [SerializeField] private float distanciaMaxima = 100f;
    [SerializeField] private float velocidad = 90f;
    private float distanciaRecorrida = 0f;

    void Update()
    {
        if (referencia != null)
        {
            float distanciaActual = Vector3.Distance(transform.position, referencia.position);

            if (distanciaRecorrida <= distanciaMaxima)
            {
                Vector3 direccion = (referencia.position - transform.position).normalized;
                transform.Translate(direccion * velocidad * Time.deltaTime);
            }
        }
    }
}
