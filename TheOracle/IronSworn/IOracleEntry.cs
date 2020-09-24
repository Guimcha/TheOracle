﻿namespace TheOracle
{
    public interface IOracleEntry
    {
        int d { get; set; }
        OracleType type { get; set; }
        int Chance { get; set; }
        string Description { get; set; }
    }
    public enum OracleType 
    {
        standard,
        nested,
        multipleColumns
    }
}