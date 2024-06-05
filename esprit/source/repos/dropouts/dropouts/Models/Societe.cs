using System;
using System.Collections.Generic;

namespace dropouts.Models
{
    public partial class Societe
    {
        public string CodeSoc { get; set; } = null!;
        public string? NomSoc { get; set; }
        public string? AdrSoc { get; set; }
        public string? TelSoc { get; set; }
        public string? FaxSoc { get; set; }
        public string? Sigle { get; set; }
        public string? EMail { get; set; }
        public string? CodePostal { get; set; }
        public DateOnly? DateCr { get; set; }
        public DateOnly? DateMaj { get; set; }
        public string? Ville { get; set; }
        public string? Rib { get; set; }
        public string? CodeTva { get; set; }
        public string? Banque { get; set; }
        public string? Rc { get; set; }
        public string? CodeRgltComptant { get; set; }
        public string? CodeRgltEspece { get; set; }
        public string? AnneeDeb { get; set; }
        public string? AnneeFin { get; set; }
        public int? TauxExam { get; set; }
        public int? TauxDs { get; set; }
        public int? TauxTp { get; set; }
        public int? TauxOrale { get; set; }
        public int? NbMaxAbsModule { get; set; }
        public int? NbSceanceJour { get; set; }
        public char? Symbole { get; set; }
        public int? TimbFiscal { get; set; }
        public int? TimbreFiscal { get; set; }
        public DateOnly? DateDebutSaison { get; set; }
        public int? NumSemestreActuel { get; set; }
        public string? CheminFichierDonnee { get; set; }
        public int? TauxExamWithCc { get; set; }
        public int? TauxExamWithTpCc { get; set; }
        public int? MinMoyResussite { get; set; }
        public int? BiRachat { get; set; }
        public int? BsRachat { get; set; }
        public string? IdVacataire { get; set; }
        public string? GererSemestre { get; set; }
        public int? FrScolariteCs { get; set; }
        public int? FrScolariteCj { get; set; }
        public int? MinPanier { get; set; }
        public string? IdDiret { get; set; }
        public string? IdServScolaire { get; set; }
        public string? LiaisonFinancier { get; set; }
        public int? TauxRglt { get; set; }
        public string? LiaisonSite { get; set; }
        public int? Numpromotioncs { get; set; }
        public DateOnly? Datedemarragecs { get; set; }
        public string? ControlBalckliste { get; set; }
        public int? MaxValCreditAccepte { get; set; }
        public int? MaxTauxCreditAccepte { get; set; }
        public int? CreditMax { get; set; }
        public string? ActiveDispenseAuto { get; set; }
        public string? ActiveMpEns { get; set; }
        public string? ActiveModuleOpt { get; set; }
        public string? VerrouResul { get; set; }
        public int? TotEctsAdmis { get; set; }
        public int? QuotaEctsNv { get; set; }
        public string? ActiverTauxAbsence { get; set; }
        public int? TauxMaxAbsence { get; set; }
        public int? NbhSemaine { get; set; }
        public string? BlockOtherRat { get; set; }
        public int? CtrlConformEcts { get; set; }
        public string? CtrlFinStat { get; set; }
        public string? VerrouPlEtude { get; set; }
        public string? AnneeAdmission { get; set; }
        public string? DelibResultats { get; set; }
        public string AffichNote { get; set; } = null!;
        public int? DureePfe { get; set; }
        public string? Annee { get; set; }
        public string? ActiverSignature { get; set; }
    }
}
