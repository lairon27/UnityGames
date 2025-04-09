using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //camera position should be the same as the car's position 

    [SerializeField] GameObject thingToFollow;
    Vector3 vector3 = new(0, 0, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + vector3;
    }
}
