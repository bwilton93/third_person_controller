using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BW
{
    public class PlayerMovement : MonoBehaviour
    {
        Transform cameraObject;
        InputHandler inputHandle;
        Vector3 moveDirection;

        [HideInInspector]
        public Transform myTransform;


        public new Rigidbody rigidbody;
        public GameObject normalCamera;

        [Header("Stats")]
        [SerializeField]
        float movementSpeed = 5f;
        [SerializeField]
        float rotationSpeed = 10f;

        void Start()
        {

        }
    }
}
