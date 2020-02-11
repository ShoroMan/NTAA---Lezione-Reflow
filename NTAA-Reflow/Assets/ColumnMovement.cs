using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMovement : MonoBehaviour
{
    public Transform giantColumn;
    Vector3 columnDistance;

    private void Start()
    {
         columnDistance = giantColumn.position - this.gameObject.transform.position;
    }

    void Update()
    {
        giantColumn.transform.position = Vector3.Lerp(giantColumn.transform.position, this.gameObject.transform.position + columnDistance, .5f * Time.deltaTime);
        giantColumn.rotation = Quaternion.Lerp(giantColumn.rotation, this.gameObject.transform.rotation, 5 * Time.deltaTime);
        if (gameObject.transform.rotation.z > 90 || gameObject.transform.rotation.z < -90 || gameObject.transform.rotation.x > 90 || gameObject.transform.rotation.x < -90)
        {
            giantColumn.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
