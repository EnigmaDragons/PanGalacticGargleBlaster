using UnityEngine;

namespace Assets.Scripts
{
    public class RotateTowards : MonoBehaviour
    {
        public GameObject Target;
        public float RotationSpeed;

        public void Update()
        {
            var targetDirection = Target.transform.position - transform.position;
            var rotateAmt = RotationSpeed * Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(transform.forward, targetDirection, rotateAmt, 0.0f));
        }
    }
}
