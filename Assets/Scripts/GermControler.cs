using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class GermControler : MonoBehaviour
{
    public float germFastSpeed = 0.0f;
    public float germSlowSpeed = 0.0f;
    public float sizeChange = 0.0f;

    void Update()
    {
        //Use this to decide if a germ is supose to move fast or slow
        //(EX) If germFastSpeed = 2 then it will move twice as fast or (-1f and 1f) in a random direction

        if (germFastSpeed != 0.0f)
        {
            transform.position = transform.position + Time.deltaTime * new Vector3(Random.Range(-.05f * germFastSpeed, .05f * germFastSpeed), Random.Range(-.05f * germFastSpeed, .05f * germFastSpeed), Random.Range(0, 0));
        }
        if (germSlowSpeed != 0.0f)
        {
            transform.position = transform.position + Time.deltaTime * new Vector3(Random.Range(-.02f * germSlowSpeed, .02f * germSlowSpeed), Random.Range(-.02f * germSlowSpeed, .02f * germSlowSpeed), Random.Range(0, 0));

        }
        if (sizeChange != 0.0f)
        {
            transform.localScale = transform.localScale + Time.deltaTime * new Vector3(Random.Range(-.002f, .002f), Random.Range(-.002f, .002f), 0);
        }
    }
}
