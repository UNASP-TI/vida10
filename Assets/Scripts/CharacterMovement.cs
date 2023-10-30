using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character0Movement : MonoBehaviour {
    public float CharacterSpeed;
    private Rigidbody2D characterRigidbody;
    private Vector3 characterSpaceDelta;
    private Animator characterAnimator;

    void Start() {
        characterAnimator = GetComponent<Animator>();
        characterRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        characterSpaceDelta = Vector3.zero;
        characterSpaceDelta.x = Input.GetAxisRaw("Horizontal");
        characterSpaceDelta.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove() {
        if (characterSpaceDelta != Vector3.zero) {
            MoveCharacter();
            characterAnimator.SetFloat("moveX", characterSpaceDelta.x);
            characterAnimator.SetFloat("moveY", characterSpaceDelta.y);
            characterAnimator.SetBool("moving", true);
        }
        else {
            characterAnimator.SetBool("moving", false);
        }
    }

    void MoveCharacter() {
        characterRigidbody.MovePosition(
            transform.position + characterSpaceDelta * CharacterSpeed * Time.deltaTime
        );
    }
}
