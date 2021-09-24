using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    void Awake()
    {
        scoreText.text = "Score:";
        //registra evento
        Asteroid.DestroyAsteroid += DestroyAsteroid;
    }

    void OnDestroy()
    {
        //remove evento
        Asteroid.DestroyAsteroid -= DestroyAsteroid;
    }

    void DestroyAsteroid()
    {
        score += 100;
        ScoreUpdate();
    }

    void ScoreUpdate()
    {
        scoreText.text = $"Score: {score.ToString()}";
    }
}
