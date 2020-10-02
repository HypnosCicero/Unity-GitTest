using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

/// <summary>
/// 这是画线类
/// </summary>
public class Line : MonoBehaviour
{
    private string str = "Second"; 
    public GameObject obj1,obj2;
    public LineRenderer lin;
    public float LineSize = 0.5f;
   // public UnityEngine.Color color=UnityEngine.Color.green;
   // public List<Vector3> Positions = new List<Vector3>();
    private void OnGUI()
    {
        if (GUILayout.Button("画线")) {
            TargetPorint[] Points = Object.FindObjectsOfType<TargetPorint>();
            //lin.material = new Material(Shader.Find("Particles/Additive"));
            obj1.transform.position = Points[0].p;
            obj2.transform.position = Points[1].p;
            lin.SetPosition(0, obj1.transform.position);
            lin.SetPosition(1, obj2.transform.position);
        }
    }
}
