using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Spell {

    public int range = 4;
    public int radius = 2;
    public int damage = 10;

    void Start() {

        SpellType type = SpellType.AOE;
        powerCost = 2;

    }

    public override void Cast() {

        // specifically cast fireball a certain distance away for a certain number of damage

    }

}
