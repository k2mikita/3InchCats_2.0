using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    Camera m_MainCamera;

    void Start()
    {
        m_MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }


    // Update is called once per frame
    void Update()
    {
        m_MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        transform.LookAt(transform.position + m_MainCamera.transform.rotation * Vector3.back, m_MainCamera.transform.rotation * Vector3.up);
    }
}
