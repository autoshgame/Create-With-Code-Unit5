using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] protected List<GameObject> targets;

    private float spawnDelay = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator SpawnTarget()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnDelay);
            int targetIndex = Random.Range(0, targets.Count);
            Instantiate(targets[targetIndex], targets[targetIndex].transform.position, targets[targetIndex].transform.rotation );
        }
    }

}
