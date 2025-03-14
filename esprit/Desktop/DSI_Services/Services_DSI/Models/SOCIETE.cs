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
    
    public partial class SOCIETE
    {
        public string CODE_SOC { get; set; }
        public string NOM_SOC { get; set; }
        public string ADR_SOC { get; set; }
        public string TEL_SOC { get; set; }
        public string FAX_SOC { get; set; }
        public byte[] SIGLE { get; set; }
        public string E_MAIL { get; set; }
        public string CODE_POSTAL { get; set; }
        public Nullable<System.DateTime> DATE_CR { get; set; }
        public Nullable<System.DateTime> DATE_MAJ { get; set; }
        public string VILLE { get; set; }
        public string RIB { get; set; }
        public string CODE_TVA { get; set; }
        public string BANQUE { get; set; }
        public string RC { get; set; }
        public string CODE_RGLT_COMPTANT { get; set; }
        public string CODE_RGLT_ESPECE { get; set; }
        public string ANNEE_DEB { get; set; }
        public string ANNEE_FIN { get; set; }
        public Nullable<decimal> TAUX_EXAM { get; set; }
        public Nullable<decimal> TAUX_DS { get; set; }
        public Nullable<decimal> TAUX_TP { get; set; }
        public Nullable<decimal> TAUX_ORALE { get; set; }
        public Nullable<decimal> NB_MAX_ABS_MODULE { get; set; }
        public Nullable<decimal> NB_SCEANCE_JOUR { get; set; }
        public string SYMBOLE { get; set; }
        public Nullable<decimal> TIMB_FISCAL { get; set; }
        public Nullable<decimal> TIMBRE_FISCAL { get; set; }
        public Nullable<System.DateTime> DATE_DEBUT_SAISON { get; set; }
        public Nullable<decimal> NUM_SEMESTRE_ACTUEL { get; set; }
        public string CHEMIN_FICHIER_DONNEE { get; set; }
        public Nullable<decimal> TAUX_EXAM_WITH_CC { get; set; }
        public Nullable<decimal> TAUX_EXAM_WITH_TP_CC { get; set; }
        public Nullable<decimal> MIN_MOY_RESUSSITE { get; set; }
        public Nullable<decimal> BI_RACHAT { get; set; }
        public Nullable<decimal> BS_RACHAT { get; set; }
        public string ID_VACATAIRE { get; set; }
        public string GERER_SEMESTRE { get; set; }
        public Nullable<decimal> FR_SCOLARITE_CS { get; set; }
        public Nullable<decimal> FR_SCOLARITE_CJ { get; set; }
        public Nullable<decimal> MIN_PANIER { get; set; }
        public string ID_DIRET { get; set; }
        public string ID_SERV_SCOLAIRE { get; set; }
        public string LIAISON_FINANCIER { get; set; }
        public Nullable<decimal> TAUX_RGLT { get; set; }
        public string LIAISON_SITE { get; set; }
        public Nullable<short> NUMPROMOTIONCS { get; set; }
        public Nullable<System.DateTime> DATEDEMARRAGECS { get; set; }
        public string CONTROL_BALCKLISTE { get; set; }
        public Nullable<decimal> MAX_VAL_CREDIT_ACCEPTE { get; set; }
        public Nullable<decimal> MAX_TAUX_CREDIT_ACCEPTE { get; set; }
        public Nullable<decimal> CREDIT_MAX { get; set; }
        public string ACTIVE_DISPENSE_AUTO { get; set; }
        public string ACTIVE_MP_ENS { get; set; }
        public string ACTIVE_MODULE_OPT { get; set; }
        public string VERROU_RESUL { get; set; }
        public Nullable<decimal> TOT_ECTS_ADMIS { get; set; }
        public Nullable<decimal> QUOTA_ECTS_NV { get; set; }
        public string ACTIVER_TAUX_ABSENCE { get; set; }
        public Nullable<decimal> TAUX_MAX_ABSENCE { get; set; }
        public Nullable<decimal> NBH_SEMAINE { get; set; }
        public string BLOCK_OTHER_RAT { get; set; }
        public Nullable<decimal> CTRL_CONFORM_ECTS { get; set; }
        public string CTRL_FIN_STAT { get; set; }
        public string VERROU_PL_ETUDE { get; set; }
        public string ANNEE_ADMISSION { get; set; }
        public string DELIB_RESULTATS { get; set; }
        public string AFFICH_NOTE { get; set; }
        public Nullable<byte> DUREE_PFE { get; set; }
        public string ANNEE { get; set; }
    }
}
