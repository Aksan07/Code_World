using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_spawner : MonoBehaviour
{
    public GameObject car;
    public float spawnRate=2;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        Spawn_vehicle();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate){
            timer=timer+Time.deltaTime;
        }
        else{
            Spawn_vehicle();
            timer=0;
        }
        
    }
    void Spawn_vehicle(){
        Instantiate(car,transform.position,transform.rotation);

    }
}
