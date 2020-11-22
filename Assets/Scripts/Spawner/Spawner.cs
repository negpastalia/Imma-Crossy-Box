using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int timeEnemy = 1;
    public GameObject[] car;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        int choice;
        choice = Random.Range(0, car.Length);

        timeEnemy++;
        if(timeEnemy % 250 == 0){
            Instantiate(car[choice], this.transform.position, this.transform.rotation);
        }
    }
}
