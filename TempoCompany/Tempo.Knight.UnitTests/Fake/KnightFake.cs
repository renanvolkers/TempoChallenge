﻿using Tempo.Knight.Domain.Model;

namespace Tempo.Knight.UnitTests.Fake
{
    public static class KnightFake
    {
        public static List<Domain.Model.Knight> KnightList()
        {
            return new List<Domain.Model.Knight>
            {
                new Domain.Model.Knight
            {
                Id = Guid.NewGuid(),
                Name = "Arthur",
                Nickname = "The Brave",
                Birthday = new DateTime(1990, 1, 1),
                Weapons = new List<Weapon>(),
                KnightAttributes = new List <KnightAttribute>(),
                KeyAttribute = "Strength",
                CharacterType = "Warrior",
                CreatedBy="System"
            },
                new Domain.Model.Knight
            {
                Id = Guid.NewGuid(),
                Name = "August",
                Nickname = "The Brave",
                Birthday = new DateTime(1980, 3, 8),
                Weapons = new List<Weapon>(),
                KnightAttributes = new List < KnightAttribute >(),
                KeyAttribute = "Strength",
                CharacterType = "Warrior",
                CreatedBy = "System"
            }
            };

        }


        public static Domain.Model.Knight KnightSingle()
        {
            return new Domain.Model.Knight
            {
                Id = Guid.NewGuid(),
                Name = "Arthur",
                Nickname = "The Brave",
                Birthday = new DateTime(1990, 1, 1),
                Weapons = new List<Weapon>(),
                KnightAttributes = new List<KnightAttribute>(),
                KeyAttribute = "Strength",
                CharacterType = "Warrior",
                CreatedBy= "System"
            }; 

        }

    }
}
