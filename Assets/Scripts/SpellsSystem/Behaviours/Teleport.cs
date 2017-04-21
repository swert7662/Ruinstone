﻿using UnityEngine;
using System.Collections;
using System;

public class Teleport : Payload {
    public Transform blink { get; set; }

    void Start() {
        _abilityType = Types.Ability.DISPLACE;
        _areaType = Types.Area.POINT;
        _targetType = Types.Target.SELF;
    }

    public override void DoEffect(GameObject caster, Transform target) {
        this.target = target;
        Effect();
    }

    protected override void Effect() {
        //First target in targets should be self
        //Get move component
        //Call teleport or something
        Finish();
    }

    protected override IEnumerator DuraEffect() {
        yield return null;
    }

    protected override void Finish() {
        isDone = true;
    }
}
