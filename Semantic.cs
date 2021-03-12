using System;

namespace trifenix.versions.model
{
    public class Semantic : IComparable<Semantic>, IEquatable<Semantic> {
        /// <summary>
        /// Sección Major de la versión semántica
        /// </summary>
        public int Major { get; set; }

        /// <summary>
        /// Sección Minor de la versión semántica
        /// </summary>
        public int Minor { get; set; }

        /// <summary>
        /// Sección Patch de la versión semántica
        /// </summary>
        public int Patch { get; set; }

        public int CompareTo(Semantic other)
        {
            if (Equals(other)) return 0;
            if (Major > other.Major) return 1;
            if (Minor > other.Minor) return 1;
            if( Patch > other.Patch) return 1;
            return -1;

        }

        public bool Equals(Semantic other)
        {
            return Major == other.Major && Minor == other.Minor && Patch == other.Patch;
        }
    }


}
