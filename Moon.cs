using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour {

    public float y;

	void Update () {

        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, y, 0);
        transform.Rotate(angle);

        /*
         * Vector3 pos = transform.position;
        pos.x = pos.x + 0.02f;
        transform.position = pos;
        */

    }
}
