using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    public float time;
    public float timeToSpawn;
    public void Update()
    {
        time += Time.deltaTime;
        if(time > timeToSpawn)
        {
            time = 0f;
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
        yield return new WaitForSeconds(5);
    }
}

