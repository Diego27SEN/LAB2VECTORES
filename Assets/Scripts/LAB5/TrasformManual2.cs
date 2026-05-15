using UnityEngine;

public class TrasformManual2 : MonoBehaviour
{
    // Ejercicio 2
    public float velocidadRotacion = 40f;
    private float anguloActual = 0f;
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
        Rotar2D();
    }
    void Rotar2D()// Ejercicio 2
    {
        if (puntoCentro == null) return;

        anguloActual += velocidadRotacion * Time.deltaTime;
        float rad = anguloActual * Mathf.Deg2Rad;

        float x = posicionInicial.x;
        float y = posicionInicial.y;

        float nuevoX = x * Mathf.Cos(rad) - y * Mathf.Sin(rad);
        float nuevoY = x * Mathf.Sin(rad) + y * Mathf.Cos(rad);

        Vector3 nuevaPos = new Vector3(nuevoX, nuevoY, posicionInicial.z);

        transform.position = puntoCentro.position + nuevaPos;
    }

   
}
