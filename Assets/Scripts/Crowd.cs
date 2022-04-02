using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
    private Animator animator;
    public float minTime = 2f;
    public float maxTime = 5f;
    public float timeForAnim = 5f;
    public float timeBetween = 10f;
    private Vector3 startPos;
    private Quaternion startRot;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        startPos = transform.position;
        startRot = transform.rotation;

        if (!animator)
            Destroy(gameObject);

        StartCoroutine(startAnim());
    }

    private void Update()
    {
        transform.position = startPos;
    }
    
    IEnumerator startAnim()
    {
        var time = Random.Range(minTime, maxTime);
        yield return new WaitForSeconds(time);

        animator.SetTrigger("Start");
        StartCoroutine(waitAnimTime());
    }

    IEnumerator waitAnimTime()
    {
        var time = Random.Range(timeForAnim, timeForAnim + timeBetween);
        yield return new WaitForSeconds(time);

        
        transform.rotation = startRot;
        StartCoroutine(startAnim());
    }

    
}
