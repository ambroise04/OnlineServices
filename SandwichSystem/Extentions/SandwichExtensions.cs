﻿using SandwichSystem.BusinessLayer.Domain;
using SandwichSystem.Shared;
using SandwichSystem.Shared.BTO;
using SandwichSystem.Shared.DTO;
using System;
using System.Linq;

namespace SandwichSystem.BusinessLayer.Extentions
{
    public static class SandwichExtensions
    {
        public static SandwichBTO ToBTO(this Sandwich Sandwich, Language Langue)
        {
            return new SandwichBTO
            {
                Name = Sandwich.Name.ToString(Langue),
                Ingredients = String.Join(", ", Sandwich.Ingredients.Select(x => x.ToString(Langue)))
            };
        }

        public static Sandwich ToDomain(this SandwichDTO SandwichDTO)
        {
            return new Sandwich(new StringTranslated("traduction english", "traduction french", "traduction du"), SandwichDTO.Supplier.ToDomain())
            {
                Ingredients = SandwichDTO.Ingredients.Select(x => x.ToDomain()).ToList()
            };
        }
    }
}
