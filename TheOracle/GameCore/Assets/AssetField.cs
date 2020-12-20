﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace TheOracle.GameCore.Assets
{
    public class AssetField : IAssetField
    {
        public int Id { get; set; }

        public string Text { get; set; }
        public bool Enabled { get; set; }
        public List<InputField> InputFields { get; set; }

        public AssetField ShallowCopy()
        {
            var instance = (AssetField)this.MemberwiseClone();
            if (InputFields != null) instance.InputFields = InputFields.ConvertAll(s => s).ToList();

            return instance;
        }
    }
}