using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
   
    [SerializeField] Animator animator;
    [SerializeField] int currentStamina;
    [SerializeField] int maxStamina;
    [SerializeField] StaminaBar staminaBar;
    [SerializeField] int custoAtk1;
    float staminaRecovery;

    float qtdeStamina = 100f;
    [SerializeField] PlayerMovement pm;

    void Start()
    {
        currentStamina = maxStamina;
        staminaBar.SetMaxValue(currentStamina);
    }

    // Update is called once per frame
    void Update()
    {
        Attack1();
        Attack2();
        Attack3();
        staminaRecovery = Mathf.Ceil(Time.time);
        if(staminaRecovery >= 10 && currentStamina < maxStamina)
        {
            currentStamina += 5;
            Debug.Log(currentStamina);
        }
    }

    private void Attack1(){
        bool inputAtk1 = Input.GetButtonDown("Fire1");
        if(inputAtk1 && pm.canIJump == true && currentStamina > custoAtk1){
            animator.SetTrigger("Attack 1");
            currentStamina -= custoAtk1;
            staminaBar.StaminaValue(currentStamina);
            staminaRecovery = 0;
        }
    }

     private void Attack2(){
        bool inputAtk2 = Input.GetButtonDown("Fire2");
        if(inputAtk2){
            animator.SetTrigger("Attack 2");
        }
    }

     private void Attack3(){
        bool inputAtk3 = Input.GetButtonDown("Fire3");
        if(inputAtk3){
            animator.SetTrigger("Attack 3");
        }
    }

    
}
