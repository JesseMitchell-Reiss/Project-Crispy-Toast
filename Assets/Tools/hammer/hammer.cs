using UnityEngine;

public class hammer : MonoBehaviour
{
    // Return null from aiming
    public void Aim(Ray forward, Vector3 position, Quaternion rotation, bool down)
    {
        return;
    }

    // Destroy objects from hammer hit with fire
    public void Fire(Ray forward, Vector3 position, Quaternion rotation)
    {
        RaycastHit hit;
        bool hitSuccess = Physics.Raycast(forward, out hit, 1000.0f);
        Transform objectHit = hit.collider.transform;
        Vector3 hitPoint = hit.point;
        if (hitSuccess)
        {
            if (objectHit.tag == "Joint")
            {
                Destroy(objectHit.gameObject);
            }
        }
        return;
    }

    // Return null from instantiation
    public void Inst(Vector3 position, Quaternion rotation)
    {
        return;
    }
}
