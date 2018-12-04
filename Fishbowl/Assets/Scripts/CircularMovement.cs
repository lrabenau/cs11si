using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    public Vector3 Velocity = new Vector3(0, 0, 0);
    //% public Vector3 CenterStart = new Vector3(0, 0, 0);

    [Range(0, 100)] 
    public float RotateSpeed = 1f;
    [Range(0, 100)]
    public float RotateRadiusX = 1f;
    [Range(0, 100)]
    public float RotateRadiusZ = 1f;

    public bool Clockwise = true;

    private Vector3 _centre;
    private float _angle;

    private void Start()
    {
//%  _centre = transform.position;
        _centre = new Vector3(transform.position.x,
                           transform.position.y,
                           transform.position.z);
    }

    private void Update()
    {
        _centre += Velocity * Time.deltaTime;

        _angle += (Clockwise ? RotateSpeed : -RotateSpeed) * Time.deltaTime;

        var x = Mathf.Sin(_angle) * RotateRadiusX;
        var z = Mathf.Cos(_angle) * RotateRadiusZ;

        transform.position = _centre + new Vector3(x, 0, z);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawSphere(_centre, 0.1f);
        Gizmos.DrawLine(_centre, transform.position);
    }
}
