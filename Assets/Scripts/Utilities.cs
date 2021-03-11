using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    public static Vector3 Wrap(Vector3 v, Vector3 min, Vector3 max)
    {
        Vector3 result = v;

        if (v.x > max.x) result.x = min.x + (max.x - v.x);
        else if (v.x < min.x) result.x = max.x - (min.x - v.x);

        if (v.y > max.y) result.y = min.y + (max.y - v.y);
        else if (v.y < min.y) result.y = max.y - (min.y - v.y);

        if (v.z > max.z) result.z = min.z + (max.z - v.z);
        else if (v.z < min.z) result.z = max.z - (min.x - v.z);

        return result;
    }

    public static float Dot(Vector3 v1, Vector3 v2)
    {
        return (v1.x * v2.x + v1.y * v2.y + v1.z *v2.z);
    }

    public static void Lerp(Transform start, Transform end, Transform result, float t)
    {
        result.position = Vector3.Lerp(start.position, end.position, t);
        result.rotation = Quaternion.Lerp(start.rotation, end.rotation, t);
    }
}
