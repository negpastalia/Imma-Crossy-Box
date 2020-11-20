using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int timeEnemy = 1;
    public GameObject van;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        timeEnemy++;
        if(timeEnemy % 100 == 0){
            Instantiate(van, this.transform.position, this.transform.rotation);
        }
    }
}
