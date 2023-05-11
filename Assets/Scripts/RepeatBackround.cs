using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackround : MonoBehaviour
{
    private Vector3 startPos; //the startPos variable to its actual starting position
    private float repeatWidth;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // access backround's collider and divide by 2
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth) //reset position if it moves a certain distance

        {
            transform.position = startPos;
        }
    }
}
