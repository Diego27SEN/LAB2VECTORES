using UnityEngine;

public class TransformacionManual : MonoBehaviour
{
    // Ejercicio 1
    public Vector3 direccion = new Vector3(0, 0, 1);
    public float velocidad = 7f;

    public Transform puntoCentro;
    private Vector3 posicionInicial;

    void Start()
    {
        if (puntoCentro != null)
        {
            posicionInicial = transform.position - puntoCentro.position;
        }
    }
    void Update()
    {
        Trasladar();

    }

    void Trasladar() // Ejercicio 1
    {
        Vector3 desplazamiento = direccion * velocidad * Time.deltaTime;
        transform.position = transform.position + desplazamiento;
    }
    
}