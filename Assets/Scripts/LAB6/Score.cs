using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text infoText;

    public PlaneController player;

    private float score;

    void Update()
    {
        if (player == null) return;
        score += Time.deltaTime * 10; // aumenta score con tiempo

        infoText.text = "Score: " + Mathf.FloorToInt(score) + "\nVidas: " + player.lives;  // mostrar score + vidas
    }
}