using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public float Cameraspeed;
    public Transform Target;
public float minX ,minY;
public float maxX,maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){

        if(Target!=null){
       Vector2 newcamPosition = Vector2.Lerp(transform.position,Target.position,Time.deltaTime * Cameraspeed);
       float ClampX =Mathf.Clamp(newcamPosition.x,minX,maxX);
       float ClampY =Mathf.Clamp(newcamPosition.y,minY,maxY);
        }
}
}
