using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brianAnimationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkForwardHash, isRunningHash;
    Vector3 velocity;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkForwardHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalkForward = animator.GetBool(isWalkForwardHash);
        // bool runPressed = Input.GetKey(KeyCode.O);
        // bool forwardPressed = Input.GetKey(KeyCode.I);
        
        animator.SetBool(isWalkForwardHash, true);
        animator.SetBool(isRunningHash, true);

        // //Walk Forward
        // if (!isWalkForward && forwardPressed)
        // {
        //     animator.SetBool(isWalkForwardHash, true);
        // }

        // if (isWalkForward && !forwardPressed)
        // {
        //     animator.SetBool(isWalkForwardHash, false);
        // }

        // //Run
        // if (!isRunning && (forwardPressed && runPressed))
        // {
        //     animator.SetBool(isRunningHash, true);
        // }

        // if (isRunning && (!forwardPressed || !runPressed))
        // {
        //     animator.SetBool(isRunningHash, false);
        // }
    }
}
