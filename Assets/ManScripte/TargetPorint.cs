using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// 这是目标点
/// </summary>
public class TargetPorint : MonoBehaviour
{
    public Vector3 p;
    private void Start()
    {
        p = this.transform.position;
    }
}
