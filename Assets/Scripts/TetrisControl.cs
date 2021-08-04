using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisControl : MonoBehaviour
{
    public double movementSpeed;
    public double previousTime;
    public double fallTime;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        //player control
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            // transform.Translate(Vector2.right*movementSpeed);
            transform.position += new Vector3(-1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.position += new Vector3(1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            // transform.position += new Vector3(0,-1,0);
            fallTime = fallTime/10;
        }
        if(Input.GetKeyUp(KeyCode.DownArrow)){
            // transform.position += new Vector3(0,-1,0);
            fallTime = fallTime*10;
        }

        //fall
        if(Time.time - previousTime >= fallTime){
            transform.position += new Vector3(0,-1,0);
            previousTime = Time.time;
        }


    }






}
