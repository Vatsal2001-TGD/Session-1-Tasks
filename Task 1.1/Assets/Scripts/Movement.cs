using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;

    private Vector3 targetPosition;
    private Vector3 Direction;
    public GameObject target;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            targetPosition = new Vector3(Random.Range(-16, 16), Random.Range(-8, 8), 0f); /*RandomPoint();*/

            target.transform.position = targetPosition;

            

            Direction = targetPosition - transform.position;
            float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg - 90f;
            
            transform.eulerAngles = angle * Vector3.forward;
            
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        
    }

    //private Vector3 RandomPoint()
    //{
        
    //    Vector3 randomPoint = new Vector3(Random.Range(-16, 16), Random.Range(-8, 8), 0f);
    //    return randomPoint;
    //}
}





