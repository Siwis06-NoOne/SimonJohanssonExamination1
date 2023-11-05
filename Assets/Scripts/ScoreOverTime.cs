using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography.X509Certificates;

public class ScoreOverTime : MonoBehaviour
{
    [SerializeField] int scoreOverTime = 1;
    ScoreGiver points;

    private float update;

    private void Start()
    {
        points = FindObjectOfType<ScoreGiver>();
    }

    void Awake()
    {
        update = 0.0f;
    }
    private void Update()
    {
        {
            update += Time.deltaTime;
            if (update > 1.0f)
            {
                update = 0.0f;
                points.Addscore(scoreOverTime);
            }
        }
    }
}
