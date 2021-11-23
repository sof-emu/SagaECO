﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SagaDB.Actor;


namespace SagaMap.Skill.SkillDefinations.Monster
{
    public class RockStone : ISkill
    {
        public int TryCast(ActorPC pc, Actor dActor, SkillArg args)
        {
            return 0;
        }
        public void Proc(Actor sActor, Actor dActor, SkillArg args, byte level)
        {
            args.type = ATTACK_TYPE.BLOW;
            float factor = 0.8f;
            int lifetime = 5000;
            int rate = 5;

            if (SagaLib.Global.Random.Next(0, 99) < rate)
            {
                SkillHandler.Instance.PhysicalAttack(sActor, dActor, args, SagaLib.Elements.Neutral, factor);
                Additions.Global.Stone skill = new SagaMap.Skill.Additions.Global.Stone(args.skill, dActor, lifetime);
                SkillHandler.ApplyAddition(dActor, skill);
            }
        }
    }
}