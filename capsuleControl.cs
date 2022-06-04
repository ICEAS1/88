using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleControl : MonoBehaviour
{
    // Start is called before the first frame update
    int hp = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeHp(){
        hp=hp-1;
        print("capsule: "+hp);
    }//ne rabotaet
}
