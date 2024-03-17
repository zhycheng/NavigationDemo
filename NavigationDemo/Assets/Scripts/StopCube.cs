using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCube : MonoBehaviour
{
    float maxX = 16;
    float minX = -16;
    bool isUp = true;
    float speedV = 3f;
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
        if(isUp==true)
        {
            if(this.transform.position.x<16.0f)
            {
				isUp = true;
			}
            else
            {
                isUp = false;

			}
        }
        else
        {
			if (this.transform.position.x > -16.0f)
			{
				isUp = false;
			}
			else
			{
				isUp = true;

			}
		}
        if(isUp)
        {
            speed = speedV;

		}
        else
        {
			speed=-speedV;

		}
        Vector3 v3 = this.transform.position;
        this.transform.position = new Vector3(v3.x+Time.deltaTime*speed,v3.y,v3.z);

	}
}
