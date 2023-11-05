using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI TimeText;

    int time = 30;

    public void RemoveTime(int timeLeft)
    {
        time -= timeLeft;

        TimeText.text = ("Time: ") + time.ToString();
    }

    private void Update()
    {
        if (time == 0)
        {
            SceneManager.LoadScene(0);
        }
    }


}
