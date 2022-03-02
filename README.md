# The Wizard's Athenaeum

A regular workday at the Illusory Athenaeum is quickly turned into a magical crisis once Riley opens a long-forgotten tome, the ancient diary of Zoviar. Riley is thrown from the archives and must fight their way through magical enemies to save the patrons of the library, banish the evil wizard, and get their job back!

In The Wizard's Athenaeum, play as Riley, a frustrated archivist attempting to save her library from an evil wizard. Battle your way through each floor of the library up to the source of the wizard's power and destroy it. Collect spells and new tomes for your collection, rolling the dice of fate to mark your successes and failures. 

# Table of Contents:
1. [Level Design](#level)
2. [Enemies](#enemies)
3. [Spells](#spells)
    1. [Damaging Spells](#damage) 
        1. [Lightning Bolt](#lbolt) 
    2. [Area of Effect Spells](#aoe) 
        2. [Fireball](#fireball) 
    3. [Buffing Spells](#buff) 
        3. [Blessed](#blessed) 
4. [Sprites](#sprites)
5. [Current Bugs](#bugs)

## Level Design <a name="level"></a>

The library features four floors, each with distinctive enemies and visuals. Each floor includes 5 rooms that are procedurally generated. The generation system is shown within the unity project using placeholder sprites. 

Levels are generated in an 8 by 8 grid, with bookshelves, spell scrolls, and enemies randomly generated in the middle. There are ranges for how many of each item can be place in the level. The player always begins in the bottom left corner and the exit is always in the top right corner.

## Enemies <a name="enemies"></a>

Each section of the 

## Spells <a name="spells"></a>

There are three different categories of spells: damaging, area of effect, and buff. Each spell has benefits to the player. Spell scrolls are randomly generated throughout the library for the player to pick up and add to their spellbook. At the end of each run, the spellbook is wiped clean, causing the player to start fresh in a new run. As the player progresses and gains levels in the game, spells become easier to cast and higher level spells may be found.

### Damaging Spells <a name="damage"></a>

These spells causes damage to enemies in one instance.

#### Lightning Bolt <a name="lbolt"></a>

### Area of Effect Spells <a name="aoe"></a>

These spells cause damage in a area of the board, though are harder to handle.

#### Fireball <a name="fireball"></a>

### Buffing Spells <a name="buff"></a>

These spells increase the players abilities.

#### Blessed <a name="blessed"></a>

## Sprites <a name="sprites"></a>

## Current Bugs: <a name="bugs"></a>
* Floor sorting layer is not consistent
    * Enemies hide behind floor tiles
    * Player sometimes cannot pass through floor tiles
* 
