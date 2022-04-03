using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelAnimationScript : MonoBehaviour
{
    //Animator Property
    private Animator animator;

    private Quaternion startRot = Quaternion.Euler(0, 0, 0);
    private Vector3 startPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //Get the animator
        animator = GetComponent<Animator>();

        transform.localRotation = Quaternion.Euler(0, 0, 0);
        transform.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //Update the time property of the animator to the time this script has been running
        animator.SetFloat("Time", Time.time);

        transform.localRotation = startRot;
        transform.localPosition = startPos;
    }
}
