using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch box in Input.touches)
            if (box.phase == TouchPhase.Moved)
            {
                transform.Rotate(new Vector3(0, -box.deltaPosition.x, 0));


            }

    }
}