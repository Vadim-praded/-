using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcScript : MonoBehaviour
{
    // hp npc
    public int heath = 5;

    //uroven npc
    public int level = 1;

    //skorost npc
    public float speed = 1.2f;

   
    void Start()
    {
        //k hp pribavlyaem level
        heath += level;
        //vivodim hp v koncol
        print(heath);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
