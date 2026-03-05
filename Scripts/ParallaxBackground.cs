using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private GameObject cam;

    [SerializeField] private float parallaxEffect;

    private float xPosition;
    private float length;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        xPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceMoved = cam.transform.position.x * (1- parallaxEffect);
        //背景跟随移动的距离： cam.transform.position.x * parallaxEffect
        //摄像机移动的总距离： cam.transform.position.x
        //所以上式子是在计算摄像机把背景甩开了多远
        float distanceToMove = cam.transform.position.x * parallaxEffect;

        transform.position = new Vector3 (xPosition + distanceToMove,transform.position.y);

        if(distanceMoved > xPosition + length)
            xPosition = xPosition + length;
        else if(distanceMoved < xPosition - length)
            xPosition = xPosition - length;
    }
}
