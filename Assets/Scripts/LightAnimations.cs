using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Repeatedly lerp rotate the object about the z axis over time. While lerping the Light component's color property back and forth between two colors.
public class LightAnimations : MonoBehaviour
{
    public Light light;
    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public float colorDuration = 1.0f;
    public float rotateDuration = 5.0f;

    private float colorStartTime;
    private float rotateStartTime;
    private float t;

    void Start()
    {
        colorStartTime = Time.time;
        rotateStartTime = Time.time;

        //Random rotate duration between 5 and 10 seconds
        rotateDuration = Random.Range(5.0f, 10.0f);

        //Random color duration between 1 and 3 seconds
        colorDuration = Random.Range(1.0f, 3.0f);
    }
    void Update()
    {
        //Handle color lerping
        t = (Time.time - colorStartTime) / colorDuration;
        if (t < 1f)
           light.color = Color.Lerp(color1, color2, t);
        else 
            colorStartTime = Time.time;

        //Handle globale rotation lerping
        t = (Time.time - rotateStartTime) / colorDuration;
        if (t < rotateDuration)
            transform.Rotate(Vector3.up, 180 * Time.deltaTime / rotateDuration);
        else
            rotateStartTime = Time.time;
    }   
}
