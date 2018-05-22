using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;


	void Start () {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];

    }
	
	
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (Vector3.Distance (transform.position,currentPatrolPoint.position) < .1f)
        {
            if (currentPatrolIndex + 1 < patrolPoints.Length)
            {
                currentPatrolIndex++;
            }
            else
            {
                currentPatrolIndex = 0;
            }
            currentPatrolPoint = patrolPoints[currentPatrolIndex];
        }
        //dit is dat hij naar zijn patrolpoint kijkt <3
        Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
        float angle = Mathf.Atan2(patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg - 0f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 50f);
    }

   

}
