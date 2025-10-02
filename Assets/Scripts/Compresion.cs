using UnityEngine;

public class Compresion : MonoBehaviour
{
    [SerializeField] private Transform referencia;

    void Update()
    {
        if (referencia != null)
        {
            float distancia = Vector3.Distance(transform.position, referencia.position);
            if (distancia < 50f)
            {
                Destroy(gameObject);
            }
        }
    }
}
