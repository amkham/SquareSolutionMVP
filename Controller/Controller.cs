using System;
using SquareSolution;

namespace SquareSolution
{
    public class Controller
    {
        private Model.Model __model;

        public Controller(Model.Model model)
        {
            __model = model;
        }

        internal void solution(double a, double b, double c)
        {
            __model.Solution(a, b, c);
        }
    }
}