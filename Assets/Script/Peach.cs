using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peach : SuperHero
{
    //SpecialAbility
    public  void SpecialAbility()
    {
        Debug.Log("Sleep");
    }
    public void PeachMove()
    {
        Debug.Log("Walk");

    }
    public void PeachAttack()
    {
       Debug.Log("Punch");

    }

    //override
    public override void Move()
    {
        PeachMove();
    }
    public override void Attack()
    {
        PeachAttack();
    }
    public override void Start()
    {
        base.Start();
        Move();
        Attack();
        SpecialAbility();
    }
}
