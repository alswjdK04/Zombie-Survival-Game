using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Cam : MonoBehaviour
{
    public Transform target;
    float dist = 4.0f;
    float height = 3.0f;
    Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
    }
    void LateUpdate()
    {
        float yAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, Time.deltaTime);
        Quaternion rot = Quaternion.Euler(0, yAngle, 0);
        tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);
        tr.LookAt(target);
    }
}
*/


public class Cam : MonoBehaviour
{
    int dist = 6;
    int height = 20;
    public Transform player;
    Vector3 offset;
    void LateUpdate()
    {
        offset = player.forward * dist + Vector3.down * height;
        transform.position = Vector3.Lerp(transform.position, player.position - offset, 0.05f);
        transform.LookAt(player.transform);
        //transform.LookAt(player.transform).transform.position.nomalrized;
        //transform.position.normalized
    }
}


/*
    public class Cam : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    void Start()
    {
        offset = player.position - transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.position - offset;
        transform.LookAt(player);
    }
}
*/