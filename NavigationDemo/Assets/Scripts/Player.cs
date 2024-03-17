using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent   agent;
    // Start is called before the first frame update
    public GameObject obstacle;
    void Start()
    {
		agent=GetComponent<NavMeshAgent>();

	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
             if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out RaycastHit hit))
            {
                Debug.Log(hit.collider.name);
                agent.isStopped = false;
                agent.SetDestination(hit.point);

			}
            if(Input.GetKeyUp(KeyCode.Space))
            {
                agent.isStopped = true;
            }
           
		}
		if (Input.GetKeyUp(KeyCode.X))
		{
			obstacle.SetActive(false);

		}
		if (Input.GetKeyUp(KeyCode.Z))
		{
			obstacle.SetActive(true);
		}
	}
}
