﻿using Discord;

namespace TheOracle.GameCore.Assets
{
    public interface IAssetEmbedField
    {
        public EmbedField ToDiscordEmbedField();
    }

    public class AssetEmbedField : IAssetEmbedField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActiveText { get; set; }
        public string InactiveText { get; set; }
        public bool IsActive { get; set; }

        public EmbedField ToDiscordEmbedField()
        {
            throw new System.NotImplementedException();
        }
    }
}