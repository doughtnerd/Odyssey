using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class SineWaveMove : MonoBehaviour {

    [SerializeField]
    private float amplitudeX = 10.0f;
    [SerializeField]
    private float amplitudeY = 5.0f;
    [SerializeField]
    private float omegaX = 1.0f;
    [SerializeField]
    private float omegaY = 5.0f;

    private float index;

    private Vector3 startPos;

    private void Start()
    {
        this.startPos = this.transform.position;
    }

    private void Update()
    {
        index += Time.deltaTime;
        float x = amplitudeX * Mathf.Cos(omegaX * index);
        //float y = Mathf.Abs(amplitudeY * Mathf.Sin(omegaY * index));
        float y = amplitudeY * Mathf.Sin(omegaY * index);
        transform.position = new Vector3(x + startPos.x, y + startPos.y, startPos.z);
    }
}