using System;

namespace trifenix.versions.model
{
    /// <summary>
    /// Detalles de un commit y su versión
    /// </summary>
    public class CommitVersion {

        /// <summary>
        /// Rama del commit
        /// </summary>
        public string Branch { get; set; }


        /// <summary>
        /// Fecha en que se actualizó.
        /// </summary>
        public DateTime LastUpdate { get; set; }


        /// <summary>
        /// versión semántica.
        /// </summary>
        public Semantic SemanticBaseVersion { get; set; }

        /// <summary>
        /// Label de la versión
        /// </summary>
        public string PreReleaseLabel { get; set; }

        /// <summary>
        /// autonumérico que se incrementa, se usa en ramas que no son master.
        /// </summary>
        public int Preview { get; set; }

        /// <summary>
        /// Si una rama a modificar es dependant release, usará la versión del release.
        /// </summary>
        public bool DependantRelease { get; set; }

        /// <summary>
        /// Indica si una rama es feature.
        /// </summary>
        public bool IsFeature { get; set; }

        /// <summary>
        /// Build de azure devops
        /// </summary>
        public string Build { get; set; }

        /// <summary>
        /// genera la versión en string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Branch.ToLower().Equals("main") || Branch.ToLower().Equals("master"))
            {
                return $"{SemanticBaseVersion.Major}.{SemanticBaseVersion.Minor}.{SemanticBaseVersion.Patch}";
            }

            return $"{SemanticBaseVersion.Major}.{SemanticBaseVersion.Minor}.{SemanticBaseVersion.Patch}-{PreReleaseLabel}.{Preview}";
        }
    }


    public class CommitPackageVersion : CommitVersion {
        public string PackageName { get; set; }

    }


}
