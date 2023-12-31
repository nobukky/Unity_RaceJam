﻿using UnityEngine;
using System.Collections.Generic;

namespace AI
{
    [CreateAssetMenu(fileName = "NewAIStimulus", menuName = "AI/New AI Stimulus", order = 0)]
    public class AIStimulus : ScriptableObject
    {
        public List<string> tags = new List<string>();

        public bool HaveTag(string tag)
        {
            return this.tags.Contains(tag);
        }
    }
}