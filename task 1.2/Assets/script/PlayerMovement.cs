using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class PlayerMovement : MonoBehaviour
{
    public Transform FirstPoint;
    public Transform LastPoint;
    public float time;
    public float height;
    private Vector3 Firstplace;
    private Vector3 Lastplace;

    public void Start()
    {
        StartCoroutine(CurveMove());
    }


    private IEnumerator CurveMove()
    {
        Firstplace = FirstPoint.position;
        Lastplace = LastPoint.position;

        Vector3 PointOnCurve = Firstplace + (Lastplace - Firstplace)/2 + Vector3.up * height;

        for(float t = 0; t <1; t += Time.deltaTime / time)
        {
            Vector3 Point = Mathf.Pow(1 - t, 2) * Firstplace + 2 * t * (1 - t) * PointOnCurve + Mathf.Pow(t, 2) * Lastplace;
            Point += new Vector3(0, 0.5f, 0);
            transform.position = Point;
            
            yield return null;
        }
    }
}