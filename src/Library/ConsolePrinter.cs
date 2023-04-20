//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID.Library
{

    public class ConsolePrinter 
    // La implementación de esta clase se basa en el Principio SRP, ya que tiene una única responsabilidad de imprimir la receta en la consola. 
    // Además utiliza el Patrón Expert, ya que tiene acceso a la información necesaria para imprimir la receta (que está dentro de Receipe).
    {

        private string Message;

        public ConsolePrinter(Recipe recipe)
        {
            this.Message = $"Receta de {recipe.FinalProduct.Description}:";
            foreach (Step step in recipe.steps)
            {
                this.Message += $"\n{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}";
            }
        }

        public void PrintRecipe()
        {
            Console.WriteLine(this.Message);
        }
    }
}
