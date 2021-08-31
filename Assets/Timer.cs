using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Essential for using SceneManager
using UnityEngine.SceneManagement; 

public class Timer : MonoBehaviour
{
    public float MaxTime=60f;
    [SerializeField] public float CountDown=0f;
    // Start is called before the first frame update
    void Start()
    {
        CountDown=MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        CountDown-=Time.deltaTime;
        if(CountDown<=0){
            Coin.count=0;
            //restarts active scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
            //in case if you are wandering, this won't work
            //SceneManager.LoadScene();
        }
    }
}
