using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logicScript;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();  
        // get the logicScript on runtime, this is because the middle trigger between the pipe is on a prefab (which we can't put the ref via unity UI)
        // this is because prefab objects are created on runtime, not initiated on the beginning

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)  // layer 3 is defined on Unity as "Bird" layer, and attached to the Bird object itself
        {
            logicScript.addScore(1);
        }
    }
}
