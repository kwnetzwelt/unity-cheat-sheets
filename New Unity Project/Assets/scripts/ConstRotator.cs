using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstRotator : MonoBehaviour
{
    [SerializeField] private Vector3 axis;
    [SerializeField] private float speed;

	void Update () {
	    this.transform.Rotate(axis,speed * Time.deltaTime);
	}
}
