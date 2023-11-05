using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject EvilRedGerm;
    [SerializeField]
    private GameObject BlueShrinkerGerm;

    [SerializeField]
    private float EvilRedGermInterval = 5.0f;
    [SerializeField]
    private float BlueShrinkerGermInterval = 5.0f;

    void Start()
    {
        StartCoroutine(spawEnemy(EvilRedGermInterval, EvilRedGerm));
        StartCoroutine(spawEnemy(BlueShrinkerGermInterval, BlueShrinkerGerm));
    }

    private IEnumerator spawEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-20f, 20f), Random.Range(-20f, 20f), 0), Quaternion.identity);
        StartCoroutine(spawEnemy(interval, enemy));
    }
}
