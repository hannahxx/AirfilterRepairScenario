using UnityEngine;
using System.Collections;

public class filterchange : MonoBehaviour
{
    public bool connect = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v;
        v = transform.localPosition;
        if ((transform.localPosition.x >= -10.0f && transform.localPosition.x <= -8.0f) && (transform.localPosition.y >= 1.0f && transform.localPosition.y <= 3.0f) && (transform.localPosition.z >= -100.0f && transform.localPosition.z <= -98.0f))
        {
            connect = true;
        }
        //해당 오브젝트의 포지션값을 v에 넣고
        if (connect == true)
        {
            v.x = -9.578f;//원하는 값을 입력
            v.y = 2.084f;
            v.z = -99.127f;
            transform.localPosition = v;
            transform.rotation = Quaternion.Euler(1.1664f, 287.843f, 169.2583f);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Destroy(this.GetComponent<BoxCollider>());
        }

    }
}