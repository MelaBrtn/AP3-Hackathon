//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP3_GestionHackathon
{
    using System;
    using System.Collections.Generic;
    
    public partial class HACKATHON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HACKATHON()
        {
            this.INSCRIRE = new HashSet<INSCRIRE>();
        }
    
        public int idhackathon { get; set; }
        public System.DateTime DateButoirInscrip { get; set; }
        public System.DateTime dateheuredebuth { get; set; }
        public System.DateTime dateheurefinh { get; set; }
        public string lieu { get; set; }
        public string ville { get; set; }
        public string conditions { get; set; }
        public string thematique { get; set; }
        public string affiche { get; set; }
        public string objectifs { get; set; }
        public Nullable<int> idorganisateur { get; set; }
        public int nbPlaceMax { get; set; }
    
        public virtual ORGANISATEUR ORGANISATEUR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCRIRE> INSCRIRE { get; set; }
    }
}
