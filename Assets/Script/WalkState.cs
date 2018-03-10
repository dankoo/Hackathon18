using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : StateMachineBehaviour {
    Transform target;

    public float speed = 5.0f;
    public float rotationSpeed = 10.0f;

    CharacterController _controller;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        target = GameObject.Find("Player").transform;
        _controller = animator.gameObject.GetComponent<CharacterController>();
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        Vector3 dir = target.position - animator.transform.position;
        float distance = dir.magnitude;

        if(distance < 2.5f)
        {
            animator.SetTrigger("Attack");
        }
        else
        {
            dir.y = 0;
            _controller.SimpleMove(dir * speed * Time.deltaTime / distance);
            animator.transform.rotation = Quaternion.Lerp(
                                                animator.transform.rotation,
                                                Quaternion.LookRotation(dir),
                                                rotationSpeed * Time.deltaTime);
        }
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
