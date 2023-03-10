﻿namespace Binner.SwarmApi.Model
{
    public class PartNumberManufacturerParametric
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int PartNumberManufacturerParametricId { get; set; }

        /// <summary>
        /// The part number
        /// </summary>
        public int PartNumberManufacturerId { get; set; }

        /// <summary>
        /// The parametric name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// The type of parametric value
        /// </summary>
        public Model.ParametricTypes ParametricType { get; set; }

        /// <summary>
        /// The units that the parametric describes if applicable
        /// </summary>
        public Model.ParametricUnits? Units { get; set; }

        public double? ValueAsDouble { get; set; }
        public string? ValueAsString { get; set; }
        public bool? ValueAsBool { get; set; }

        /// <summary>
        /// The value of the field
        /// </summary>
        public object? Value => ValueAsDouble ?? (object?)ValueAsString ?? ValueAsBool;
    }
}
