﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get; }

        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// Жиры.
        /// </summary>
        public double Fats { get; }
        public double Carbohydates { get; }

        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Калории за 100 грамм продукта.
        /// </summary>
        public double Calories { get; }

        public Food(string name) : this(name, 0, 0, 0, 0)
        {
        }

        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            // TODO: проверка.

            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydates = carbohydrates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
