using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAnimationScript : MonoBehaviour
{
    //Animator Property
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Get the animator
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set position to 0, 0, 0
        transform.position = new Vector3(0, 0, 0);

        //Update the time property of the animator to the time this script has been running
        animator.SetFloat("Time", Time.time);
    }
}
