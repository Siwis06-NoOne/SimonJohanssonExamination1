using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGiver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;

    int score = 0;

    public void Addscore(int scoreToAdd)
    {
        score += scoreToAdd;

        ScoreText.text = ("score: ") + score.ToString();
    }
}
