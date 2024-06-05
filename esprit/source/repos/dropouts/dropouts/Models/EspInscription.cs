using System;
using System.Collections.Generic;

namespace dropouts.Models
{
    public partial class EspInscription
    {
        public string AnneeDeb { get; set; } = null!;
        public string? AnneeFin { get; set; }
        public string CodeCl { get; set; } = null!;
        public string IdEt { get; set; } = null!;
        public int? CoutAnnuel { get; set; }
        public int? FraisIns { get; set; }
        public string? TypeRglt { get; set; }
        public string? ModeRglt { get; set; }
        public string? CodeDev { get; set; }
        public int? CoutDev { get; set; }
        public string? SitRglt { get; set; }
        public int? CreditRglt { get; set; }
        public int? NbCreditModule { get; set; }
        public int? MoySem1 { get; set; }
        public int? MoySem2 { get; set; }
        public int? MoyGeneral { get; set; }
        public string? Resultat { get; set; }
        public int? NiveauAccees { get; set; }
        public string TypeInsc { get; set; } = null!;
        public int? Semestre { get; set; }
        public string? NivLangue { get; set; }
        public string? CodeClLangue { get; set; }
        public string? Utilisateur { get; set; }
        public string? DernUtilisateur { get; set; }
        public string? DatePreinsc { get; set; }
        public string? DateInsc { get; set; }
        public string? CodeCl1 { get; set; }
        public string? CodeCl2 { get; set; }
        public int? MoyRatt { get; set; }
        public string? Observation { get; set; }
        public int? Numpromotioncs { get; set; }
        public string? CodeDecisionSessionP { get; set; }
        public string? LibDecisionSessionP { get; set; }
        public string? CodeDecisionSessionRat { get; set; }
        public string? LibDecisionSessionRat { get; set; }
        public int? NbImpAttestReussite { get; set; }
        public DateOnly? DateLastMajDecisionPrinc { get; set; }
        public DateOnly? DateLastMajDecisionRatt { get; set; }
        public string? CreditAnt { get; set; }
        public int? NbImpReleve { get; set; }
        public string? EtatEntretien { get; set; }
        public DateOnly? DateLastModifRat2 { get; set; }
        public int? MoyRat2 { get; set; }
        public string? CodeDecisionSessionRat2 { get; set; }
        public string? LibDecisionSessionRat2 { get; set; }
        public string? AdmisRach { get; set; }
        public int? MoyRatAvRach { get; set; }
        public string? AdmisTs { get; set; }
        public string? DateLimProlongRglt { get; set; }
        public string? NivAcquisFrancais { get; set; }
        public int? MajNiveauDefinitif { get; set; }
        public string? Reserve { get; set; }
        public int? NbEctsSp { get; set; }
        public int? NbEctsSr { get; set; }
        public string? NivAcquisAnglais { get; set; }
        public DateOnly? DateTestFr { get; set; }
        public DateOnly? DateTestAng { get; set; }
        public string PrepToeic { get; set; } = null!;
        public string TestToeic { get; set; } = null!;
        public string EtatInsTestNiv { get; set; } = null!;
        public string? UserLangModif { get; set; }
        public int? RangSp { get; set; }
        public int? NumAnnuelDiplome { get; set; }
        public int? NumAnnexe { get; set; }
        public string? GroupeTarif { get; set; }
        public int? MoyGenAvPfe { get; set; }
        public int? NbEctsAvPfe { get; set; }
        public int? NotePfe { get; set; }
        public int? CoefPfe { get; set; }
        public int? MoyGenAvPfeSp { get; set; }
        public int? MoyGenAvPfeSr { get; set; }
        public int? EtatFinancier { get; set; }
        public int? TemNum { get; set; }
        public int? MgSeved { get; set; }
        public string? RachatUeEt { get; set; }
        public string? EncadrantPeda { get; set; }
        public string DateCreation { get; set; } = null!;
        public int? NumMoisInsc { get; set; }
        public int? NumSemaine { get; set; }
        public string? Ne { get; set; }
        public DateOnly? DateNe { get; set; }
        public int? GroupeRglt { get; set; }
        public string? Ne2 { get; set; }
        public int? SoldeEt { get; set; }
        public string? ExpertPeda { get; set; }
        public string? MotifRglt { get; set; }
    }
}
