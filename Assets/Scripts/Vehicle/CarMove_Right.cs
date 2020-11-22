using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove_Right : MonoBehaviour
{
    public float speed;

    void Start(){
        this.transform.Rotate(0f, 180f, 0f);
    }

    void Update()
    {
        this.transform.Translate(new Vector3(0f, 0f, speed) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "CarDestroyerRight"){
            Destroy(this.gameObject);
        }
    }
}
