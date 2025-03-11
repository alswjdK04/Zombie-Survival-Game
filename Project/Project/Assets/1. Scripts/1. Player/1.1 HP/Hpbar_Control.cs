using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hpbar_Control : MonoBehaviour
{
    public List<Transform> obj;
    public List<GameObject> hp_bar;

    Camera camera;
    
    void Start()
    {
        camera = Camera.main;
        for (int i = 0; i < obj.Count; i++)
        {
            hp_bar[i].transform.position = obj[i].position;
        }
    }

    void Update()
    {
        for (int i = 0; i < obj.Count; i++)
        {
            hp_bar[i].transform.position = camera.WorldToScreenPoint(obj[i].position + new Vector3(0, 1f, 0));
        }
    }
}
