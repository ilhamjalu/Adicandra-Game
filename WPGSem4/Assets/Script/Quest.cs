using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public Transform target;
    public Vector2 worldPosMin = new Vector2(-10f, -10f);
    public Vector2 worldPosMax = new Vector2(10f, 10f);

    void Update()
    {
        if (target != null)
        {
            Vector2 targetPos = target.transform.position;

            float x = Mathf.Clamp(targetPos.x, worldPosMin.x, worldPosMax.x);
            float y = Mathf.Clamp(targetPos.y, worldPosMin.y, worldPosMax.y);

            transform.position = new Vector3(x, y, transform.position.z);
        }
    }
}
