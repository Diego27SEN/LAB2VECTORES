using UnityEngine;

public class Asteroides : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 100f;

    void Update()
    {
    
        transform.Translate( Vector3.back * speed * Time.deltaTime,Space.World ); // movimiento hacia jugador

        transform.Rotate( rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, 0);     // rotación

        if (transform.position.z < -20)  // volver adelante
        {
            Vector3 pos = transform.position;
            pos.z = 80;
            transform.position = pos;
        }
    }
}