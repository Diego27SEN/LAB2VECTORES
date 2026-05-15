using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;

    private float score;

    void Update()
    {
        score += Time.deltaTime * 10;

        scoreText.text ="Score: " + Mathf.FloorToInt(score);
    }
}