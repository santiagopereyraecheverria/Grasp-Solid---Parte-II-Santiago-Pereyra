//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

// Recipe.cs
using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        public Recipe()
        {
            Steps = new List<Step>();
        }

        public Product FinalProduct { get; set; }
        public List<Step> Steps { get; set; }

        // Al mover la impresión fuera de la clase Recipe, segui el principio de SRP
        // manteniendo cada clase con una única razón para cambiar.
        public void AddStep(Step step)
        {
            Steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            Steps.Remove(step);
        }
    }
}
