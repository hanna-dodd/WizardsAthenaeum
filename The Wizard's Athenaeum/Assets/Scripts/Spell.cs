using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour {

    public enum SpellType {damage, AOE, buff};
    public int powerCost;
    
    private float successChange = 0.15f;

    public virtual void Cast() {

        // casting spell stuff that always happens

    }

}
