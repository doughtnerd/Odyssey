using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Spin : MonoBehaviour {

    [SerializeField]
    private Vector3 direction = Vector3.zero;

	void Update () {
        transform.Rotate(direction);
	}
}
