using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 模型基类,保存模型共同数据和方法
/// </summary>
public class ModelController : MonoBehaviour
{
    public SenceData.MODELTYPE TYPE; //模型类型

    protected Vector3 GetScreenPos(Vector3 worldPos)
    {
        return Camera.main.WorldToScreenPoint(worldPos);
    }

    [HideInInspector]
    public int collisionNum = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetType().Equals(typeof(BoxCollider)))
            collisionNum += 1;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.GetType().Equals(typeof(BoxCollider)))
            collisionNum -= 1;
    }


}
