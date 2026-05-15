using UnityEngine;

public class TestMatrices : MonoBehaviour
{
    void Start()
    {
        Matriz A = new Matriz(2, 2);
        Matriz B = new Matriz(2, 2);

        // Llenar A
        A.datos[0, 0] = 1; A.datos[0, 1] = 2;
        A.datos[1, 0] = 3; A.datos[1, 1] = 4;

        // Llenar B
        B.datos[0, 0] = 5; B.datos[0, 1] = 6;
        B.datos[1, 0] = 7; B.datos[1, 1] = 8;

        Debug.Log("SUMA:");
        Matriz suma = A.Sumar(B);
        if (suma != null) suma.MostrarResultado();

        
        Debug.Log("RESTA:");
        Matriz resta = A.Restar(B);
        if (resta != null) resta.MostrarResultado();

        
        Debug.Log("ESCALAR x2:");
        Matriz escalar = A.MultiplicarEscalar(2);
        escalar.MostrarResultado();

        
        Debug.Log("MULTIPLICACION:");
        Matriz multi = A.MultiplicarMatriz(B);
        if (multi != null) multi.MostrarResultado();

        
        Debug.Log("MATRIZ * VECTOR:");
        double[] vector = { 1, 2 };
        double[] resultadoV = A.MultiplicarVector(vector);

        if (resultadoV != null)
        {
            foreach (var v in resultadoV)
                Debug.Log(v);
        }
    }
}