using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRB;


    // Start is called before the first frame update
    void Start()
    {
        targetRB = this.GetComponent<Rigidbody>();
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        targetRB.AddTorque(RandomTorque(), ForceMode.Impulse);
        this.transform.position = RandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        outOfBound();
    }
    
    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-4, 4), -2, 0);
    }

    public Vector3 RandomTorque()
    {
        return new Vector3(Random.value, Random.value, Random.value);
    }

    public Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(12, 16);
    }


    public void outOfBound()
    {
        if (this.transform.position.y <= -3f)
        {
            Destroy(this.gameObject);
        }
    }
 

    public void OnMouseDown()
    {
        Destroy(this.gameObject);
    }


    





}
