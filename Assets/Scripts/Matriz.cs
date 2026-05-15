using System;

public class Matriz
{
    public int filas;
    public int columnas;
    public double[,] datos;
    public Matriz(int f, int c)
    {
        filas = f;
        columnas = c;
        datos = new double[f, c];
    }

   
    public Matriz Sumar(Matriz b) //suma
    {
        if (filas != b.filas || columnas != b.columnas)
        {
            Console.WriteLine("Error: No se pueden sumar.");
            return null;
        }

        Matriz r = new Matriz(filas, columnas);

        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                r.datos[i, j] = datos[i, j] + b.datos[i, j];

        return r;
    }

   
    public Matriz Restar(Matriz b) //resta
    {
        if (filas != b.filas || columnas != b.columnas)
        {
            Console.WriteLine("Error: No se pueden restar.");
            return null;
        }

        Matriz r = new Matriz(filas, columnas);

        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                r.datos[i, j] = datos[i, j] - b.datos[i, j];

        return r;
    }

    public Matriz MultiplicarEscalar(double n) //escaalr
    {
        Matriz r = new Matriz(filas, columnas);

        for (int i = 0; i < filas; i++)
            for (int j = 0; j < columnas; j++)
                r.datos[i, j] = datos[i, j] * n;

        return r;
    }

    public double[] MultiplicarVector(double[] v) //Matriz *  vector
    {
        if (columnas != v.Length)
        {
            Console.WriteLine("Error: No coincide tamaño.");
            return null;
        }

        double[] r = new double[filas];

        for (int i = 0; i < filas; i++)
        {
            double suma = 0;
            for (int j = 0; j < columnas; j++)
                suma += datos[i, j] * v[j];

            r[i] = suma;
        }

        return r;
    }


    public Matriz MultiplicarMatriz(Matriz b) //matriz * matriz
    {
        if (columnas != b.filas)
        {
            Console.WriteLine("Error: No se pueden multiplicar.");
            return null;
        }

        Matriz r = new Matriz(filas, b.columnas);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < b.columnas; j++)
            {
                double suma = 0;

                for (int k = 0; k < columnas; k++)
                    suma += datos[i, k] * b.datos[k, j];

                r.datos[i, j] = suma;
            }
        }

        return r;
    }
    public void MostrarResultado()
    {
        for (int i = 0; i < filas; i++)
        {
            string fila = "";

            for (int j = 0; j < columnas; j++)
            {
                fila += datos[i, j] + " ";
            }

            UnityEngine.Debug.Log(fila);
        }
    }

}