//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services_DSI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESP_ETUDIANT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESP_ETUDIANT()
        {
            this.ESP_INSCRIPTION = new HashSet<ESP_INSCRIPTION>();
        }
    
        public string ID_ET { get; set; }
        public string NOM_ET { get; set; }
        public string PNOM_ET { get; set; }
        public Nullable<System.DateTime> DATE_NAIS_ET { get; set; }
        public string LIEU_NAIS_ET { get; set; }
        public string NATURE_ET { get; set; }
        public string FONCTION_ET { get; set; }
        public string ADRESSE_ET { get; set; }
        public string TEL_ET { get; set; }
        public string TEL_PARENT_ET { get; set; }
        public string E_MAIL_ET { get; set; }
        public string CYCLE_ET { get; set; }
        public string NATURE_BAC { get; set; }
        public Nullable<System.DateTime> DATE_BAC { get; set; }
        public string NUM_BAC_ET { get; set; }
        public string ETAB_BAC { get; set; }
        public string DIPLOME_SUP_ET { get; set; }
        public Nullable<decimal> NIVEAU_DIPLOME_SUP_ET { get; set; }
        public string ETAB_ORIGINE { get; set; }
        public string SPECIALITE_ESP_ET { get; set; }
        public Nullable<System.DateTime> DATE_ENTREE_ESP_ET { get; set; }
        public string ANNEE_ENTREE_ESP_ET { get; set; }
        public string CLASSE_COURANTE_ET { get; set; }
        public string SITUATION_FINANCIERE_ET { get; set; }
        public Nullable<bool> NIVEAU_COURANT_ET { get; set; }
        public Nullable<decimal> MOYENNE_DERN_SEMESTRE_ET { get; set; }
        public string RESULTAT_FINAL_ET { get; set; }
        public string DIPLOME_OBTENU_ESP_ET { get; set; }
        public Nullable<System.DateTime> DATE_SORTIE_ET { get; set; }
        public string OBSERVATION_ET { get; set; }
        public string SEXE { get; set; }
        public string NATIONALITE { get; set; }
        public string NUM_CIN_PASSEPORT { get; set; }
        public Nullable<System.DateTime> DATE_SAISIE { get; set; }
        public Nullable<System.DateTime> DATE_DERN_MODIF { get; set; }
        public string AGENT { get; set; }
        public string NUM_ORD { get; set; }
        public Nullable<System.DateTime> DATE_DELIVRANCE { get; set; }
        public string LIEU_DELIVRANCE { get; set; }
        public Nullable<bool> NIVEAU_ACCES { get; set; }
        public string NATURE_COURS { get; set; }
        public string NATURE_PIECE_ID { get; set; }
        public string ADRESSE_PARENT { get; set; }
        public string CP_PARENT { get; set; }
        public string VILLE_PARENT { get; set; }
        public string PAYS_PARENT { get; set; }
        public string CP_ET { get; set; }
        public string VILLE_ET { get; set; }
        public string PAYS_ET { get; set; }
        public string E_MAIL_PARENT { get; set; }
        public string TEL_PARENT { get; set; }
        public string TYPE_ENREG_ET { get; set; }
        public string DATE_LIEU_NAIS { get; set; }
        public string CODE_ETAB_ORIGINE { get; set; }
        public string CODE_SPEC_ORIGINE { get; set; }
        public string LIB_SPEC_ORIGINE { get; set; }
        public string CLASSE_PREC_ET { get; set; }
        public string ID_ET_ORIGIN { get; set; }
        public string ETAT { get; set; }
        public string JUSTIF_ETAT { get; set; }
        public string LIB_JUSTIF_ETAT { get; set; }
        public string ID_ET_NEW { get; set; }
        public string ID_ET_ORIGINE { get; set; }
        public Nullable<System.DateTime> DATE_LAST_CHANGE_ETAT { get; set; }
        public string DERN_UTILISATEUR { get; set; }
        public string NUMCOMPTE { get; set; }
        public string BANQUE { get; set; }
        public string RIB_BANQUE { get; set; }
        public string MP08 { get; set; }
        public string TYPE_ET { get; set; }
        public string CODE_NATIONALITE { get; set; }
        public Nullable<short> NUMPROMOTIONCS { get; set; }
        public string CODE_DECISION_SESSION_P_AP1 { get; set; }
        public string LIB_DECISION_SESSION_P_AP1 { get; set; }
        public string CODE_DECISION_SESSION_R_AP1 { get; set; }
        public string LIB_DECISION_SESSION_R_AP1 { get; set; }
        public string CODE_DECISION_SESSION_P_AP2 { get; set; }
        public string LIB_DECISION_SESSION_P_AP2 { get; set; }
        public string CODE_DECISION_SESSION_R_AP2 { get; set; }
        public string LIB_DECISION_SESSION_R_AP2 { get; set; }
        public string CODE_DECISION_SESSION_P_AP3 { get; set; }
        public string LIB_DECISION_SESSION_P_AP3 { get; set; }
        public string CODE_DECISION_SESSION_R_AP3 { get; set; }
        public string LIB_DECISION_SESSION_R_AP3 { get; set; }
        public Nullable<decimal> MOY_P_AP1 { get; set; }
        public Nullable<decimal> MOY_R_AP1 { get; set; }
        public Nullable<decimal> MOY_P_AP2 { get; set; }
        public Nullable<decimal> MOY_R_AP2 { get; set; }
        public Nullable<decimal> MOY_P_AP3 { get; set; }
        public Nullable<decimal> MOY_R_AP3 { get; set; }
        public Nullable<byte> NB_IMP_RELEVE { get; set; }
        public string CODE_BARRE { get; set; }
        public string MOY_BAC_ET { get; set; }
        public string LOGIN { get; set; }
        public string PASSWORD { get; set; }
        public string FONCTION_PERE_ET { get; set; }
        public string FONCTION_MERE_ET { get; set; }
        public string TEL_MERE_ET { get; set; }
        public string TEL_PERE_ET { get; set; }
        public string EMAIL_PERE_ET { get; set; }
        public string EMAIL_MERE_ET { get; set; }
        public string NOM_PERE_ET { get; set; }
        public string NOM_MERE_ET { get; set; }
        public string ANNEE_BAC { get; set; }
        public string ANNEE_DIPLOME { get; set; }
        public Nullable<decimal> MOY_BAC_ET2 { get; set; }
        public Nullable<decimal> ENTRETIEN_ANGLAIS { get; set; }
        public Nullable<decimal> ENTRETIEN_FRANCAIS { get; set; }
        public string ENS_ID_ENS { get; set; }
        public Nullable<int> COMITE_ID_GRP { get; set; }
        public string FK_ENS { get; set; }
        public string FK_ENSEI { get; set; }
        public Nullable<decimal> TEL_ET1 { get; set; }
        public Nullable<decimal> MOY_BAC { get; set; }
        public string FILIERE_PREPA { get; set; }
        public string LIB_FILIERE_PREPA { get; set; }
        public string DATEENTR { get; set; }
        public decimal SCORE_FINAL { get; set; }
        public Nullable<decimal> SCORE_MIN_ADMIN { get; set; }
        public string USER_TRANSF_PREINSCRIT { get; set; }
        public Nullable<System.DateTime> DATE_TRANSF_PREINSCRIT { get; set; }
        public Nullable<bool> NUM_LOT { get; set; }
        public string RECOMMANDATION { get; set; }
        public string GOUVERNORAT { get; set; }
        public string ADRESSE_MAIL_ESP { get; set; }
        public string PWD_ET { get; set; }
        public string PWD_ET_INIT { get; set; }
        public string SUIVI_PARTICULIER { get; set; }
        public string NIVEAU_COURANT_ANG { get; set; }
        public string NIVEAU_COURANT_FR { get; set; }
        public string NOM_ARB { get; set; }
        public string PNOM_ARB { get; set; }
        public string LIEU_NAIS_ARB { get; set; }
        public string NATURE_BAC_ARB { get; set; }
        public string DIPLOME_SUP_ARB { get; set; }
        public string ETAB_ORIGINE_ARB { get; set; }
        public string ID_ELEVE_EDUSERV { get; set; }
        public string PWD_PARENT { get; set; }
        public Nullable<short> NUM_ANNUEL_DIPLOME { get; set; }
        public Nullable<byte> NUM_ANNEXE { get; set; }
        public string ORIENTATION { get; set; }
        public string GROUPE_TARIF { get; set; }
        public string CAT_ETAB_ORIGINE { get; set; }
        public string ETAB_ORIGIN_NEW { get; set; }
        public string CODE_RFID { get; set; }
        public Nullable<System.DateTime> DATE_HEURE_CREATION { get; set; }
        public string ORA_ROWSCN { get; set; }
        public string CHOIX_A_B { get; set; }
        public string CODE_GOUVERNORAT { get; set; }
        public string PWD_JWT_ETUDIANT { get; set; }
        public Nullable<System.DateTime> DATE_MODIFY_JWT_PWD { get; set; }
        public Nullable<decimal> NB_DOC_ET { get; set; }
        public string CURSUS_ET { get; set; }
        public string VALID_PROJET { get; set; }
        public string SESSION_COVID { get; set; }
        public string PROLONGATION_RGLT { get; set; }
        public Nullable<System.DateTime> DATE_DEBUT_PRGL { get; set; }
        public Nullable<System.DateTime> DATE_FIN_PRGL { get; set; }
        public Nullable<System.DateTime> DATE_CREATION_TOKEN { get; set; }
        public string TOKEN { get; set; }
        public string TOKN_STUDENT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESP_INSCRIPTION> ESP_INSCRIPTION { get; set; }
    }
}
