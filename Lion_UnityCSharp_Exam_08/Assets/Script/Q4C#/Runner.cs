using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    /// <summary>
    /// 到達目的地
    /// </summary>
    public delegate void Arrive();
    public event Arrive arrive;

    [Header("EndPos")]
    public GameObject PathA;
    [Header("Movingitem")]
    public GameObject Obj;
    [Header("MovingSpeed")]
    public float speed = 0.05f;
    private float firstSpeed;//紀錄第一次移動的距離

    private void Start()
    {
        firstSpeed = Vector3.Distance(Obj.transform.position, PathA.transform.position) * speed;
    }

    private void Update()
    {
        Obj.transform.position = Vector3.Lerp(Obj.transform.position, PathA.transform.position, speed);
        speed = NewSpeed();

        if (speed == 0)
        {
            arrive();
        }
    }

    /// <summary>
    /// 計算新距離
    /// </summary>
    /// <returns></returns>
    private float NewSpeed()
    {
        float ObjtoPathADistance = Vector3.Distance(Obj.transform.position, PathA.transform.position);
        //如果距離=0，NewSpeed也=0
        if (ObjtoPathADistance == 0)
            return ObjtoPathADistance;
        else
            return (firstSpeed / ObjtoPathADistance);
    }


}
