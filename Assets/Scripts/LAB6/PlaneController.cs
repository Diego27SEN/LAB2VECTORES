using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10f;

    [Header("Rotation")]
    public float tiltAngle = 35f;
    public float rotationSmooth = 5f;

    [Header("Health")]
    public int maxHealth = 60;

    private int currentHealth;

    private Vector3 movement;

    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        Movement();
        Rotation();
    }

    void Movement()
    {
        float h = 0;
        float v = 0;

        if (Keyboard.current.aKey.isPressed)
            h = -1;

        if (Keyboard.current.dKey.isPressed)
            h = 1;

        if (Keyboard.current.wKey.isPressed)
            v = 1;

        if (Keyboard.current.sKey.isPressed)
            v = -1;

        movement = new Vector3(h, v, 0);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void Rotation()
    {
        Quaternion targetRotation = Quaternion.identity;

        float zTilt = -movement.x * tiltAngle;  // inclinación izquierda/derecha

        float xTilt = movement.y * tiltAngle; // inclinación arriba/abajo

        targetRotation = Quaternion.Euler(xTilt, 0, zTilt);

        transform.rotation = Quaternion.Slerp( transform.rotation, targetRotation, rotationSmooth * Time.deltaTime);  // Rotación suave usando Slerp
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            currentHealth -= 20;

            Debug.Log("Vida actual: " + currentHealth);

            Destroy(other.gameObject);

            if (currentHealth <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Debug.Log("GAME OVER");

        Destroy(gameObject);
    }

}