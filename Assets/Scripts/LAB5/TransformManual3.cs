using UnityEngine;

public class TransformManuall3 : MonoBehaviour
{
    // Ejercicio 3
    public float amplitud = 0.3f;
    public float frecuencia = 1f;

    public Transform puntoCentro;
    private Vector3 posicionInicial;
    void Start()
    {
        if (puntoCentro != null)
        {
            posicionInicial = transform.position - puntoCentro.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Escalar();
    }
    void Escalar()
    {
        float escala = 1 + Mathf.Sin(Time.time * frecuencia) * amplitud;

        Matrix4x4 matriz = Matrix4x4.identity;

        matriz[0, 0] = escala;
        matriz[1, 1] = escala;
        matriz[2, 2] = escala;

        Vector3 escalaFinal = new Vector3(
            matriz[0, 0],
            matriz[1, 1],
            matriz[2, 2]
        );

        transform.localScale = escalaFinal;
    }
}
