﻿using System;
using System.Linq.Expressions;
using DevChatter.GameTracker.Core.Model;

namespace DevChatter.GameTracker.Core.Data.Specifications
{
    /// <summary>
    /// Used for filtering Games based on specified criteria
    /// </summary>
    public class GamePolicy : BaseEntityPolicy<Game>
    {
        public GamePolicy(Expression<Func<Game, bool>> criteria) : base(criteria)
        {
        }

        public static GamePolicy ByTitle(string title)
        {
            return new GamePolicy(x => x.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}