﻿using UnityEngine;
using System.Collections;

public class NinjaClass : BaseClass
{

	public NinjaClass()
	{
        this._className = "Ninja";
        this._classDescription = "Test class Ninja";
        this._classStat.CurrentHp = 50;
        this._classStat.MaxHp = 50;

        //placeholder numbers
        this._classStat.MoveSpeed = 5;
        this._classStat.AtkPower = 20;
    }
}
