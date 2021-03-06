﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Core;
using RAIN.Action;
using RAIN.Representation;

[RAINAction]
public class AISetMode0 : RAINAction 
{
	public Expression enemy;
	private Mode enemyMode = null;
	private GameObject enemyObject = null;
	
	public AISetMode0() 
	{
		actionName = "AISetMode0";
	}
	
	public override void Start(AI ai)
	{
		enemyObject = enemy.Evaluate(ai.DeltaTime, ai.WorkingMemory).GetValue<GameObject>();
		if (enemyObject != null)
			enemyMode = enemyObject.GetComponent<Mode>();
		
		base.Start(ai);
		
	}
	
	public override ActionResult Execute(AI ai)
	{
		if (enemyMode == null){
			ai.WorkingMemory.SetItem("mode", 0f);
			return ActionResult.SUCCESS;
		}
		enemyMode.set0();
		ai.WorkingMemory.SetItem("mode", enemyMode.mode);
		
		return ActionResult.SUCCESS;
		
	}
}





