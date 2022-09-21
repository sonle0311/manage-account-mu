using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class QuestWorld
    {
        public string Name { get; set; } = null!;
        public byte[]? QuestWorldList { get; set; }
    }
}
