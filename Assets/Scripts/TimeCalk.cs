using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography.X509Certificates;

public class TimeCalk : MonoBehaviour
{
    [SerializeField] int timeRemove = 1;
    Timer time;

    private float update;

    private void Start()
    {
        time = FindObjectOfType<Timer>();
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
                time.RemoveTime(timeRemove);
            }
        }
    }
}
