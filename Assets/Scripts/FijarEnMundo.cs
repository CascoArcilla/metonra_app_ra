using UnityEngine;
using Vuforia;

public class FijarEnMundo : MonoBehaviour
{
    public GameObject prefab;
    public Transform parent;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Colocar(Vector3 posicion, Quaternion rotacion)
    {
        Instantiate(prefab, posicion, rotacion, parent);
    }
}
