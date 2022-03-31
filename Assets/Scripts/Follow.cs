using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform target;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = target.position;
        gameObject.transform.rotation = target.rotation;
    }
}
