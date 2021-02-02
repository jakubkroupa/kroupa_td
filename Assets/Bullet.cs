using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public GameObject effect;
    private Transform target;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceFrame = speed * Time.deltaTime;
        if(dir.magnitude <= distanceFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceFrame, Space.World );
    }

    void HitTarget()
    {
        GameObject instEffect = (GameObject)Instantiate(effect, transform.position, transform.rotation);
        Destroy(target.gameObject);
        Destroy(instEffect, 3f);
        Destroy(gameObject);
    }
}
