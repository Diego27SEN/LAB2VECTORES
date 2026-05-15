using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class PlaneController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10f;

    [Header("Screen Limits")]
    public float xLimit = 8f;
    public float yLimit = 4f;

    [Header("Rotation")]
    public float tiltAngle = 35f;
    public float rotationSmooth = 5f;

    [Header("Health")]
    public int lives = 3;

    private Vector3 movement;

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

        transform.Translate(movement * moveSpeed * Time.deltaTime,Space.World);

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -xLimit, xLimit);
        pos.y = Mathf.Clamp(pos.y, -yLimit, yLimit);

        transform.position = pos;
    }

    void Rotation() // inclinar el avión según el movimiento para dar sensación de vuelo
    {
        float zTilt = -movement.x * tiltAngle;

        float xTilt = movement.y * tiltAngle;

        Quaternion targetRotation =
            Quaternion.Euler(xTilt, 0, zTilt);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSmooth * Time.deltaTime); // suavizar rotación
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            lives--;

            Debug.Log("Vidas restantes: " + lives);

            Destroy(other.gameObject);

            if (lives <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Debug.Log("GAME OVER");

        Destroy(gameObject);
        ReiniciarNivel();
    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}