using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCobtrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject capsule;
    Transform capsule_transform;
    public Transform capsule2_transform;
    public capsuleControl capsule_script;
    void Start()
    {
        capsule_transform=capsule.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        //Translate(10,10,10);
        //capsule_transform.Translate(-1f,0,0);
        capsule2_transform.Translate(-2,0,0);
        capsule_script.changeHp(); //thanks
    }
}
