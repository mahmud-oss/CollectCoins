using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : MonoBehaviour
{
    public static int count=0;
    // Start is called before the first frame update
    void Start()
    {
        ++Coin.count;
       //Debug.Log("Object created") ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    void onDestroy(){
        --Coin.count;
        Debug.Log(Coin.count);
        if(Coin.count<=0){
            GameObject Timer= GameObject.Find("LevelTimer");
            Destroy(Timer);

            GameObject[] FireworkSystems=GameObject.FindGameObjectsWithTag("Fireworks");
            Console.WriteLine(FireworkSystems);
            Debug.Log(FireworkSystems);
            if(FireworkSystems.Length<=0){
                return;
            }
            foreach(GameObject GO in FireworkSystems){
                GO.GetComponent<ParticleSystem>().Play();
            }
        }
    }

    void OnTriggerEnter(Collider Col){
        //Debug.Log("Enter night, Exit light");

        //compare tag
        if(Col.CompareTag("Player")){
            Destroy(gameObject);
            onDestroy();
        }

        
        
    }
}
